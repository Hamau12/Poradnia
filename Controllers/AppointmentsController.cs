using Microsoft.AspNetCore.Mvc;
using Poradnia.Services;
using static Poradnia.Models.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SRP.interfaces;
using SRP.Interfaces;
using SRP.Models;
using SRP.Models.Enties;

namespace Poradnia.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {

        private readonly DoctorDbContext _context;
        private readonly IAsyncRepository<Specialist> _specialistRepository;
        private readonly ICurrentUserService _currentUserService;

        public AppointmentsController(DoctorDbContext context, IAsyncRepository<Specialist> specialistRepository, ICurrentUserService currentUserService)
        {
            _context = context;
            _specialistRepository = specialistRepository;
            _currentUserService = currentUserService;
        }

        // GET: api/Appointments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentSlot>>> GetAppointments([FromQuery] DateTime start, [FromQuery] DateTime end )
        {
            var idSpecialist = _currentUserService.UserId;
            return await _context.Appointments.Where(e => !((e.End <= start) || (e.Start >= end)) && e.SpecialistId == idSpecialist).ToListAsync();
        }

        [HttpGet("free")]
        public async Task<ActionResult<IEnumerable<AppointmentSlot>>> GetAppointments([FromQuery] DateTime start, [FromQuery] DateTime end, [FromQuery] Guid patient, [FromQuery] string idSpecialist)
        {
            var idExperts = _specialistRepository.FindByIncludeAsync(x=>x.Id.ToString().Contains(idSpecialist),inc=>inc.User).Result.User.Id;
            return await _context.Appointments.Where(e => (e.Status == "free" || (e.PatientId == patient)) && !((e.End <= start) || (e.Start >= end)) && e.SpecialistId == idExperts).ToListAsync();
        }

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentSlot>> GetAppointmentSlot(Guid id)
        {
            var appointmentSlot = await _context.Appointments.FindAsync(id);

            if (appointmentSlot == null)
            {
                return NotFound();
            }

            return appointmentSlot;
        }

        // PUT: api/Appointments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointmentSlot(Guid id, AppointmentSlotUpdate update)
        {
            var idSpecialist = _currentUserService.UserId;
            var appointmentSlot = await _context.Appointments.FindAsync(id);
            if (appointmentSlot == null)
            {
                return NotFound();
            }

            appointmentSlot.Start = update.Start;
            appointmentSlot.End = update.End;

            if (update.Name != null)
            {
                appointmentSlot.PatientName = update.Name;
            }
            if (update.Status != null)
            {
                appointmentSlot.Status = update.Status;
            }

            _context.Appointments.Update(appointmentSlot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        public class AppointmentSlotUpdate
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public string? Name { get; set; }
            public string? Status { get; set; }

        }


        // PUT: api/Appointments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}/request")]
        public async Task<IActionResult> PutAppointmentSlotRequest(Guid id, AppointmentSlotRequest slotRequest )
        {
            var userId = _currentUserService.UserId;
            var appointmentSlot = await _context.Appointments.FindAsync(id);
            if (appointmentSlot == null)
            {
                return NotFound();
            }

            appointmentSlot.PatientName = slotRequest.Name;
            appointmentSlot.PatientId = userId;
            appointmentSlot.Status = "waiting";

            _context.Appointments.Update(appointmentSlot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        public class AppointmentSlotRequest
        {
            public Guid PatientId { get; set; }
            public string Name { get; set; }

        }

        // POST: api/Appointments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppointmentSlot>> PostAppointmentSlot(AppointmentSlot appointmentSlot)
        {
            var idSpecialist = _currentUserService.UserId;
            appointmentSlot.SpecialistId = idSpecialist;
            _context.Appointments.Add(appointmentSlot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointmentSlot", new { id = appointmentSlot.Id }, appointmentSlot);
        }

        [HttpPost("create")]
        public async Task<ActionResult<AppointmentSlot>> PostAppointmentSlots(AppointmentSlotRange range)
        {
            var idSpecialist = _currentUserService.UserId;
            var existing = await _context.Appointments.Where(e => !((e.End <= range.Start) || (e.Start >= range.End)) && e.SpecialistId == idSpecialist).ToListAsync();
            var slots = Timeline.GenerateSlots(range.Start, range.End, range.Weekends,idSpecialist);
            slots.ForEach(slot =>
            {
                var overlaps = existing.Any(e => !((e.End <= slot.Start) || (e.Start >= slot.End)) && e.SpecialistId == idSpecialist);
                if (overlaps)
                {
                    return;
                }
                _context.Appointments.Add(slot);
            });

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("clear")]
        public async Task<ActionResult<AppointmentSlot>> PostAppointmentClear(ClearRange range)
        {
            var idSpecialist = _currentUserService.UserId;
            var start = range.Start;
            var end = range.End;

            _context.Appointments.RemoveRange(_context.Appointments.Where(e => e.Status == "free" && !((e.End <= start) || (e.Start >= end)) && e.SpecialistId == idSpecialist));
            await _context.SaveChangesAsync();

            return NoContent();
        }


        public class ClearRange
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }

        public class AppointmentSlotRange
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public bool Weekends { get; set; }
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointmentSlot(Guid id)
        {
            var appointmentSlot = await _context.Appointments.FindAsync(id);
            if (appointmentSlot == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointmentSlot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppointmentSlotExists(Guid id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}

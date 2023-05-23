using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SRP.interfaces;
using SRP.Interfaces;
using SRP.Models;
using SRP.Models.DTOs;
using SRP.Models.Enties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SRP.Controllers
{
    public class ExpertsController : BaseController
    {
        public ExpertsController(IAsyncRepository<SRPUser> userRepository, IMapper mapper, ICurrentUserService currentUserService, IAsyncRepository<Specialist> doctorRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _currentUserService = currentUserService;
            _doctorRepository = doctorRepository;
        }

        public IAsyncRepository<SRPUser> _userRepository { get; }
        public IMapper _mapper { get; }
        public ICurrentUserService _currentUserService { get; }
        public IAsyncRepository<Specialist> _doctorRepository { get; }

        public async Task<IActionResult> GetAllDoctor()
        {
            var doctors = _doctorRepository.GetAll().ToList();
            return View("DisplayDoctor", _mapper.Map<IList<SpecialistDTO>>(doctors));
        }
        [Authorize(Roles = "Admin, SuperAdmin, Specialist")]
        public async Task<IActionResult> Index()
        {
            var doctor = await _userRepository.FindManyByIncludeAsync(x => x.UserRoles.Any(x => x.Role.Name == "Specialist"));
            var result = _mapper.Map<IList<SRPUserDTO>>(doctor);

            return View(result);
        }
        [Authorize(Roles = "Admin, SuperAdmin, Specialist")]
        public async Task<IActionResult> PuplishDoctor()
        {
            return View();
        }
        [Authorize(Roles = "Specialist")]
        public async Task<IActionResult> PanelVisits()
        {
            return RedirectToPage("/Doctor");
        }
        [Authorize]
        public async Task<IActionResult> PatientsPanel(Guid parametr)
        {
            TempData["Parametr"] = parametr.ToString();
            return RedirectToPage("/Patient");
        }
        [Authorize(Roles = "Admin, SuperAdmin, Specialist")]
        [HttpPost]
        public async Task<IActionResult> PuplishDoctor(IFormFile formFile, Specialist newDoctor)
        {
            try
            {
                if (formFile != null && (Path.GetExtension(formFile.FileName) == ".png" || Path.GetExtension(formFile.FileName) == ".jpg") || Path.GetExtension(formFile.FileName) == ".jpeg") ;
                {
                    var name = RenameFile(formFile.FileName, newDoctor.Id);
                    var mainPath = Path.Combine("wwwroot", "Images", "Profil");
                    var filePath = Path.Combine(mainPath, name);

                    if (!Directory.Exists(mainPath))
                    {
                        Directory.CreateDirectory(mainPath);
                    }
                    await using (Stream stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    var user = await _userRepository.FindByIncludeAsync(x => x.Id == newDoctor.Id);
                    var doctor = new Specialist
                    {
                        User = user,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Description = newDoctor.Description,
                        ImageName = name,
                        Specialisation = newDoctor.Specialisation,
                        Created = DateTime.Now,
                        CreatedBy = _currentUserService.UserId
                    };

                    await _doctorRepository.AddAsync(doctor);
                    user.IsDoctor = true;
                    await _userRepository.UpdateAsync(user);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewData["error"] = "Nie dodano specialisty, czy o czmyś nie zapomniałeś?";
                return RedirectToAction("Index");
            }
           
        }
        [Authorize(Roles = "Admin, SuperAdmin, Specialist")]
        public async Task<IActionResult> UnPuplishDoctor(Specialist Doctor)
        {
            var user = await _userRepository.FindByIncludeAsync(x => x.Id == Doctor.Id);
            var doctor = await _doctorRepository.FindByIncludeAsync(x => x.User == user);
            var mainPath = Path.Combine("wwwroot", "Images", "Profil");
            var filePath = Path.Combine(mainPath, doctor.ImageName);
            System.IO.File.Delete(filePath);
            await _doctorRepository.DeleteAsync(doctor);
            user.IsDoctor = false;
            await _userRepository.UpdateAsync(user);
            return RedirectToAction("Index");
        }
        private string RenameFile(string fileName, Guid Id)
        {
            string extension = Path.GetExtension(fileName.ToString());
            var newName = Path.GetRandomFileName().Replace(".", "") + extension;
            return newName;
        }

    }
}


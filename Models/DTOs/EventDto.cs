using SRP.Models.Enties;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SRP.Models.DTOs
{
    public class EventDto
    {

        [Required(ErrorMessage = "Podaj tytuł.")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }

        [Required(ErrorMessage = "Treść opisu nie może być pusta.")]
        [Display(Name = "Treść")]
        public string Description { get; set; }
        [Display(Name = "Wybierz status zgłoszenia")]
        [Required(ErrorMessage = "Określ status zgłoszenia.")]
        public Status Status { get; set; }
        public int? PeopleCount { get; set; }
    }
}

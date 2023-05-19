using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SRP.Models.Enums
{
    public enum Specialisation
    {
        [Display(Name = "Psychologia Ogólna")]
        PsychologiaOgólna,
        [Display(Name = "Terapia Uzależnień")]
        TerapiaUzależnień,
        Fizjoterapia,
        Sexuologia,
        Neuropsychologia

    }
}

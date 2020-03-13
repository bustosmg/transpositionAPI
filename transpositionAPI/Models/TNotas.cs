using System.ComponentModel.DataAnnotations;

namespace transpositionAPI.Models
{
    public class TNotas
    {
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string acordesCromaticos { get; set; }

        public string acordesCromaticosMayores { get; set; }
        public string acordesCromaticosMenores { get; set; }
        public string acordesSeptimaMayor { get; set; }
        public string acordesSeptimaMenor { get; set; }

    }
}

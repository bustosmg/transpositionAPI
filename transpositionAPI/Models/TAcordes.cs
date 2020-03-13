using System.ComponentModel.DataAnnotations;

namespace transpositionAPI.Models
{
    public class TAcordes
    {
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false)]
        public string AcordesCromaticas { get; set; }
        public string acordesCromaticasMayores { get; set; }
        public string acordesCromaticasMenores { get; set; }
        public string acordesSeptimaMayor { get; set; }
        public string acordesSeptimaMenor { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace transpositionAPI.Models
{
    public class TNotas
    {
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string notasCromaticas { get; set; }
        public string notasCromaticasMayores { get; set; }
        public string notasCromaticasMenores { get; set; }
        public string notasCromaticasSeptimaMayores { get; set; }
        public string notasCromaticasSeptimaMenores { get; set; }

    }
}

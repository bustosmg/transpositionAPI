using System.ComponentModel.DataAnnotations;

namespace transpositionAPI.Models
{
    public class TNotas
    {
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string notasCromaticas { get; set; }

    }
}

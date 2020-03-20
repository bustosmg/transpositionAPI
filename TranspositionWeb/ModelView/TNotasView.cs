 using System.ComponentModel.DataAnnotations;

namespace transpositionWeb.ModelView
{
    public class TNotasView
    {
        [Required]
        public int Id { get; set; }

        public string notasCromaticas { get; set; }

        public bool IsChecked { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Payment.Models.ViewModels
{
    public class RecordViewModels
    {
        [Required]
        [Display(Name = "Concept")]
        public string Concept { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public int Amount { get; set; }
    }
}

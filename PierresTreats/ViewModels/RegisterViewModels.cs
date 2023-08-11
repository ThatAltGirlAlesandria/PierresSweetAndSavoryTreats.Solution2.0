using System.ComponentModel.DataAnnotations;

namespace PierresTreats.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Email { get; set; }
  }
}
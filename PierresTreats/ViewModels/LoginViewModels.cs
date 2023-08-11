using System.ComponentModel.DataAnnotations;

namespace PierresTreats.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email address")]
    public string Email { get; set;}

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}
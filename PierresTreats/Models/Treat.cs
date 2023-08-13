using System.Collection.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public ApplicationUser User { get; set; }
    [Required(ErrorMessage = "This field cannot be")]
    public int TreatId { get; set; }
    public int TreatCount { get; set; }
    public List<FlavoredTreat> joinEntities { get; }
    public string TreatDetails { get; set; }
    public string TreatName { get; set; }
  }
}
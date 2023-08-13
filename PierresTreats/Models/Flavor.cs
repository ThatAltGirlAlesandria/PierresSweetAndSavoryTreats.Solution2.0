using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Please fill in the fields below.")]
    public string FlavorType { get; set; }
    public string FlavorDescription { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}
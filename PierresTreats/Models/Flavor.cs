using System.Collection.Generic;
using System.Component.DataAnnotations;

namespace PierresTreats.Models;
{
  public class Flavor
  {
    public Application User { get; set; }
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "This field cannot be")]
    public List<FlavoredTreat> joinEntities { get; }
    public string FlavorDetails { get; set; }
    public string FlavorName { get; set; }
  }
}
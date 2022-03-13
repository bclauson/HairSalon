
namespace SalonTracker.Models
{
  public class clients
  {

    public int clientsId { get; set; }
    public string clientName { get; set; }
    public int stylistId { get; set; }
    public virtual stylists stylist { get; set; }
  }
}   
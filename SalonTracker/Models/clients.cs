namespace SalonTracker.Models
{
  public class clients
  {
    public int clientId { get; set; }
    public string Name { get; set; }
    public int stylistId { get; set; }
    public virtual stylists stylist { get; set; }
  }
}   
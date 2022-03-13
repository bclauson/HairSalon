using System.Collections.Generic;

namespace SalonTracker.Models
{
  public class stylists
  {
    public stylists()
    {
      this.clients = new HashSet<clients>();
    }
    public int stylistsId { get; set; }
    public string stylistName { get; set; }
    public virtual ICollection<clients> clients { get; set; }
  }
}
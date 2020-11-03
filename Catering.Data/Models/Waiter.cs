using System.Collections.Generic;

namespace Catering.Data.Models
{
    public class Waiter
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<CateringOrder> CateringOrders { get; set; }
    }
}

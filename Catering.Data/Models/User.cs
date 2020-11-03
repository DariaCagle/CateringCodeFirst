using System.Collections.Generic;

namespace Catering.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<CateringOrder> CateringOrders { get; set; }
    }
}

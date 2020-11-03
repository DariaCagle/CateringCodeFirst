using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.Data.Models
{
    public class ChefType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CateringOrder> CateringOrders { get; set; }
    }
}

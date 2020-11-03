using System.Collections.Generic;

namespace Catering.Data.Models
{
    public class ChefType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CateringOrder> CateringOrders { get; set; }
    }
}

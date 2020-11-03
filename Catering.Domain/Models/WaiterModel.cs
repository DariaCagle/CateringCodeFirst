using System.Collections.Generic;

namespace Catering.Domain.Models
{
    public class WaiterModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<CateringOrderModel> CateringOrders { get; set; }
    }
}

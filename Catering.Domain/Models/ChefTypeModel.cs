using System.Collections.Generic;

namespace Catering.Domain.Models
{
    public class ChefTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CateringOrderModel> CateringOrders { get; set; }
    }
}

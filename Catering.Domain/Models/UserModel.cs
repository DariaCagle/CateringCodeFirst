using System.Collections.Generic;

namespace Catering.Domain.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public ICollection<CateringOrderModel> CateringOrders { get; set; }
    }
}

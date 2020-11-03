using System.Collections.Generic;

namespace Catering.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public ICollection<CateringOrderViewModel> CateringOrders { get; set; }
    }
}

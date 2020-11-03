using System.Collections.Generic;

namespace Catering.Models.ViewModels
{
    public class WaiterViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<CateringOrderViewModel> CateringOrders { get; set; }

    }
}

using System.Collections.Generic;

namespace Catering.Models.ViewModels
{
    public class ChefTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CateringOrderViewModel> CateringOrders { get; set; }
    }
}

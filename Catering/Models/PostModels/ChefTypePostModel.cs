using System.Collections.Generic;

namespace Catering.Models.PostModels
{
    public class ChefTypePostModel
    {
        public string Name { get; set; }
        public ICollection<CateringOrderPostModel> CateringOrders { get; set; }
    }
}

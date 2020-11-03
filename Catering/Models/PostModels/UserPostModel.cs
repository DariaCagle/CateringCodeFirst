using System.Collections.Generic;

namespace Catering.Models.PostModels
{
    public class UserPostModel
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public ICollection<CateringOrderPostModel> CateringOrders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.Models.PostModels
{
    public class WaiterPostModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<CateringOrderPostModel> CateringOrders { get; set; }
    }
}

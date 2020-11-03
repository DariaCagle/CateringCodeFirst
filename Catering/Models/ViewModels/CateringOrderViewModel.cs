using System;
using System.Collections.Generic;

namespace Catering.Models.ViewModels
{
    public class CateringOrderViewModel
    {
        public int Id { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }

        public int ChefTypeId { get; set; }
        public ChefTypeViewModel ChefType { get; set; }

        public int WaiterId { get; set; }
        public WaiterViewModel Waiter { get; set; }
    }
}

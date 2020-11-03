using System;
using System.Collections;
using System.Collections.Generic;

namespace Catering.Data.Models
{
    public class CateringOrder
    {
        public int Id { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public int ChefTypeId { get; set; }
        public virtual ChefType ChefType { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Waiter> Waiters { get; set; }
    }
}

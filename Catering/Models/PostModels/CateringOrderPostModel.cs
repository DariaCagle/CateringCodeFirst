using System;

namespace Catering.Models.PostModels
{
    public class CateringOrderPostModel
    {
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public UserPostModel User { get; set; }

        public int ChefTypeId { get; set; }
        public ChefTypePostModel ChefType { get; set; }
    }
}

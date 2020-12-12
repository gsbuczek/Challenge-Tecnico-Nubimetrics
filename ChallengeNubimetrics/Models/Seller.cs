using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeNubimetrics.Models
{
    public class Seller
    {
        public int id { get; set; }
        public string permalink { get; set; }
        public DateTime registration_date { get; set; }
        public bool car_dealer { get; set; }
        public bool real_estate_agency { get; set; }
        public IList<string> tags { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public Eshop eshop { get; set; }
    }
}
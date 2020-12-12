using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeNubimetrics.Models
{
    public class SellerReputation
    {
        public Transactions transactions { get; set; }
        public string power_seller_status { get; set; }
        public Metrics metrics { get; set; }
        public string level_id { get; set; }
        public DateTime? protection_end_date { get; set; }
        public string real_level { get; set; }
    }
}
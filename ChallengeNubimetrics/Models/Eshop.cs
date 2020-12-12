using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeNubimetrics.Models
{
    public class Eshop
    {
        public string nick_name { get; set; }
        public object eshop_rubro { get; set; }
        public int eshop_id { get; set; }
        public IList<object> eshop_locations { get; set; }
        public string site_id { get; set; }
        public string eshop_logo_url { get; set; }
        public int eshop_status_id { get; set; }
        public int seller { get; set; }
        public int eshop_experience { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeNubimetrics.Models
{
    public class Producto
    {
        public string site_id { get; set; }
        public string query { get; set; }
        public Paging paging { get; set; }
        public IList<Result> results { get; set; }
        public Sort sort { get; set; }
        public IList<AvailableSort> available_sorts { get; set; }
        public IList<Filter> filters { get; set; }
        public IList<AvailableFilter> available_filters { get; set; }
}
}
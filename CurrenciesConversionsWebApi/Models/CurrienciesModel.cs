using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrenciesConversionsWebApi.Models
{
    public class CurrienciesModel
    {
            public string id { get; set; }
            public string symbol { get; set; }
            public string description { get; set; }
            public int decimal_places { get; set; }
            public double status { get; set; }


    }
}
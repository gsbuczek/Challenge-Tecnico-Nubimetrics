using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeNubimetrics.Models
{
    public class Transactions
    {
        public int total { get; set; }
        public int canceled { get; set; }
        public string period { get; set; }
        public Ratings ratings { get; set; }
        public int completed { get; set; }
    }
}
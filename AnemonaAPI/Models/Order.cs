using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnemonaAPI.Models
{
    public class Order
    {
        public int id { get; set; }

        public string buyerName { get; set; }

        public string price { get; set; }

        public DateTime date { get; set; }

        public List<Product> products {get; set;}

        public string notes { get; set; }
    }
}
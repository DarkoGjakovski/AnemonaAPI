using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnemonaAPI.Models
{
    public class Product
    {
        public int id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool available { get; set; }
        public int price { get; set; }
    }
}
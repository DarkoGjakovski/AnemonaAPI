using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnemonaAPI.Models
{
    public class Category
    {
        public int id { get; set; }

        public string title { get; set; }

        public List<Product> products { get; set; }
    }
}
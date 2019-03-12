using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products_ScafPag.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        // id book
        public int Id { get; set; }
        // name book
        public string Name { get; set; }
        // author book
        public string Author { get; set; }
        // price
        public int Price { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Purchase
    {
        // id
        public int PurchaseId { get; set; }
        // first and second name
        public string Person { get; set; }
        //adress Purchase
        public string Address { get; set; }
        // id book
        public int BookId { get; set; }
        //date sell
        public DateTime Date { get; set; }
    }
}
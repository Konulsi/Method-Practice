using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._12._2022_homeWork.Models
{
    internal class Order
    {
        public DateTime Date  { get; set; }
        public double  Price { get; set; }
        public string Status { get; set; }

        public Order( DateTime date, double price, string status)
        {
            Date = date;
            Price = price;
            Status = status;
        }


    }
}

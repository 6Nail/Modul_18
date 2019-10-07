using System;
using System.Collections.Generic;
using System.Text;

namespace HW18
{
    public class PriceAttribute : System.Attribute
    {
        public string Price { get; set; }

        public PriceAttribute(string price)
        {
            Price = price;
        }
    }
}

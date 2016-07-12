using System;
using System.Collections.Generic;
using System.Linq;

namespace ShippingCart
{
    public class HarryPotterShippingCart
    {
        public HarryPotterShippingCart()
        {
        }

        public double CalculateFee(List<Book> booklist)
        {
            return booklist.Sum(x => x.Qty*x.UnitPrice);
        }
    }
}
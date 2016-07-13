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
            return booklist.Sum(x => x.UnitPrice * x.Qty);
        }

        public double Calculate2DifferBookFee(List<Book> booklist)
        {
            return booklist.Sum(x => x.UnitPrice * x.Qty*0.95);
        }
    }
}
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

        public double Calculate3DifferBookFee(List<Book> booklist)
        {
            return booklist.Sum(x => x.UnitPrice * x.Qty * 0.90);
        }

        public double Calculate4DifferBookFee(List<Book> booklist)
        {
            return booklist.Sum(x => x.UnitPrice * x.Qty * 0.80);
        }

        public double Calculate5DifferBookFee(List<Book> booklist)
        {
            return booklist.Sum(x => x.UnitPrice * x.Qty * 0.75);
        }

        public double CalculatePromoteFee(List<Book> booklist)
        {
            Dictionary<string, int> promogrouplist = new Dictionary<string, int>();
            List<Book>  leftbooklist= new List<Book>();
            List<Book> groupbooklist = new List<Book>();
            foreach (var item in booklist)
            {
                if (promogrouplist.ContainsKey(item.Name))
                {
                    leftbooklist.Add(item);
                }
                else
                {
                    groupbooklist.Add(item);
                    promogrouplist.Add(item.Name, 1);
                }
            }
            var totalFee = 0d;
            switch (groupbooklist.Count)
            {
                case 1:
                    totalFee = this.CalculateFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
                    break;
                case 2:
                    totalFee = this.Calculate2DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
                    break;
                case 3:
                    totalFee = this.Calculate3DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
                    break;
                case 4:
                    totalFee = this.Calculate4DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
                    break;
                case 5:
                    totalFee = this.Calculate5DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
                    break;
                default:
                    break;
            }
            return totalFee;   
        }
    }
}
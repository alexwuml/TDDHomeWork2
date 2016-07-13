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

        //private double CalculateFee(List<Book> booklist)
        //{
        //    return booklist.Sum(x => x.UnitPrice * x.Qty);
        //}

        //private double Calculate2DifferBookFee(List<Book> booklist)
        //{
        //    return booklist.Sum(x => x.UnitPrice * x.Qty * 0.95);
        //}

        //private double Calculate3DifferBookFee(List<Book> booklist)
        //{
        //    return booklist.Sum(x => x.UnitPrice * x.Qty * 0.90);
        //}

        //private double Calculate4DifferBookFee(List<Book> booklist)
        //{
        //    return booklist.Sum(x => x.UnitPrice * x.Qty * 0.80);
        //}

        //private double Calculate5DifferBookFee(List<Book> booklist)
        //{
        //    return booklist.Sum(x => x.UnitPrice * x.Qty * 0.75);
        //}

        private double CalculateFee(List<Book> booklist)
        {
            List<double> discountrate = new List<double>()
            {1,
            0.95,
            0.9,
            0.8,
            0.75
            };
            return booklist.Sum(x => x.UnitPrice * x.Qty * discountrate[booklist.Count-1]);
        }

        public double CalculatePromoteFee(List<Book> booklist)
        {
            if (booklist.Count == 0)
                return 0;
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
            //var totalFee = 0d;
            //totalFee = this.CalculateFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //switch (groupbooklist.Count)
            //{
            //    case 1:
            //        totalFee = this.CalculateFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //        break;
            //    case 2:
            //        totalFee = this.Calculate2DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //        break;
            //    case 3:
            //        totalFee = this.Calculate3DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //        break;
            //    case 4:
            //        totalFee = this.Calculate4DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //        break;
            //    case 5:
            //        totalFee = this.Calculate5DifferBookFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            //        break;
            //    default:
            //        break;
            //}
            var totalFee = this.CalculateFee(groupbooklist) + this.CalculatePromoteFee(leftbooklist);
            return totalFee;   
        }

        
    }
}
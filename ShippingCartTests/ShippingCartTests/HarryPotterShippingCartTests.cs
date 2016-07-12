using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCart;
using System.Collections.Generic;

namespace ShippingCartTests
{
    [TestClass]
    public class HarryPotterShippingCartTests
    {
        [TestMethod]
        public void CalculateFee_1book_for_100()
        {
            //Arrange
            var target = new HarryPotterShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.CalculateFee(booklist);

            //Assert
            double expected = 100d;
            Assert.AreEqual(expected, actual);
        }
    }
}

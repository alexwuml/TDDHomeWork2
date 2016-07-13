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
        [TestMethod]
        public void CalculateFee_2diffbooks_for_195()
        {
            //Arrange
            var target = new HarryPotterShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="哈利波特第1集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第2集",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.Calculate2DifferBookFee(booklist);

            //Assert
            double expected = 190d;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFee_vol1_3_for_270()
        {
            //Arrange
            var target = new HarryPotterShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="哈利波特第1集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第2集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第3集",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.Calculate3DifferBookFee(booklist);

            //Assert
            double expected = 270d;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFee_vol1_4_for_320()
        {
            //Arrange
            var target = new HarryPotterShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="哈利波特第1集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第2集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第3集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第4集",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.Calculate4DifferBookFee(booklist);

            //Assert
            double expected = 320d;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFee_vol1_5_for_375()
        {
            //Arrange
            var target = new HarryPotterShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="哈利波特第1集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第2集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第3集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第4集",Qty=1,UnitPrice=100 },
                new Book {Name ="哈利波特第5集",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.Calculate5DifferBookFee(booklist);

            //Assert
            double expected = 375d;
            Assert.AreEqual(expected, actual);
        }
    }
}

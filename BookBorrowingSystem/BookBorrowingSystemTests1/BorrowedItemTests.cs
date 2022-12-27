using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookBorrowingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem.Tests
{
    [TestClass()]
    public class BorrowedItemTests
    {
        Book _book;
        string _inform;
        BorrowedItem _borrowedItem;
        DateTime _borroweddate;
        DateTime _returndate;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _borrowedItem = new BorrowedItem();
            _borroweddate = DateTime.Now;
            _returndate = _borroweddate.AddDays(30);


            _book = new Book();
            _book.NAME = "name";
            _book.NUMBER = "number";
            _book.PUBLICATION = "publication";
            _book.WRITER = "writer";
            _book.COVER = "cover";
            _borrowedItem.BOOK = _book;
            _inform = _book.NAME + "\n編號：" + _book.NUMBER + "\n作者：" + _book.WRITER + "\n" + _book.PUBLICATION;
        }

        //BorrowedItemTest
        [TestMethod()]
        public void BorrowedItemTest()
        {
            Assert.AreEqual(_borroweddate, _borrowedItem.BORROW);
            Assert.AreEqual(_returndate, _borrowedItem.RETURN);
        }

        //BookInformTest
        [TestMethod()]
        public void BookInformTest()
        {
            Assert.AreEqual(1, _borrowedItem.QUANTITY);
            _borrowedItem.QUANTITY = 3;
            Assert.AreEqual(3, _borrowedItem.QUANTITY);
            Assert.AreEqual(_inform, _borrowedItem.BOOK.GetInformation());
        }
    }
}
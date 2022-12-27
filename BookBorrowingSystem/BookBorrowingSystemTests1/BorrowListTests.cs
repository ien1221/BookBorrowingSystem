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
    public class BorrowListTests
    {
        BorrowedItem borrowedItem1;
        BorrowedItem borrowedItem2;
        BorrowList _borrowList;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            borrowedItem1 = new BorrowedItem();
            borrowedItem1.QUANTITY = 2;
            borrowedItem2 = new BorrowedItem();
            borrowedItem2.QUANTITY = 3;
            _borrowList = new BorrowList();
        }

        //AddToBorrowedListTest
        [TestMethod()]
        public void AddToBorrowedListTest()
        {
            Assert.AreEqual(0, _borrowList.COUNT);
            _borrowList.AddToBorrowedList(borrowedItem1);
            Assert.AreEqual(1, _borrowList.COUNT);
            Assert.AreEqual(2, _borrowList.BOOKS);
            _borrowList.AddToBorrowedList(borrowedItem2);
            Assert.AreEqual(2, _borrowList.COUNT);
            Assert.AreEqual(5, _borrowList.BOOKS);
        }

        //GetBorrowedItemTest
        [TestMethod()]
        public void GetBorrowedItemTest()
        {
            _borrowList.AddToBorrowedList(borrowedItem1);
            _borrowList.AddToBorrowedList(borrowedItem2);
            Assert.AreEqual(borrowedItem1, _borrowList.GetBorrowedItem(0));
            Assert.AreEqual(borrowedItem2, _borrowList.GetBorrowedItem(1));
        }

        //RemoveTest
        [TestMethod()]
        public void RemoveTest()
        {
            _borrowList.AddToBorrowedList(borrowedItem1);
            _borrowList.AddToBorrowedList(borrowedItem2);
            Assert.AreEqual(2, _borrowList.COUNT);
            _borrowList.Remove(0);
            Assert.AreEqual(1, _borrowList.COUNT);
            Assert.AreEqual(borrowedItem2, _borrowList.GetBorrowedItem(0));
        }

        //ClearTest
        [TestMethod()]
        public void ClearTest()
        {
            _borrowList.AddToBorrowedList(borrowedItem1);
            _borrowList.AddToBorrowedList(borrowedItem2);
            Assert.AreEqual(2, _borrowList.COUNT);
            _borrowList.Clear();
            Assert.AreEqual(0, _borrowList.COUNT);
        }
    }
}
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
    public class LibraryTests
    {
        Library _library;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw1_books_source.txt");
        }

        //LibraryTest
        [TestMethod()]
        public void LibraryTest()
        {
            Library _library2;
            _library2 = new Library("./hw1_books_source.txt");
            Assert.AreEqual(6, _library2.GetBookItems().Count());
            Assert.AreEqual(6, _library2.GetBookCategories().Count());
            Assert.AreEqual("6月暢銷書", _library2.GetCategoryList()[0]);
            Assert.AreEqual("4月暢銷書", _library2.GetCategoryList()[1]);
        }

        //ReadFileTest
        [TestMethod()]
        public void ReadFileTest()
        {
            _library = new Library("./hw1_books_source.txt");
            Assert.AreEqual(6, _library.GetBookItems().Count());
            Assert.AreEqual(6, _library.GetBookCategories().Count());
            Assert.AreEqual("6月暢銷書", _library.GetCategoryList()[0]);
            Assert.AreEqual("4月暢銷書", _library.GetCategoryList()[1]);
        }

        //GetButtonCountTest
        [TestMethod()]
        public void GetButtonCountTest()
        {
            Assert.AreEqual(3, _library.GetButtonCount("4月暢銷書"));
            Assert.AreEqual(3, _library.GetButtonCount("6月暢銷書"));
            _library.ReadFile("./hw2_books_source.txt");
            Assert.AreEqual(8, _library.GetButtonCount("4月暢銷書"));
            Assert.AreEqual(7, _library.GetButtonCount("6月暢銷書"));
        }

        //FindCurrentSelectedTest
        [TestMethod()]
        public void FindCurrentSelectedTest()
        {
            BookItem bookItem = _library.FindCurrentSelected(0, 1);
            Assert.AreEqual(_library.GetBookItems()[3].INDEX, bookItem.INDEX);
            bookItem = _library.FindCurrentSelected(1, 0);
            Assert.AreEqual(_library.GetBookItems()[1].INDEX, bookItem.INDEX);
        }

        //ReturnTest
        [TestMethod()]
        public void ReturnTest()
        {
            BookItem bookItem = _library.GetBookItems()[1];
            Assert.AreEqual(1, bookItem.REMAIN);
            _library.Return(bookItem.NUMBER, 2);
            Assert.AreEqual(3, bookItem.REMAIN);
        }

        //GetBookItemsTest
        [TestMethod()]
        public void GetBookItemsTest()
        {
            List<BookItem> bookItems = _library.GetBookItems();
            Assert.AreEqual(6, bookItems.Count());
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", bookItems[0].NAME);
        }

        //GetBorrowedListTest
        [TestMethod()]
        public void GetBorrowedListTest()
        {
            BorrowList borrowList = new BorrowList();
            BorrowedItem borrowedItem1 = new BorrowedItem();
            BorrowedItem borrowedItem2 = new BorrowedItem();
            borrowedItem1.BOOK = _library.GetBookItems()[0].BOOK;
            borrowedItem1.QUANTITY = 2;
            borrowedItem2.BOOK = _library.GetBookItems()[1].BOOK;
            borrowedItem2.QUANTITY = 1;
            borrowList.AddToBorrowedList(borrowedItem1);
            borrowList.AddToBorrowedList(borrowedItem2);
            _library.SetBorrowedList(borrowList);
            BorrowList borrowedList = _library.GetBorrowedList();
            Assert.AreEqual(3, _library.GetBookItems()[0].REMAIN);
            Assert.AreEqual(0, _library.GetBookItems()[1].REMAIN);
            Assert.AreEqual(2, borrowedList.COUNT);
            Assert.AreEqual(3, borrowedList.BOOKS);
        }

        //GetBookCategoriesTest
        [TestMethod()]
        public void GetBookCategoriesTest()
        {
            List<BookCategory> bookCategories = _library.GetBookCategories();
            Assert.AreEqual(6, bookCategories.Count());
            Assert.AreEqual("6月暢銷書", bookCategories[0].CATEGORY);
            Assert.AreEqual("6月暢銷書", bookCategories[1].CATEGORY);
            Assert.AreEqual("6月暢銷書", bookCategories[2].CATEGORY);
            Assert.AreEqual("4月暢銷書", bookCategories[3].CATEGORY);
            Assert.AreEqual("4月暢銷書", bookCategories[4].CATEGORY);
            Assert.AreEqual("4月暢銷書", bookCategories[5].CATEGORY);
        }

        //GetCategoryListTest
        [TestMethod()]
        public void GetCategoryListTest()
        {
            List<string> categories = _library.GetCategoryList();
            Assert.AreEqual(2, categories.Count());
            Assert.AreEqual("6月暢銷書", categories[0]);
            Assert.AreEqual("4月暢銷書", categories[1]);
        }

        //GetCurrentCategoryTest
        [TestMethod()]
        public void GetCurrentCategoryTest()
        {
            Assert.AreEqual("6月暢銷書", _library.GetCurrentCategory(0));
            Assert.AreEqual("4月暢銷書", _library.GetCurrentCategory(1));
        }

        //SetBorrowedListTest
        [TestMethod()]
        public void SetBorrowedListTest()
        {
            BorrowList borrowList = new BorrowList();
            BorrowedItem borrowedItem1 = new BorrowedItem();
            BorrowedItem borrowedItem2 = new BorrowedItem();
            borrowedItem1.BOOK = _library.GetBookItems()[0].BOOK;
            borrowedItem1.QUANTITY = 2;
            borrowedItem2.BOOK = _library.GetBookItems()[1].BOOK;
            borrowedItem2.QUANTITY = 1;
            borrowList.AddToBorrowedList(borrowedItem1);
            borrowList.AddToBorrowedList(borrowedItem2);
            _library.SetBorrowedList(borrowList);
            BorrowList borrowedList = _library.GetBorrowedList();
            Assert.AreEqual(3, _library.GetBookItems()[0].REMAIN);
            Assert.AreEqual(0, _library.GetBookItems()[1].REMAIN);
            Assert.AreEqual(2, borrowedList.COUNT);
            Assert.AreEqual(3, borrowedList.BOOKS);
        }
    }
}
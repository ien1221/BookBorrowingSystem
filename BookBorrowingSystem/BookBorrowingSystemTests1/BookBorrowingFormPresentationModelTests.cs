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
    public class BookBorrowingFormPresentationModelTests
    {
        Library _library;
        BookBorrowingFormPresentationModel _model;
        PrivateObject _modelPrivate;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw4_books_source.txt");
            _model = new BookBorrowingFormPresentationModel(_library);
            _modelPrivate = new PrivateObject(_model);
        }

        //BookBorrowingFormPresentationModelTest
        [TestMethod()]
        public void BookBorrowingFormPresentationModelTest()
        {
            Assert.IsNotNull(_modelPrivate.GetFieldOrProperty("_bookItems"));
            Assert.IsNotNull(_modelPrivate.GetFieldOrProperty("_bookCategories"));
            Assert.IsNotNull(_modelPrivate.GetFieldOrProperty("_categories"));
        }

        //RefreshInformationTest
        [TestMethod()]
        public void RefreshInformationTest()
        {
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            BorrowedItem borrowedItem = new BorrowedItem();
            borrowedItem.BOOK = _library.GetBookItems()[4].BOOK;
            _model.RefreshInformation(2, borrowedItem.BOOK.NAME);
            Assert.AreEqual(2, _model.GetBorrowList().GetBorrowedItem(0).QUANTITY);
            Assert.IsFalse(_model.RefreshInformation(6, borrowedItem.BOOK.NAME));
        }

        //ClickNextPageTest
        [TestMethod()]
        public void ClickNextPageTest()
        {
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(2, _modelPrivate.GetFieldOrProperty("_currentPage"));
        }

        //ClickPreviousPageTest
        [TestMethod()]
        public void ClickPreviousPageTest()
        {
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(2, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickPreviousPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickPreviousPage();
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage")); 
        }

        //ResetPageTest
        [TestMethod()]
        public void ResetPageTest()
        {
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(2, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickPreviousPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ResetPage();
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
        }

        //ResetPageTest1
        [TestMethod()]
        public void ResetPageTest1()
        {
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickNextPage();
            Assert.AreEqual(2, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ClickPreviousPage();
            Assert.AreEqual(1, _modelPrivate.GetFieldOrProperty("_currentPage"));
            _model.ResetPage("6月暢銷書");
            Assert.AreEqual(0, _modelPrivate.GetFieldOrProperty("_currentPage"));
        }

        //GetCurrentPageTest
        [TestMethod()]
        public void GetCurrentPageTest()
        {
            Assert.AreEqual(0, _model.GetCurrentPage());
            _model.ClickNextPage();
            Assert.AreEqual(1, _model.GetCurrentPage());
            _model.ClickNextPage();
            Assert.AreEqual(2, _model.GetCurrentPage());
            _model.ClickPreviousPage();
            Assert.AreEqual(1, _model.GetCurrentPage());
            _model.ResetPage();
            Assert.AreEqual(0, _model.GetCurrentPage());
        }

        //GetButtonIndexTest
        [TestMethod()]
        public void GetButtonIndexTest()
        {
            Assert.AreEqual(0, _model.GetButtonIndex(0));
            Assert.AreEqual(1, _model.GetButtonIndex(1));
            _model.ClickNextPage();
            Assert.AreEqual(3, _model.GetButtonIndex(0));
            Assert.AreEqual(4, _model.GetButtonIndex(1));
        }

        //SetButtonQuantityTest
        [TestMethod()]
        public void SetButtonQuantityTest()
        {
            _model.SetButtonQuantity("6月暢銷書");
            Assert.AreEqual(4, _modelPrivate.GetFieldOrProperty("_buttonQuantity"));
            Assert.AreEqual(2, _modelPrivate.GetFieldOrProperty("_maxPage"));
        }

        //GetButtonCountTest
        [TestMethod()]
        public void GetButtonCountTest()
        {
            _model.SetButtonQuantity("4月暢銷書");
            Assert.AreEqual(3, _model.GetButtonCount("4月暢銷書"));
            _model.ClickNextPage();
            Assert.AreEqual(2, _model.GetButtonCount("4月暢銷書"));
        }

        //SetCurrentPageTest
        [TestMethod()]
        public void SetCurrentPageTest()
        {
            _model.SetButtonQuantity("6月暢銷書");
            Assert.AreEqual("當前頁數：1 / 2", _model.SetCurrentPage());
        }

        //SetSelectedTest
        [TestMethod()]
        public void SetSelectedTest()
        {
            _model.SetSelected(0, 1);
            BookItem bookItem = _library.GetBookItems()[4];
            Assert.AreEqual(bookItem, _modelPrivate.GetFieldOrProperty("_currentSelected"));
            _model.SetSelected(2, 1);
            bookItem = _library.GetBookItems()[6];
            Assert.AreEqual(bookItem, _modelPrivate.GetFieldOrProperty("_currentSelected"));
        }

        //IsPreviousEnableTest
        [TestMethod()]
        public void IsPreviousEnableTest()
        {
            Assert.IsFalse(_model.IsPreviousEnable());
            _model.ClickNextPage();
            Assert.IsTrue(_model.IsPreviousEnable());
        }

        //IsNextEnableTest
        [TestMethod()]
        public void IsNextEnableTest()
        {
            _model.SetButtonQuantity("6月暢銷書");
            Assert.IsTrue(_model.IsNextEnable());
            _model.ClickNextPage();
            Assert.IsFalse(_model.IsNextEnable());
        }

        //GetButtonImageTest
        [TestMethod()]
        public void GetButtonImageTest()
        {
            string path = _model.GetButtonImage(1, 2);
            Assert.AreEqual("../../../image/11.jpg", path);
        }

        //AddBorrowListTest
        [TestMethod()]
        public void AddBorrowListTest()
        {
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.SetSelected(1, 1);
            _model.AddBorrowList();
            Assert.AreEqual("借書數量：2", _model.GetBorrowingCount());
            BookItem bookItem = _library.GetBookItems()[4];
            BookItem bookItem1 = _library.GetBookItems()[5];
            Assert.AreEqual(bookItem.BOOK, _model.GetBorrowList().GetBorrowedItem(0).BOOK);
            Assert.AreEqual(bookItem1.BOOK, _model.GetBorrowList().GetBorrowedItem(1).BOOK);
        }

        //RemoveBorrowTest
        [TestMethod()]
        public void RemoveBorrowTest()
        {
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.RefreshInformation(3, _model.GetSelected().NAME);
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            Assert.AreEqual(4, _model.GetBorrowList().BOOKS);
            _model.RemoveBorrow(0);
            Assert.AreEqual(1, _model.GetBorrowList().BOOKS);
            _model.RemoveBorrow(0);
            Assert.AreEqual(0, _model.GetBorrowList().BOOKS);
        }

        //IsCheckBackPackEnableTest
        [TestMethod()]
        public void IsCheckBackPackEnableTest()
        {
            Assert.IsFalse(_model.IsCheckBackPackEnable());
        }

        //IsMoreThanFiveTest
        [TestMethod()]
        public void IsMoreThanFiveTest()
        {
            Assert.IsFalse(_model.IsMoreThanFive());
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            Assert.IsFalse(_model.IsMoreThanFive());
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            Assert.IsFalse(_model.IsMoreThanFive());
            _model.SetSelected(0, 2);
            _model.AddBorrowList();
            _model.RefreshInformation(1, _model.GetSelected().NAME);
            Assert.IsTrue(_model.IsMoreThanFive());
        }

        //CheckRemainTest
        [TestMethod()]
        public void CheckRemainTest()
        {
            Assert.AreEqual(1, _model.CheckRemain(2, "創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡"));
            Assert.AreEqual(2, _model.CheckRemain(3, "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書"));
            Assert.AreEqual(3, _model.CheckRemain(2, "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書"));
        }

        //GetBorrowingCountTest
        [TestMethod()]
        public void GetBorrowingCountTest()
        {
            Assert.AreEqual("借書數量：0", _model.GetBorrowingCount());
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            Assert.AreEqual("借書數量：2", _model.GetBorrowingCount());
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            Assert.AreEqual("借書數量：4", _model.GetBorrowingCount());
        }

        //IsAddToBorrowingListEnableTest
        [TestMethod()]
        public void IsAddToBorrowingListEnableTest()
        {
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.SetSelected(1, 0);
            Assert.IsTrue(_model.IsAddToBorrowingListEnable());
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.CheckBorrowingList();
            Assert.IsFalse(_model.IsAddToBorrowingListEnable());
            _model.SetSelected(1, 0);
            Assert.IsFalse(_model.IsAddToBorrowingListEnable());
        }

        //IsCheckBorrowingListEnableTest
        [TestMethod()]
        public void IsCheckBorrowingListEnableTest()
        {
            Assert.IsFalse(_model.IsCheckBorrowingListEnable());
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            Assert.IsTrue(_model.IsCheckBorrowingListEnable());
        }

        //GetTabPageNameTest
        [TestMethod()]
        public void GetTabPageNameTest()
        {
            Assert.AreEqual("6月暢銷書", _model.GetTabPageName("6月暢銷書"));
            Assert.AreEqual("4月暢銷書", _model.GetTabPageName("4月暢銷書"));
        }

        //GetTabIndexTest
        [TestMethod()]
        public void GetTabIndexTest()
        {
            Assert.AreEqual(2, _model.GetTabIndex(2));
            Assert.AreEqual(1, _model.GetTabIndex(1));
            Assert.AreEqual(3, _model.GetTabIndex(3));
        }

        //GetButtonNameTest
        [TestMethod()]
        public void GetButtonNameTest()
        {
            Assert.AreEqual("button3", _model.GetButtonName(2));
            Assert.AreEqual("button2", _model.GetButtonName(1));
        }

        //GetBorrowListTest
        [TestMethod()]
        public void GetBorrowListTest()
        {
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            Assert.AreEqual(1, _model.GetBorrowList().COUNT);
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            Assert.AreEqual(2, _model.GetBorrowList().COUNT);
            Assert.AreEqual(3, _model.GetBorrowList().BOOKS);
        }

        //GetSelectedTest
        [TestMethod()]
        public void GetSelectedTest()
        {
            _model.SetSelected(0, 0);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetSelected().NAME);
            Assert.AreEqual("964 8394:2-5 2021", _model.GetSelected().NUMBER);
        }

        //GetCurrentInformationTest
        [TestMethod()]
        public void GetCurrentInformationTest()
        {
            _model.SetSelected(0, 0);
            List<string> result = _model.GetCurrentInformation();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", result[0]);
            Assert.AreEqual("964 8394:2-5 2021", result[1]);
            Assert.AreEqual("ingectar-e", result[2]);
            Assert.AreEqual("原點出版 : 大雁發行, 2021[民110]", result[3]);
        }

        //ResetBorrowedTest
        [TestMethod()]
        public void ResetBorrowedTest()
        {
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.CheckBorrowingList();
            Assert.AreEqual(false, _modelPrivate.GetFieldOrProperty("_borrowed"));
            _model.SetSelected(1, 1);
            Assert.AreEqual(false, _modelPrivate.GetFieldOrProperty("_borrowed"));
            _model.ResetBorrowed(_model.SetSelected(0, 1));
            Assert.AreEqual(true, _modelPrivate.GetFieldOrProperty("_borrowed"));
        }

        //CheckBorrowingListTest
        [TestMethod()]
        public void CheckBorrowingListTest()
        {
            _model.SetSelected(0, 1);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            _model.SetSelected(1, 1);
            _model.AddBorrowList();
            Assert.AreEqual("【煤氣燈操縱 : 辨識人際中最暗黑的操控術, 走出精神控制與內疚, 重建自信與自尊】2本、【工作焦慮 : 這個世代的上班族七成心裡都有病, 解決壓力與倦怠的8個方法】1本\n\n已借出成功!", _model.CheckBorrowingList());
        }

        //EnableBackPackButtonTest
        [TestMethod()]
        public void EnableBackPackButtonTest()
        {
            Assert.IsTrue(_model.EnableBackPackButton());
        }

        //GetBorrowListInformationTest
        [TestMethod()]
        public void GetBorrowListInformationTest()
        {
            _model.SetSelected(0, 0);
            _model.AddBorrowList();
            _model.RefreshInformation(2, _model.GetSelected().NAME);
            List<string> result = _model.GetBorrowListInformation(0);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", result[0]);
            Assert.AreEqual("964 8394:2-5 2021", result[1]);
            Assert.AreEqual("ingectar-e", result[2]);
            Assert.AreEqual("原點出版 : 大雁發行, 2021[民110]", result[3]);
        }
    }
}
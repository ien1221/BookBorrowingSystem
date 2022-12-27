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
    public class BackPackFormPresentationModelTests
    {
        Library _library;
        BackPackFormPresentationModel _model;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw1_books_source.txt");
            Book book1 = new Book();
            book1.NAME = "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書";
            book1.NUMBER = "964 8394:2-5 2021";
            book1.WRITER = "ingectar-e";
            book1.PUBLICATION = "臺北市: 原點出版: 大雁發行, 2021[民110]";
            Book book2 = new Book();
            book2.NAME = "創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡";
            book2.NUMBER = "176.51 8564 2022";
            book2.WRITER = "羅瑞塔.葛蕾吉亞諾.布魯";
            book2.PUBLICATION = "臺北市 : 閱樂國際文化出版";
            BorrowedItem borrowedItem1 = new BorrowedItem();
            BorrowedItem borrowedItem2 = new BorrowedItem();
            borrowedItem1.BOOK = book1;
            borrowedItem1.QUANTITY = 5;
            borrowedItem2.BOOK = book2;
            borrowedItem2.QUANTITY = 6;
            BorrowList borrowList = new BorrowList();
            borrowList.AddToBorrowedList(borrowedItem1);
            borrowList.AddToBorrowedList(borrowedItem2);
            _library.SetBorrowedList(borrowList);
            _model = new BackPackFormPresentationModel(_library);
        }

        //BackPackFormPresentationModelTest
        [TestMethod()]
        public void BackPackFormPresentationModelTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBorrowListInformation(0)[0]);
        }

        //UpdateBorrowListTest
        [TestMethod()]
        public void UpdateBorrowListTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBorrowListInformation(0)[0]);
        }

        //GetBorrowListTest
        [TestMethod()]
        public void GetBorrowListTest()
        {
            _model.UpdateBorrowList();
            BorrowedItem borrowedItem = _model.GetBorrowList().GetBorrowedItem(0);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", borrowedItem.BOOK.NAME);
            Assert.AreEqual("964 8394:2-5 2021", borrowedItem.BOOK.NUMBER);
            Assert.AreEqual("ingectar-e", borrowedItem.BOOK.WRITER);
        }

        //GetBorrowListInformationTest
        [TestMethod()]
        public void GetBorrowListInformationTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBorrowListInformation(0)[0]);
            Assert.AreEqual("964 8394:2-5 2021", _model.GetBorrowListInformation(0)[4]);
            Assert.AreEqual("ingectar-e", _model.GetBorrowListInformation(0)[5]);
            Assert.AreEqual("臺北市: 原點出版: 大雁發行, 2021[民110]", _model.GetBorrowListInformation(0)[6]);
        }

        //RemoveBorrowTest
        [TestMethod()]
        public void RemoveBorrowTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("5", _model.GetBorrowListInformation(0)[1]);
            _model.RemoveBorrow(0, 4);
            Assert.AreEqual("1", _model.GetBorrowListInformation(0)[1]);
            _model.RemoveBorrow(0, 1);
            Assert.AreEqual("6", _model.GetBorrowListInformation(0)[1]);
        }

        //IsReturnLegalTest
        [TestMethod()]
        public void IsReturnLegalTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual(1, _model.IsReturnLegal(0, 7));
            Assert.AreEqual(2, _model.IsReturnLegal(0, 0));
            Assert.AreEqual(3, _model.IsReturnLegal(0, 4));
        }

        //ReturnSuccessTest
        [TestMethod()]
        public void ReturnSuccessTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("【微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書】 已成功歸還4本", _model.ReturnSuccess(0, 4));
        }

        //ResetBorrowCountTest
        [TestMethod()]
        public void ResetBorrowCountTest()
        {
            _model.UpdateBorrowList();
            Assert.AreEqual("5", _model.ResetBorrowCount(0));
            Assert.AreEqual("6", _model.ResetBorrowCount(1));
            _model.RemoveBorrow(0, 4);
            Assert.AreEqual("1", _model.ResetBorrowCount(0));
        }
    }
}
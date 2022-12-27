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
    public class BookAddFormPresentationModelTests
    {
        Library _library;
        BookAddFormPresentationModel _model;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw1_books_source.txt");
        }

        //BookAddFormPresentationModelTest
        [TestMethod()]
        public void BookAddFormPresentationModelTest()
        {
            _model = new BookAddFormPresentationModel(_library, 0);
            Assert.AreEqual("書籍名稱：微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n\n書籍類別：6月暢銷書\n庫存數量：5", _model.GetInformation());
            _model = new BookAddFormPresentationModel(_library, 1);
            Assert.AreEqual("書籍名稱：創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡\n\n書籍類別：6月暢銷書\n庫存數量：1", _model.GetInformation());
        }

        //GetInformationTest
        [TestMethod()]
        public void GetInformationTest()
        {
            _model = new BookAddFormPresentationModel(_library, 0);
            Assert.AreEqual("書籍名稱：微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n\n書籍類別：6月暢銷書\n庫存數量：5", _model.GetInformation());
            _model = new BookAddFormPresentationModel(_library, 1);
            Assert.AreEqual("書籍名稱：創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡\n\n書籍類別：6月暢銷書\n庫存數量：1", _model.GetInformation());
        }

        //AddRemainTest
        [TestMethod()]
        public void AddRemainTest()
        {
            _model = new BookAddFormPresentationModel(_library, 0);
            _model.AddRemain("6");
            Assert.AreEqual("書籍名稱：微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n\n書籍類別：6月暢銷書\n庫存數量：11", _model.GetInformation());
            _model.AddRemain("7");
            Assert.AreEqual("書籍名稱：微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n\n書籍類別：6月暢銷書\n庫存數量：18", _model.GetInformation());
            Assert.IsFalse(_model.AddRemain("-1"));

        }
    }
}
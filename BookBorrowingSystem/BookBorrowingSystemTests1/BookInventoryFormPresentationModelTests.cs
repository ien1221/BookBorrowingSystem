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
    public class BookInventoryFormPresentationModelTests
    {
        Library _library;
        BookInventoryFormPresentationModel _model;
        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw1_books_source.txt");
            _model = new BookInventoryFormPresentationModel(_library);
        }

        //BookInventoryFormPresentationModelTest
        [TestMethod()]
        public void BookInventoryFormPresentationModelTest()
        {
            _model.Initialize();
            Assert.AreEqual(6, _model.GetBookItemCount());
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n" +
                "編號：964 8394:2-5 2021\n作者：ingectar-e\n臺北市 : 原點出版 : 大雁發行, 2021[民110]", _model.GetInformation(0));
        }

        //InitializeTest
        [TestMethod()]
        public void InitializeTest()
        {
            _model.Initialize();
            Assert.AreEqual(6, _model.GetBookItemCount());
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n" +
                "編號：964 8394:2-5 2021\n作者：ingectar-e\n臺北市 : 原點出版 : 大雁發行, 2021[民110]", _model.GetInformation(0));
        }

        //GetGridViewInformationTest
        [TestMethod()]
        public void GetGridViewInformationTest()
        {
            _model.Initialize();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetGridViewInformation()[0][0]);
            Assert.AreEqual("6月暢銷書", _model.GetGridViewInformation()[0][1]);
            Assert.AreEqual("5", _model.GetGridViewInformation()[0][2]);
        }

        //GetPictureTest
        [TestMethod()]
        public void GetPictureTest()
        {
            _model.Initialize();
            Assert.AreEqual("../../../image/1.jpg", _model.GetPicture(0));
            Assert.AreEqual("../../../image/2.jpg", _model.GetPicture(1));
            Assert.AreEqual("../../../image/3.jpg", _model.GetPicture(2));
            Assert.AreEqual("../../../image/4.jpg", _model.GetPicture(3));
        }

        //GetInformationTest
        [TestMethod()]
        public void GetInformationTest()
        {
            _model.Initialize();
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n" +
                "編號：964 8394:2-5 2021\n作者：ingectar-e\n臺北市 : 原點出版 : 大雁發行, 2021[民110]", _model.GetInformation(0));
        }
    }
}
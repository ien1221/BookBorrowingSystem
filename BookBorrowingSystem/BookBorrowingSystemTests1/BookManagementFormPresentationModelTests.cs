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
    public class BookManagementFormPresentationModelTests
    {
        Library _library;
        BookManagementFormPresentationModel _model;
        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _library = new Library("./hw1_books_source.txt");
            _model = new BookManagementFormPresentationModel(_library);
        }

        //BookManagementFormPresentationModelTest
        [TestMethod()]
        public void BookManagementFormPresentationModelTest()
        {
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBookNameList()[0]);
            Assert.AreEqual("創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡", _model.GetBookNameList()[1]);
            Assert.AreEqual("暴力犯罪的大腦檔案 : 從神經犯罪學探究惡行的生物根源, 慎思以治療取代懲罰的未來防治計畫", _model.GetBookNameList()[2]);
            Assert.AreEqual("煤氣燈操縱 : 辨識人際中最暗黑的操控術, 走出精神控制與內疚, 重建自信與自尊", _model.GetBookNameList()[3]);
        }

        //GetBookNameListTest
        [TestMethod()]
        public void GetBookNameListTest()
        {
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBookNameList()[0]);
            Assert.AreEqual("創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡", _model.GetBookNameList()[1]);
            Assert.AreEqual("暴力犯罪的大腦檔案 : 從神經犯罪學探究惡行的生物根源, 慎思以治療取代懲罰的未來防治計畫", _model.GetBookNameList()[2]);
            Assert.AreEqual("煤氣燈操縱 : 辨識人際中最暗黑的操控術, 走出精神控制與內疚, 重建自信與自尊", _model.GetBookNameList()[3]);
        }

        //FineCurrentSelectedBookTest
        [TestMethod()]
        public void FineCurrentSelectedBookTest()
        {
            _model.FineCurrentSelectedBook(0);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetSelected().NAME);
            _model.FineCurrentSelectedBook(1);
            Assert.AreEqual("創造快樂大腦 : 重塑大腦快樂習慣-提升血清素, 多巴胺, 催產素, 腦內啡", _model.GetSelected().NAME);
        }

        //GetBookInformationTest
        [TestMethod()]
        public void GetBookInformationTest()
        {
            _model.FineCurrentSelectedBook(0);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _model.GetBookInformation()[0]);
        }

        //IsInformationChangedTest
        [TestMethod()]
        public void IsInformationChangedTest()
        {
            List<string> temp = new List<string>();
            temp.Add("0");
            temp.Add("1");
            temp.Add("2");
            temp.Add("3");
            temp.Add("4");
            temp.Add("5");
            Assert.AreEqual(true, _model.IsInformationChanged(temp));
        }

        //StoreInformationTest
        [TestMethod()]
        public void StoreInformationTest()
        {
            _model.FineCurrentSelectedBook(0);
            List<string> temp = new List<string>();
            temp.Add("0");
            temp.Add("1");
            temp.Add("2");
            temp.Add("3");
            temp.Add("4");
            temp.Add("5");
            _model.StoreInformation(temp);
            Assert.AreEqual("0", _model.GetSelected().NAME);
            Assert.AreEqual("1", _model.GetSelected().NUMBER);
            Assert.AreEqual("2", _model.GetSelected().WRITER);
            Assert.AreEqual("4", _model.GetSelected().PUBLICATION);
            Assert.AreEqual("../../../image/5.jpg", _model.GetSelected().COVER);
        }

        //SetCoverTextTest
        [TestMethod()]
        public void SetCoverTextTest()
        {
            string temp = "..\\..\\image\\1.jpg";
            Assert.AreEqual("1.jpg", _model.SetCoverText(temp));
        }

        //EnableTest
        [TestMethod()]
        public void EnableTest()
        {
            Assert.AreEqual(true, _model.Enable());
        }

        //DisableTest
        [TestMethod()]
        public void DisableTest()
        {
            Assert.AreEqual(false, _model.Disable());
        }
    }
}
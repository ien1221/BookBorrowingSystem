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
    public class BookTests
    {
        Book _book;
        string _inform;

        //initialize
        [TestInitialize()]
        public void Initialize()
        {
            _book = new Book();
            _book.NAME = "name";
            _book.NUMBER = "number";
            _book.PUBLICATION = "publication";
            _book.WRITER = "writer";
            _book.COVER = "cover";
            _inform = _book.NAME + "\n編號：" + _book.NUMBER + "\n作者：" + _book.WRITER + "\n" + _book.PUBLICATION;
        }

        //GetInformationTest
        [TestMethod()]
        public void GetInformationTest()
        {
            Assert.AreEqual(_inform, _book.GetInformation());
            Assert.AreEqual("../../../image/cover.jpg", _book.COVER);
        }
    }
}
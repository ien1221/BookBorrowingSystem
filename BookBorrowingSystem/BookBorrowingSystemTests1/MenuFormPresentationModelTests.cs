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
    public class MenuFormPresentationModelTests
    {
        MenuFormPresentationModel _model;

        //Initialize
        [TestInitialize()]
        public void Initialize()
        {
            _model = new MenuFormPresentationModel();
        }

        //MenuFormPresentationModelTest
        [TestMethod()]
        public void MenuFormPresentationModelTest()
        {
            Assert.AreEqual(true, _model.IsBorrowEnable());
            Assert.AreEqual(true, _model.IsInventoryEnable());
            Assert.AreEqual(true, _model.IsManageEnable());
        }

        //ChangeButtonStatusTest
        [TestMethod()]
        public void ChangeButtonStatusTest()
        {
            _model.ChangeButtonStatus(1);
            Assert.AreEqual(false, _model.IsBorrowEnable());
            _model.ChangeButtonStatus(1);
            Assert.AreEqual(true, _model.IsBorrowEnable());
            _model.ChangeButtonStatus(2);
            Assert.AreEqual(false, _model.IsInventoryEnable());
            _model.ChangeButtonStatus(2);
            Assert.AreEqual(true, _model.IsInventoryEnable());
            _model.ChangeButtonStatus(3);
            Assert.AreEqual(false, _model.IsManageEnable());
            _model.ChangeButtonStatus(3);
            Assert.AreEqual(true, _model.IsManageEnable());
        }

    }
}
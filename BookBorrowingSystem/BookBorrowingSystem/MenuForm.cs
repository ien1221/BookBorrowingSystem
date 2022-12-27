using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingSystem
{
    public partial class MenuForm : Form
    {
        private MenuFormPresentationModel _model;
        private Library _library;
        BookInventoryForm _bookInventoryForm;
        BookBorrowingForm _bookBorrowingForm;
        BookManagementForm _bookManagementForm;

        public MenuForm(Library library)
        {
            InitializeComponent();
            _library = library;
            _model = new MenuFormPresentationModel();
        }

        //click exit
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        //click book inventory system
        private void ClickBookInventorySystemButton(object sender, EventArgs e)
        {
            _bookInventoryForm = new BookInventoryForm(_library, this);
            _bookInventoryForm.Show();
            _bookInventorySystemButton.Enabled = _model.ChangeButtonStatus(Constant.TWO);
        }

        //click book borrowing system button
        private void ClickBookBorrowingSystemButton(object sender, EventArgs e)
        {
            _bookBorrowingForm = new BookBorrowingForm(_library, this);
            _bookBorrowingForm.Show();
            _bookBorrowingSystemButton.Enabled = _model.ChangeButtonStatus(1);
        }

        //更改按鈕狀態
        public void ChangeButtonStatus(int index)
        {
            switch (index)
            {
                case 1:
                    _bookBorrowingSystemButton .Enabled = _model.ChangeButtonStatus(index);
                    break;
                case 2:
                    _bookInventorySystemButton.Enabled = _model.ChangeButtonStatus(index);
                    break;
                case 3:
                    _bookManagementSystemButton.Enabled = _model.ChangeButtonStatus(index);
                    break;
            }
        }

        //click book management system button
        private void ClickBookManagementSystemButton(object sender, EventArgs e)
        {
            _bookManagementForm = new BookManagementForm(_library, this);
            _bookManagementForm.Show();
            _bookManagementSystemButton.Enabled = _model.ChangeButtonStatus(Constant.THREE);
        }

        //更新書本訊息
        public void ModifyInformation()
        {
            if (_bookBorrowingForm != null)
                _bookBorrowingForm.ModifyInformation();
            if (_bookInventoryForm != null)
                _bookInventoryForm.ModifyInformation();
        }

        //更新書本訊息
        public void ModifyRemain()
        {
            if (_bookBorrowingForm != null)
                _bookBorrowingForm.ModifyInformation();
        }
    }
}

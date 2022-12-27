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
    public partial class BookAddForm : Form
    {
        private Library _library;
        private BookAddFormPresentationModel _model;
        private BookInventoryForm _form;
        public BookAddForm(Library library, int index, BookInventoryForm form)
        {
            InitializeComponent();
            _library = library;
            _model = new BookAddFormPresentationModel(library, index);
            _form = form;
            SetInformation();
        }

        //設置資訊
        private void SetInformation()
        {
            _richTextBox.Text = _model.GetInformation();
        }

        //檢查補貨數量
        private void Confirm(object sender, EventArgs e)
        {
            if (!_model.AddRemain(_addTextBox.Text))
            {
                MessageBox.Show("補貨數量必須是非負整數!!!");
                _addTextBox.Text = "";
            }
            else
            {
                _form.RefreshGrid();
                _form.ModifyRemain();
                Close();
            }
        }

        //取消
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}

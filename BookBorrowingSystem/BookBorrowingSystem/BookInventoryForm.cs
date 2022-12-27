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
    public partial class BookInventoryForm : Form
    {
        private BookInventoryFormPresentationModel _model;
        private MenuForm _form;
        private BookAddForm _bookAddForm;
        private Library _library;

        public BookInventoryForm(Library library, MenuForm form)
        {
            InitializeComponent();
            _library = library;
            _form = form;
            _model = new BookInventoryFormPresentationModel(library);
            this.FormClosing += EnableMenuButton;
        }

        //初始化界面
        private void LoadBookInventoryForm(object sender, EventArgs e)
        {
            _model.Initialize();
            SetDataGridView();
            _dataGridView.CellPainting += SetAddButtonImage;
        }

        //初始化dataGridView
        private void SetDataGridView()
        {
            List<List<string>> information = _model.GetGridViewInformation();
            for (int i = 0; i < information.Count(); i++)
            {
                _dataGridView.Rows.Add(information[i][0], information[i][1], information[i][Constant.TWO]);
            }
        }

        //設置補貨單圖示
        private void SetAddButtonImage(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3)
            {
                Image image = Image.FromFile("../../../image/replenishment.png");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / Constant.TWO;
                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //設置右邊圖片與書籍資訊
        private void SetInformation(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            _pictureBox.Image = Image.FromFile(_model.GetPicture(e.RowIndex));
            _richTextBox.Text = _model.GetInformation(e.RowIndex);
        }

        //重置資訊
        public void RefreshGrid()
        {
            _dataGridView.Rows.Clear();
            SetDataGridView();
        }

        //打開補貨單
        private void ClickBookAddButton(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                _bookAddForm = new BookAddForm(_library, e.RowIndex, this);
                _bookAddForm.ShowDialog();
            }
        }

        //更改按鈕狀態
        private void EnableMenuButton(object sender, EventArgs e)
        {
            _form.ChangeButtonStatus(Constant.TWO);
        }

        //更新書本資訊
        public void ModifyInformation()
        {
            _model.Initialize();
            _dataGridView.Rows.Clear();
            SetDataGridView();
        }

        //更新書本資訊
        public void ModifyRemain()
        {
            _form.ModifyRemain();
        }
    }
}

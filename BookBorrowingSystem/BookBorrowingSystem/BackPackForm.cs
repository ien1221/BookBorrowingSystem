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
    public partial class BackPackForm : Form
    {
        private BookBorrowingForm _form;
        private BackPackFormPresentationModel _model;
        private Library _library;
        public BackPackForm(Library library, BookBorrowingForm form)
        {
            InitializeComponent();
            _library = library;
            _form = form;
            this.FormClosing += EnableBackPackButton;
            _model = new BackPackFormPresentationModel(library);
        }

        //設置datagridview
        private void SetDataGridView()
        {
            _model.UpdateBorrowList();
            for (int i = 0; i < _model.GetBorrowList().COUNT; i++)
            {
                List<string> information = GetBorrowListInformation(i);
                this._dataGridView.Rows.Add("", Constant.ONE.ToString(), information[0], information[Constant.ONE], information[Constant.TWO], information[Constant.THREE], information[Constant.FOUR], information[Constant.FIVE], information[Constant.SIX]);
            }
        }

        //取得資訊
        private List<string> GetBorrowListInformation(int index)
        {
            return _model.GetBorrowListInformation(index);
        }

        //歸還書籍
        private void ClickReturn(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (_model.IsReturnLegal(e.RowIndex, int.Parse(_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())))
                {
                    case 1:
                        MessageBox.Show("歸還數量不能超過已借數量");
                        break;
                    case 2:
                        MessageBox.Show("您至少要歸還一本書");
                        break;
                    case 3:
                        RemoveBorrow(e.RowIndex, int.Parse(_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
                        break;
                }
            }
        }

        //移除已歸還的書
        private void RemoveBorrow(int index, int returnQuantity)
        {
            MessageBox.Show(_model.ReturnSuccess(index, returnQuantity));
            if (_model.RemoveBorrow(index, returnQuantity))
                _dataGridView.Rows.RemoveAt(index);
            else
            {
                _dataGridView.Rows.Clear();
                SetDataGridView();
            }
        }

        //載入datagridview
        private void LoadBackPackForm(object sender, EventArgs e)
        {
            SetDataGridView();
        }

        //啟用按鈕
        private void EnableBackPackButton(object sender, EventArgs e)
        {
            _form.EnableButton();
        }

        //更新書本訊息
        public void ModifyInformation()
        {
            _dataGridView.Rows.Clear();
            SetDataGridView();
        }
    }
}

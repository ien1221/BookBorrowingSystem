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
    public partial class BookBorrowingForm : Form
    {
        private MenuForm _form;
        private BookBorrowingFormPresentationModel _model;
        private Library _library;
        BackPackForm _backPackForm;
        public BookBorrowingForm(Library library,MenuForm form)
        {
            InitializeComponent();
            _form = form;
            _library = library;
            _model = new BookBorrowingFormPresentationModel(_library);
            SetMenu(this._typeControl);
            _model.SetButtonQuantity(_typeControl.SelectedTab.Text);
            IsPageButtonEnable();
            SetCurrentPage();
            _borrowingList.CellPainting += SetDeleteButtonImage;
            this.FormClosing += EnableMenuButton;
            _typeControl.SelectedIndexChanged += ResetPage;
        }
            
        //重置頁面
        private void ResetPage(object sender, EventArgs e)
        {
            if (_typeControl.Controls.Count != 0)
            {
                _model.ResetPage(_typeControl.SelectedTab.Text);
                IsPageButtonEnable();
                ResetButton();
                SetCurrentPage();
            }
        }

        //更改按鈕狀態
        private void IsPageButtonEnable()
        {
            _previousPage.Enabled = _model.IsPreviousEnable();
            _nextPage.Enabled = _model.IsNextEnable();
        }

        //set menu
        private void SetMenu(TabControl tabControl)
        {
            List<string> list = _library.GetCategoryList();
            for (int i = 0; i < list.Count(); i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Location = new System.Drawing.Point(4, 28);
                tabPage.Name = _model.GetTabPageName(list[i]);
                tabPage.Padding = new System.Windows.Forms.Padding(Constant.THREE);
                tabPage.Size = new System.Drawing.Size(355, 154);
                tabPage.TabIndex = _model.GetTabIndex(i);
                tabPage.Text = tabPage.Name;
                tabPage.UseVisualStyleBackColor = true;
                SetButton(tabPage);
                tabControl.Controls.Add(tabPage);
            }
        }

        //重置按鈕
        private void ResetButton()
        {
            TabPage tabPage = _typeControl.SelectedTab;
            tabPage.Controls.Clear();
            SetButton(tabPage);
        }

        //set button in tab page
        private void SetButton(TabPage tabPage)
        {
            for (int i = 0; i < _model.GetButtonCount(tabPage.Text); i++)
            {
                Button button = new Button();
                button.Location = new System.Drawing.Point(Constant.SIX + i * 125, Constant.SIX);
                button.Name = _model.GetButtonName(i);
                button.Size = new System.Drawing.Size(120, 156);
                button.TabIndex = _model.GetButtonIndex(i);
                button.UseVisualStyleBackColor = true;
                button.Click += (e, a) => SetBookInformation(button.TabIndex, tabPage.TabIndex);
                button.Image = Image.FromFile(_model.GetButtonImage(button.TabIndex, tabPage.TabIndex));
                button.ImageAlign = ContentAlignment.MiddleRight;
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.FlatStyle = FlatStyle.Flat;
                tabPage.Controls.Add(button);
            }
        }

        //set book information
        private void SetBookInformation(int buttonIndex, int pageIndex)
        {
            BookItem selected = _model.SetSelected(buttonIndex, pageIndex);
            _bookInformation.Text = selected.INFORMATION;
            _remainCount.Text = "剩餘數量：" + selected.REMAIN;
            _model.ResetBorrowed(selected);
            _addToBorrowingList.Enabled = _model.IsAddToBorrowingListEnable();
        }

        //set function of addToBorrowingList
        private void AddToBorrowingListClick(object sender, EventArgs e)
        {
            if (!IsMoreThanFive())
            {
                if (_model.AddBorrowList())
                    _addToBorrowingList.Enabled = IsAddToBorrowingListEnable();
                else
                    SetBorrowingList();
            }
            _borrowingCount.Text = _model.GetBorrowingCount();
            _checkBorrowingList.Enabled = _model.IsCheckBorrowingListEnable();
        }

        //確認借書鈕可否使用
        private bool IsAddToBorrowingListEnable()
        {
            return _model.IsAddToBorrowingListEnable();
        }

        //設置datagridview
        private void SetBorrowingList()
        {
            List<string> information = _model.GetCurrentInformation();
            this._borrowingList.Rows.Add("", information[0], Constant.ONE.ToString(), information[Constant.ONE], information[Constant.TWO], information[Constant.THREE]);
        }

        //按下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            _model.ClickNextPage();
            IsPageButtonEnable();
            ResetButton();
            SetCurrentPage();
        }

        //按上一頁
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            _model.ClickPreviousPage();
            IsPageButtonEnable();
            ResetButton();
            SetCurrentPage();
        }
        
        //設置標籤
        private void SetCurrentPage()
        {
            _currentPage.Text = _model.SetCurrentPage();
        }

        //打開書包
        private void OpenBackPack(object sender, EventArgs e)
        {
            _backPackForm = new BackPackForm(_library, this);
            _backPackForm.Show();
            _checkBackPack .Enabled = _model.IsCheckBackPackEnable();
        }

        //設置垃圾筒圖示
        private void SetDeleteButtonImage(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                Image image = Image.FromFile("../../../image/trash_can.png");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / Constant.TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / Constant.TWO;
                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //按下確認借書
        private void ClickCheckBorrowingList(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in _borrowingList.Rows)
            //    _model.SetBorrowQuantity(int.Parse(row.Cells[Constant.TWO].Value.ToString()));
            string result = _model.CheckBorrowingList();
            MessageBox.Show(result);
            this._borrowingList.Rows.Clear();
            _borrowingCount.Text = _model.GetBorrowingCount();
            _checkBorrowingList.Enabled = _model.IsCheckBorrowingListEnable();
        }

        //刪除借書單
        private void ClickDelete(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                _borrowingList.Rows.RemoveAt(e.RowIndex);
                _model.RemoveBorrow(e.RowIndex);
                _borrowingCount.Text = _model.GetBorrowingCount();
            }
        }
        
        //檢查借書數量是否大於二
        private void ChangeQuantity(object sender, DataGridViewCellEventArgs e)
        {
            _borrowingList.EndEdit();
            if (!IsMoreThanFive())
                for (int i = 0; i < _borrowingList.Rows.Count; i++)
                    switch (_model.CheckRemain(int.Parse(_borrowingList.Rows[i].Cells[Constant.TWO].Value.ToString()), _borrowingList.Rows[i].Cells[Constant.ONE].Value.ToString()))
                    {
                        case 1:
                            _borrowingList.Rows[i].Cells[Constant.TWO].Value = (object)((int.Parse(_borrowingList.Rows[i].Cells[Constant.TWO].Value.ToString()) - 1).ToString());
                            MessageBox.Show(Constant.LACK);
                            break;
                        case Constant.TWO:
                            _borrowingList.Rows[i].Cells[Constant.TWO].Value = (object)(Constant.TWO.ToString());
                            MessageBox.Show("最多只能借兩本");
                            break;
                        case Constant.THREE:
                            RefreshInformation(int.Parse(_borrowingList.Rows[i].Cells[Constant.TWO].Value.ToString()), _borrowingList.Rows[i].Cells[Constant.ONE].Value.ToString(), i);
                            break;
                    }
        }

        //重製借書數量
        private void RefreshInformation(int quantity, string bookName, int index)
        {
            if (!_model.RefreshInformation(quantity, bookName))
                _borrowingList.Rows[index].Cells[Constant.TWO].Value = (object)(int.Parse(_borrowingList.Rows[index].Cells[Constant.TWO].Value.ToString()) - 1).ToString();
            _borrowingCount.Text = _model.GetBorrowingCount();
        }

        //改變按鈕狀態
        private void EnableMenuButton(object sender, EventArgs e)
        {
            _form.ChangeButtonStatus(Constant.ONE);
        }

        //更改按鈕狀態
        public void EnableButton()
        {
            _checkBackPack.Enabled = _model.EnableBackPackButton();
        }

        //借書數量是否大於5
        private bool IsMoreThanFive()
        {
            if (_model.IsMoreThanFive())
            {
                MessageBox.Show("每次借書限借五本，您的借書單已滿");
                return true;
            }
            return false;
        }

        //更新書本資訊
        public void ModifyInformation()
        {
            if (_backPackForm != null)
                _backPackForm.ModifyInformation();
            _typeControl.Controls.Clear();
            SetMenu(this._typeControl);
            _model.SetButtonQuantity(_typeControl.SelectedTab.Text);
            _model.ResetPage();
            IsPageButtonEnable();
            SetCurrentPage();
            _bookInformation.Text = "";
            _remainCount.Text = "";
            ResetBorrowList();
        }

        //重置借書單
        private void ResetBorrowList()
        {
            _borrowingList.Rows.Clear();
            for (int i = 0; i < _model.GetBorrowList().COUNT; i++)
            {
                List<String> information = _model.GetBorrowListInformation(i);
                this._borrowingList.Rows.Add("", information[0], Constant.ONE.ToString(), information[Constant.ONE], information[Constant.TWO], information[Constant.THREE]);
            }
        }
    }
}

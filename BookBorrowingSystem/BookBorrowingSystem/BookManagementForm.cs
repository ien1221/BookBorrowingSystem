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
    public partial class BookManagementForm : Form
    {
        Library _library;
        MenuForm _form;
        BookManagementFormPresentationModel _model;
        List<string> _categoryList;

        public BookManagementForm(Library library, MenuForm form)
        {
            InitializeComponent();
            _library = library;
            _form = form;
            _model = new BookManagementFormPresentationModel(_library);
            _categoryList = _library.GetCategoryList();
            this.FormClosing += EnableMenuButton;
            InitializeForm();
        }

        //初始化
        private void InitializeForm()
        {
            foreach (string name in _model.GetBookNameList())
                _listBox.Items.Add(name);
            foreach (string category in _categoryList)
                _categoryComboBox.Items.Add(category);
        }

        //改變按鈕狀態
        private void EnableMenuButton(object sender, EventArgs e)
        {
            _form.ChangeButtonStatus(Constant.THREE);
        }

        //更新右方書本資訊
        private void ChangedListBoxSelectedIndex(object sender, EventArgs e)
        {
            EnableTextBox();
            _model.FineCurrentSelectedBook(_listBox.SelectedIndex);
            List<string> bookInformation = _model.GetBookInformation();
            _nameTextBox.Text = bookInformation[0];
            _numberTextBox.Text = bookInformation[1];
            _writerTextBox.Text = bookInformation[Constant.TWO];
            _categoryComboBox.Text = bookInformation[Constant.THREE];
            _publicationTextBox.Text = bookInformation[Constant.FOUR];
            _coverTextBox.Text = bookInformation[Constant.FIVE];
        }
        
        //enable
        private void EnableTextBox()
        {
            _nameTextBox.Enabled = _model.Enable();
            _numberTextBox.Enabled = _model.Enable();
            _writerTextBox.Enabled = _model.Enable();
            _categoryComboBox.Enabled = _model.Enable();
            _publicationTextBox.Enabled = _model.Enable();
            _coverTextBox.Enabled = _model.Enable();
            _openFileButton.Enabled = _model.Enable();
        }

        //書本資訊是否變更
        private void ChangeInformation(object sender, EventArgs e)
        {
            _nameTextBox.Update();
            _numberTextBox.Update();
            _writerTextBox.Update();
            _categoryComboBox.Update();
            _publicationTextBox.Update();
            _coverTextBox.Update();
            if (_model.IsInformationChanged(GetInformation()))
                _storeButton.Enabled = _model.Enable();
        }

        //儲存變更訊息
        private void StoreInformation(object sender, EventArgs e)
        {
            _model.StoreInformation(GetInformation());
            _listBox.Items.Clear();
            _categoryComboBox.Items.Clear();
            InitializeForm();
            _storeButton.Enabled = _model.Disable();
            _form.ModifyInformation();
        }

        //取得書本資訊
        private List<string> GetInformation()
        {
            List<string> information = new List<string>(); 
            information.Add(_nameTextBox.Text);
            information.Add(_numberTextBox.Text);
            information.Add(_writerTextBox.Text);
            information.Add(_categoryComboBox.Text);
            information.Add(_publicationTextBox.Text);
            information.Add(_coverTextBox.Text);
            return information;
        }

        //開啟檔案
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _coverTextBox.Text = _model.SetCoverText(dialog.FileName);
            }
        }
    }
}

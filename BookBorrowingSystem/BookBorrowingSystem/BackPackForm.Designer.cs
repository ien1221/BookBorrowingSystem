
namespace BookBorrowingSystem
{
    partial class BackPackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._return = new System.Windows.Forms.DataGridViewButtonColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._borrowQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._return,
            this._quantity,
            this._name,
            this._borrowQuantity,
            this._borrowDate,
            this._deadline,
            this._number,
            this._writer,
            this._publication});
            this._dataGridView.Location = new System.Drawing.Point(13, 13);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.RowHeadersWidth = 51;
            this._dataGridView.RowTemplate.Height = 27;
            this._dataGridView.Size = new System.Drawing.Size(1225, 377);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickReturn);
            // 
            // _return
            // 
            this._return.HeaderText = "歸還";
            this._return.MinimumWidth = 6;
            this._return.Name = "_return";
            this._return.Text = "歸還";
            this._return.UseColumnTextForButtonValue = true;
            this._return.Width = 45;
            // 
            // _quantity
            // 
            this._quantity.HeaderText = "歸還數量";
            this._quantity.MinimumWidth = 6;
            this._quantity.Name = "_quantity";
            this._quantity.Width = 60;
            // 
            // _name
            // 
            this._name.HeaderText = "書籍名稱";
            this._name.MinimumWidth = 6;
            this._name.Name = "_name";
            this._name.Width = 150;
            // 
            // _borrowQuantity
            // 
            this._borrowQuantity.HeaderText = "已借數量";
            this._borrowQuantity.MinimumWidth = 6;
            this._borrowQuantity.Name = "_borrowQuantity";
            this._borrowQuantity.Width = 60;
            // 
            // _borrowDate
            // 
            this._borrowDate.HeaderText = "借書日期";
            this._borrowDate.MinimumWidth = 6;
            this._borrowDate.Name = "_borrowDate";
            this._borrowDate.Width = 125;
            // 
            // _deadline
            // 
            this._deadline.HeaderText = "還書期限";
            this._deadline.MinimumWidth = 6;
            this._deadline.Name = "_deadline";
            this._deadline.Width = 125;
            // 
            // _number
            // 
            this._number.HeaderText = "書籍編號";
            this._number.MinimumWidth = 6;
            this._number.Name = "_number";
            this._number.Width = 125;
            // 
            // _writer
            // 
            this._writer.HeaderText = "作者";
            this._writer.MinimumWidth = 6;
            this._writer.Name = "_writer";
            this._writer.Width = 125;
            // 
            // _publication
            // 
            this._publication.HeaderText = "出版項";
            this._publication.MinimumWidth = 6;
            this._publication.Name = "_publication";
            this._publication.Width = 125;
            // 
            // BackPackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this._dataGridView);
            this.Name = "BackPackForm";
            this.Text = "BackPackForm";
            this.Load += new System.EventHandler(this.LoadBackPackForm);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn _return;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _borrowQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn _number;
        private System.Windows.Forms.DataGridViewTextBoxColumn _writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publication;
    }
}

namespace BookBorrowingSystem
{
    partial class BookBorrowingForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._books = new System.Windows.Forms.GroupBox();
            this._currentPage = new System.Windows.Forms.Label();
            this._previousPage = new System.Windows.Forms.Button();
            this._nextPage = new System.Windows.Forms.Button();
            this._typeControl = new System.Windows.Forms.TabControl();
            this._addToBorrowingList = new System.Windows.Forms.Button();
            this._bookItemInformation = new System.Windows.Forms.GroupBox();
            this._remainCount = new System.Windows.Forms.Label();
            this._bookInformation = new System.Windows.Forms.RichTextBox();
            this._borrowingList = new System.Windows.Forms.DataGridView();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._bookNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._writerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publicationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._borrowingListName = new System.Windows.Forms.Label();
            this._borrowingCount = new System.Windows.Forms.Label();
            this._checkBorrowingList = new System.Windows.Forms.Button();
            this._checkBackPack = new System.Windows.Forms.Button();
            this._books.SuspendLayout();
            this._bookItemInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._borrowingList)).BeginInit();
            this.SuspendLayout();
            // 
            // _books
            // 
            this._books.Controls.Add(this._currentPage);
            this._books.Controls.Add(this._previousPage);
            this._books.Controls.Add(this._nextPage);
            this._books.Controls.Add(this._typeControl);
            this._books.Controls.Add(this._addToBorrowingList);
            this._books.Controls.Add(this._bookItemInformation);
            this._books.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._books.Location = new System.Drawing.Point(2, 5);
            this._books.Name = "_books";
            this._books.Size = new System.Drawing.Size(559, 540);
            this._books.TabIndex = 0;
            this._books.TabStop = false;
            this._books.Text = "書籍";
            // 
            // _currentPage
            // 
            this._currentPage.AutoSize = true;
            this._currentPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._currentPage.Location = new System.Drawing.Point(17, 501);
            this._currentPage.Name = "_currentPage";
            this._currentPage.Size = new System.Drawing.Size(111, 25);
            this._currentPage.TabIndex = 6;
            this._currentPage.Text = "Page：1/1";
            // 
            // _previousPage
            // 
            this._previousPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._previousPage.Location = new System.Drawing.Point(182, 498);
            this._previousPage.Name = "_previousPage";
            this._previousPage.Size = new System.Drawing.Size(93, 35);
            this._previousPage.TabIndex = 5;
            this._previousPage.Text = "上一頁";
            this._previousPage.UseVisualStyleBackColor = true;
            this._previousPage.Click += new System.EventHandler(this.ClickPreviousPage);
            // 
            // _nextPage
            // 
            this._nextPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nextPage.Location = new System.Drawing.Point(305, 498);
            this._nextPage.Name = "_nextPage";
            this._nextPage.Size = new System.Drawing.Size(93, 35);
            this._nextPage.TabIndex = 4;
            this._nextPage.Text = "下一頁";
            this._nextPage.UseVisualStyleBackColor = true;
            this._nextPage.Click += new System.EventHandler(this.ClickNextPage);
            // 
            // _typeControl
            // 
            this._typeControl.Location = new System.Drawing.Point(15, 26);
            this._typeControl.Name = "_typeControl";
            this._typeControl.SelectedIndex = 0;
            this._typeControl.Size = new System.Drawing.Size(526, 242);
            this._typeControl.TabIndex = 3;
            // 
            // _addToBorrowingList
            // 
            this._addToBorrowingList.Enabled = false;
            this._addToBorrowingList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addToBorrowingList.Location = new System.Drawing.Point(422, 497);
            this._addToBorrowingList.Name = "_addToBorrowingList";
            this._addToBorrowingList.Size = new System.Drawing.Size(131, 35);
            this._addToBorrowingList.TabIndex = 2;
            this._addToBorrowingList.Text = "加入借書單";
            this._addToBorrowingList.UseVisualStyleBackColor = true;
            this._addToBorrowingList.Click += new System.EventHandler(this.AddToBorrowingListClick);
            // 
            // _bookItemInformation
            // 
            this._bookItemInformation.Controls.Add(this._remainCount);
            this._bookItemInformation.Controls.Add(this._bookInformation);
            this._bookItemInformation.Location = new System.Drawing.Point(15, 274);
            this._bookItemInformation.Name = "_bookItemInformation";
            this._bookItemInformation.Size = new System.Drawing.Size(526, 217);
            this._bookItemInformation.TabIndex = 0;
            this._bookItemInformation.TabStop = false;
            this._bookItemInformation.Text = "書籍資訊";
            // 
            // _remainCount
            // 
            this._remainCount.AutoSize = true;
            this._remainCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._remainCount.Location = new System.Drawing.Point(2, 186);
            this._remainCount.Name = "_remainCount";
            this._remainCount.Size = new System.Drawing.Size(0, 25);
            this._remainCount.TabIndex = 1;
            // 
            // _bookInformation
            // 
            this._bookInformation.Location = new System.Drawing.Point(7, 27);
            this._bookInformation.Name = "_bookInformation";
            this._bookInformation.Size = new System.Drawing.Size(513, 156);
            this._bookInformation.TabIndex = 0;
            this._bookInformation.Text = "";
            // 
            // _borrowingList
            // 
            this._borrowingList.AllowUserToAddRows = false;
            this._borrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._borrowingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._nameColumn,
            this._quantity,
            this._bookNumberColumn,
            this._writerColumn,
            this._publicationColumn});
            this._borrowingList.Location = new System.Drawing.Point(578, 60);
            this._borrowingList.Name = "_borrowingList";
            this._borrowingList.RowHeadersVisible = false;
            this._borrowingList.RowHeadersWidth = 51;
            this._borrowingList.RowTemplate.Height = 27;
            this._borrowingList.Size = new System.Drawing.Size(824, 430);
            this._borrowingList.TabIndex = 1;
            this._borrowingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDelete);
            this._borrowingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeQuantity);

            // 
            // _deleteColumn
            // 
            this._deleteColumn.HeaderText = "刪除";
            this._deleteColumn.MinimumWidth = 6;
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.Width = 45;
            // 
            // _nameColumn
            // 
            this._nameColumn.HeaderText = "書籍名稱";
            this._nameColumn.MinimumWidth = 6;
            this._nameColumn.Name = "_nameColumn";
            this._nameColumn.Width = 155;
            // 
            // _quantity
            // 
            this._quantity.HeaderText = "數量";
            this._quantity.MinimumWidth = 6;
            this._quantity.Name = "_quantity";
            this._quantity.Width = 45;
            // 
            // _bookNumberColumn
            // 
            this._bookNumberColumn.HeaderText = "書籍編號";
            this._bookNumberColumn.MinimumWidth = 6;
            this._bookNumberColumn.Name = "_bookNumberColumn";
            this._bookNumberColumn.Width = 120;
            // 
            // _writerColumn
            // 
            this._writerColumn.HeaderText = "作者";
            this._writerColumn.MinimumWidth = 6;
            this._writerColumn.Name = "_writerColumn";
            this._writerColumn.Width = 120;
            // 
            // _publicationColumn
            // 
            this._publicationColumn.HeaderText = "出版項";
            this._publicationColumn.MinimumWidth = 6;
            this._publicationColumn.Name = "_publicationColumn";
            this._publicationColumn.Width = 130;
            // 
            // _borrowingListName
            // 
            this._borrowingListName.AutoSize = true;
            this._borrowingListName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._borrowingListName.Location = new System.Drawing.Point(931, 9);
            this._borrowingListName.Name = "_borrowingListName";
            this._borrowingListName.Size = new System.Drawing.Size(99, 36);
            this._borrowingListName.TabIndex = 2;
            this._borrowingListName.Text = "借書單";
            // 
            // _borrowingCount
            // 
            this._borrowingCount.AutoSize = true;
            this._borrowingCount.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._borrowingCount.Location = new System.Drawing.Point(574, 505);
            this._borrowingCount.Name = "_borrowingCount";
            this._borrowingCount.Size = new System.Drawing.Size(148, 31);
            this._borrowingCount.TabIndex = 3;
            this._borrowingCount.Text = "借書數量：0";
            // 
            // _checkBorrowingList
            // 
            this._checkBorrowingList.Enabled = false;
            this._checkBorrowingList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkBorrowingList.Location = new System.Drawing.Point(1278, 501);
            this._checkBorrowingList.Name = "_checkBorrowingList";
            this._checkBorrowingList.Size = new System.Drawing.Size(124, 35);
            this._checkBorrowingList.TabIndex = 4;
            this._checkBorrowingList.Text = "確認借書";
            this._checkBorrowingList.UseVisualStyleBackColor = true;
            this._checkBorrowingList.Click += new System.EventHandler(this.ClickCheckBorrowingList);
            // 
            // _checkBackPack
            // 
            this._checkBackPack.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkBackPack.Location = new System.Drawing.Point(1034, 503);
            this._checkBackPack.Name = "_checkBackPack";
            this._checkBackPack.Size = new System.Drawing.Size(156, 35);
            this._checkBackPack.TabIndex = 5;
            this._checkBackPack.Text = "查看我的書包";
            this._checkBackPack.UseVisualStyleBackColor = true;
            this._checkBackPack.Click += new System.EventHandler(this.OpenBackPack);
            // 
            // BookBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 549);
            this.Controls.Add(this._checkBackPack);
            this.Controls.Add(this._checkBorrowingList);
            this.Controls.Add(this._borrowingCount);
            this.Controls.Add(this._borrowingListName);
            this.Controls.Add(this._borrowingList);
            this.Controls.Add(this._books);
            this.Name = "BookBorrowingForm";
            this.Text = "借書";
            this._books.ResumeLayout(false);
            this._books.PerformLayout();
            this._bookItemInformation.ResumeLayout(false);
            this._bookItemInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._borrowingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _books;
        private System.Windows.Forms.Button _addToBorrowingList;
        private System.Windows.Forms.GroupBox _bookItemInformation;
        private System.Windows.Forms.Label _remainCount;
        private System.Windows.Forms.RichTextBox _bookInformation;
        private System.Windows.Forms.DataGridView _borrowingList;
        private System.Windows.Forms.Label _borrowingListName;
        private System.Windows.Forms.Label _borrowingCount;
        private System.Windows.Forms.Button _checkBorrowingList;
        private System.Windows.Forms.TabControl _typeControl;
        private System.Windows.Forms.Label _currentPage;
        private System.Windows.Forms.Button _previousPage;
        private System.Windows.Forms.Button _nextPage;
        private System.Windows.Forms.Button _checkBackPack;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameColumn;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bookNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _writerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publicationColumn;
    }
}


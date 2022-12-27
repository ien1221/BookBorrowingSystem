
namespace BookBorrowingSystem
{
    partial class BookManagementForm
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
            this._listBox = new System.Windows.Forms.ListBox();
            this._label = new System.Windows.Forms.Label();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._categoryComboBox = new System.Windows.Forms.ComboBox();
            this._openFileButton = new System.Windows.Forms.Button();
            this._coverLabel = new System.Windows.Forms.Label();
            this._publicationLabel = new System.Windows.Forms.Label();
            this._categoryLabel = new System.Windows.Forms.Label();
            this._publicationTextBox = new System.Windows.Forms.TextBox();
            this._coverTextBox = new System.Windows.Forms.TextBox();
            this._writerTextBox = new System.Windows.Forms.TextBox();
            this._numberTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._writerLabel = new System.Windows.Forms.Label();
            this._numberLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._addNewButton = new System.Windows.Forms.Button();
            this._storeButton = new System.Windows.Forms.Button();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _listBox
            // 
            this._listBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 19;
            this._listBox.Location = new System.Drawing.Point(13, 58);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(265, 346);
            this._listBox.TabIndex = 0;
            this._listBox.SelectedIndexChanged += new System.EventHandler(this.ChangedListBoxSelectedIndex);
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label.Location = new System.Drawing.Point(272, 5);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(262, 50);
            this._label.TabIndex = 1;
            this._label.Text = "館藏管理系統";
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._categoryComboBox);
            this._groupBox.Controls.Add(this._openFileButton);
            this._groupBox.Controls.Add(this._coverLabel);
            this._groupBox.Controls.Add(this._publicationLabel);
            this._groupBox.Controls.Add(this._categoryLabel);
            this._groupBox.Controls.Add(this._publicationTextBox);
            this._groupBox.Controls.Add(this._coverTextBox);
            this._groupBox.Controls.Add(this._writerTextBox);
            this._groupBox.Controls.Add(this._numberTextBox);
            this._groupBox.Controls.Add(this._nameTextBox);
            this._groupBox.Controls.Add(this._writerLabel);
            this._groupBox.Controls.Add(this._numberLabel);
            this._groupBox.Controls.Add(this._nameLabel);
            this._groupBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._groupBox.Location = new System.Drawing.Point(309, 58);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(479, 349);
            this._groupBox.TabIndex = 2;
            this._groupBox.TabStop = false;
            this._groupBox.Text = "編輯書籍";
            // 
            // _categoryComboBox
            // 
            this._categoryComboBox.Enabled = false;
            this._categoryComboBox.FormattingEnabled = true;
            this._categoryComboBox.Location = new System.Drawing.Point(99, 172);
            this._categoryComboBox.Name = "_categoryComboBox";
            this._categoryComboBox.Size = new System.Drawing.Size(187, 27);
            this._categoryComboBox.TabIndex = 13;
            // 
            // _openFileButton
            // 
            this._openFileButton.Enabled = false;
            this._openFileButton.Location = new System.Drawing.Point(398, 273);
            this._openFileButton.Name = "_openFileButton";
            this._openFileButton.Size = new System.Drawing.Size(75, 30);
            this._openFileButton.TabIndex = 12;
            this._openFileButton.Text = "瀏覽";
            this._openFileButton.UseVisualStyleBackColor = true;
            this._openFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // _coverLabel
            // 
            this._coverLabel.AutoSize = true;
            this._coverLabel.Location = new System.Drawing.Point(7, 277);
            this._coverLabel.Name = "_coverLabel";
            this._coverLabel.Size = new System.Drawing.Size(86, 19);
            this._coverLabel.TabIndex = 11;
            this._coverLabel.Text = "圖片路徑(*)";
            // 
            // _publicationLabel
            // 
            this._publicationLabel.AutoSize = true;
            this._publicationLabel.Location = new System.Drawing.Point(7, 227);
            this._publicationLabel.Name = "_publicationLabel";
            this._publicationLabel.Size = new System.Drawing.Size(71, 19);
            this._publicationLabel.TabIndex = 10;
            this._publicationLabel.Text = "出版項(*)";
            // 
            // _categoryLabel
            // 
            this._categoryLabel.AutoSize = true;
            this._categoryLabel.Location = new System.Drawing.Point(7, 177);
            this._categoryLabel.Name = "_categoryLabel";
            this._categoryLabel.Size = new System.Drawing.Size(86, 19);
            this._categoryLabel.TabIndex = 9;
            this._categoryLabel.Text = "書籍類別(*)";
            // 
            // _publicationTextBox
            // 
            this._publicationTextBox.Enabled = false;
            this._publicationTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._publicationTextBox.Location = new System.Drawing.Point(99, 225);
            this._publicationTextBox.Name = "_publicationTextBox";
            this._publicationTextBox.Size = new System.Drawing.Size(374, 27);
            this._publicationTextBox.TabIndex = 8;
            this._publicationTextBox.TextChanged += new System.EventHandler(this.ChangeInformation);
            // 
            // _coverTextBox
            // 
            this._coverTextBox.Enabled = false;
            this._coverTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._coverTextBox.Location = new System.Drawing.Point(99, 275);
            this._coverTextBox.Name = "_coverTextBox";
            this._coverTextBox.Size = new System.Drawing.Size(281, 27);
            this._coverTextBox.TabIndex = 7;
            this._coverTextBox.TextChanged += new System.EventHandler(this.ChangeInformation);
            // 
            // _writerTextBox
            // 
            this._writerTextBox.Enabled = false;
            this._writerTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._writerTextBox.Location = new System.Drawing.Point(99, 125);
            this._writerTextBox.Name = "_writerTextBox";
            this._writerTextBox.Size = new System.Drawing.Size(187, 27);
            this._writerTextBox.TabIndex = 5;
            this._writerTextBox.TextChanged += new System.EventHandler(this.ChangeInformation);
            // 
            // _numberTextBox
            // 
            this._numberTextBox.Enabled = false;
            this._numberTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._numberTextBox.Location = new System.Drawing.Point(99, 75);
            this._numberTextBox.Name = "_numberTextBox";
            this._numberTextBox.Size = new System.Drawing.Size(187, 27);
            this._numberTextBox.TabIndex = 4;
            this._numberTextBox.TextChanged += new System.EventHandler(this.ChangeInformation);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Enabled = false;
            this._nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nameTextBox.Location = new System.Drawing.Point(99, 25);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(374, 27);
            this._nameTextBox.TabIndex = 3;
            this._nameTextBox.TextChanged += new System.EventHandler(this.ChangeInformation);
            // 
            // _writerLabel
            // 
            this._writerLabel.AutoSize = true;
            this._writerLabel.Location = new System.Drawing.Point(7, 127);
            this._writerLabel.Name = "_writerLabel";
            this._writerLabel.Size = new System.Drawing.Size(86, 19);
            this._writerLabel.TabIndex = 2;
            this._writerLabel.Text = "書籍作者(*)";
            // 
            // _numberLabel
            // 
            this._numberLabel.AutoSize = true;
            this._numberLabel.Location = new System.Drawing.Point(7, 77);
            this._numberLabel.Name = "_numberLabel";
            this._numberLabel.Size = new System.Drawing.Size(86, 19);
            this._numberLabel.TabIndex = 1;
            this._numberLabel.Text = "書籍編號(*)";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nameLabel.Location = new System.Drawing.Point(7, 28);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(86, 19);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "書籍名稱(*)";
            // 
            // _addNewButton
            // 
            this._addNewButton.Enabled = false;
            this._addNewButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addNewButton.Location = new System.Drawing.Point(13, 410);
            this._addNewButton.Name = "_addNewButton";
            this._addNewButton.Size = new System.Drawing.Size(265, 36);
            this._addNewButton.TabIndex = 3;
            this._addNewButton.Text = "新增書籍";
            this._addNewButton.UseVisualStyleBackColor = true;
            // 
            // _storeButton
            // 
            this._storeButton.Enabled = false;
            this._storeButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._storeButton.Location = new System.Drawing.Point(523, 410);
            this._storeButton.Name = "_storeButton";
            this._storeButton.Size = new System.Drawing.Size(265, 36);
            this._storeButton.TabIndex = 4;
            this._storeButton.Text = "儲存";
            this._storeButton.UseVisualStyleBackColor = true;
            this._storeButton.Click += new System.EventHandler(this.StoreInformation);
            // 
            // BookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._storeButton);
            this.Controls.Add(this._addNewButton);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._label);
            this.Controls.Add(this._listBox);
            this.Name = "BookManagementForm";
            this.Text = "BookManagementForm";
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.Label _coverLabel;
        private System.Windows.Forms.Label _publicationLabel;
        private System.Windows.Forms.Label _categoryLabel;
        private System.Windows.Forms.TextBox _publicationTextBox;
        private System.Windows.Forms.TextBox _coverTextBox;
        private System.Windows.Forms.TextBox _writerTextBox;
        private System.Windows.Forms.TextBox _numberTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _writerLabel;
        private System.Windows.Forms.Label _numberLabel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.ComboBox _categoryComboBox;
        private System.Windows.Forms.Button _openFileButton;
        private System.Windows.Forms.Button _addNewButton;
        private System.Windows.Forms.Button _storeButton;
    }
}
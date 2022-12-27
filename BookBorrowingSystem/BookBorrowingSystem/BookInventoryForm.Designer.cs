
namespace BookBorrowingSystem
{
    partial class BookInventoryForm
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
            this._label = new System.Windows.Forms.Label();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._add = new System.Windows.Forms.DataGridViewButtonColumn();
            this._pictureLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._informationLabel = new System.Windows.Forms.Label();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this._label.Location = new System.Drawing.Point(216, 9);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(342, 50);
            this._label.TabIndex = 0;
            this._label.Text = "書籍庫存管理系統";
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._type,
            this._quantity,
            this._add});
            this._dataGridView.Location = new System.Drawing.Point(13, 70);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.RowHeadersWidth = 51;
            this._dataGridView.RowTemplate.Height = 27;
            this._dataGridView.Size = new System.Drawing.Size(505, 482);
            this._dataGridView.TabIndex = 1;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetInformation);
            this._dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBookAddButton);
            // 
            // _name
            // 
            this._name.HeaderText = "書籍名稱";
            this._name.MinimumWidth = 6;
            this._name.Name = "_name";
            this._name.Width = 150;
            // 
            // _type
            // 
            this._type.HeaderText = "書籍類別";
            this._type.MinimumWidth = 6;
            this._type.Name = "_type";
            this._type.Width = 80;
            // 
            // _quantity
            // 
            this._quantity.HeaderText = "數量";
            this._quantity.MinimumWidth = 6;
            this._quantity.Name = "_quantity";
            this._quantity.Width = 80;
            // 
            // _add
            // 
            this._add.HeaderText = "補貨";
            this._add.MinimumWidth = 6;
            this._add.Name = "_add";
            this._add.Width = 45;
            // 
            // _pictureLabel
            // 
            this._pictureLabel.AutoSize = true;
            this._pictureLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._pictureLabel.Location = new System.Drawing.Point(525, 70);
            this._pictureLabel.Name = "_pictureLabel";
            this._pictureLabel.Size = new System.Drawing.Size(78, 22);
            this._pictureLabel.TabIndex = 2;
            this._pictureLabel.Text = "書籍圖片";
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(528, 102);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(260, 218);
            this._pictureBox.TabIndex = 3;
            this._pictureBox.TabStop = false;
            // 
            // _informationLabel
            // 
            this._informationLabel.AutoSize = true;
            this._informationLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._informationLabel.Location = new System.Drawing.Point(525, 323);
            this._informationLabel.Name = "_informationLabel";
            this._informationLabel.Size = new System.Drawing.Size(78, 22);
            this._informationLabel.TabIndex = 4;
            this._informationLabel.Text = "書籍名稱";
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(528, 348);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(260, 204);
            this._richTextBox.TabIndex = 5;
            this._richTextBox.Text = "";
            // 
            // BookInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._informationLabel);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._pictureLabel);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._label);
            this.Name = "BookInventoryForm";
            this.Text = "BookInventoryForm";
            this.Load += new System.EventHandler(this.LoadBookInventoryForm);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Label _pictureLabel;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _informationLabel;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantity;
        private System.Windows.Forms.DataGridViewButtonColumn _add;
    }
}
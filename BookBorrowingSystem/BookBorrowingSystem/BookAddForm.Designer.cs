
namespace BookBorrowingSystem
{
    partial class BookAddForm
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
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._addLabel = new System.Windows.Forms.Label();
            this._addTextBox = new System.Windows.Forms.TextBox();
            this._confirmButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label.Location = new System.Drawing.Point(163, 9);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(142, 50);
            this._label.TabIndex = 0;
            this._label.Text = "補貨單";
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(12, 70);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(431, 136);
            this._richTextBox.TabIndex = 1;
            this._richTextBox.Text = "";
            // 
            // _addLabel
            // 
            this._addLabel.AutoSize = true;
            this._addLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addLabel.Location = new System.Drawing.Point(7, 223);
            this._addLabel.Name = "_addLabel";
            this._addLabel.Size = new System.Drawing.Size(112, 25);
            this._addLabel.TabIndex = 2;
            this._addLabel.Text = "補貨數量：";
            // 
            // _addTextBox
            // 
            this._addTextBox.Location = new System.Drawing.Point(114, 223);
            this._addTextBox.Name = "_addTextBox";
            this._addTextBox.Size = new System.Drawing.Size(50, 25);
            this._addTextBox.TabIndex = 3;
            // 
            // _confirmButton
            // 
            this._confirmButton.BackColor = System.Drawing.Color.LimeGreen;
            this._confirmButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._confirmButton.Location = new System.Drawing.Point(12, 254);
            this._confirmButton.Name = "_confirmButton";
            this._confirmButton.Size = new System.Drawing.Size(202, 53);
            this._confirmButton.TabIndex = 4;
            this._confirmButton.Text = "確認";
            this._confirmButton.UseVisualStyleBackColor = false;
            this._confirmButton.Click += new System.EventHandler(this.Confirm);
            // 
            // _cancelButton
            // 
            this._cancelButton.BackColor = System.Drawing.Color.Red;
            this._cancelButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cancelButton.Location = new System.Drawing.Point(241, 254);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(202, 53);
            this._cancelButton.TabIndex = 5;
            this._cancelButton.Text = "取消";
            this._cancelButton.UseVisualStyleBackColor = false;
            this._cancelButton.Click += new System.EventHandler(this.Cancel);
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 314);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._confirmButton);
            this.Controls.Add(this._addTextBox);
            this.Controls.Add(this._addLabel);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._label);
            this.Name = "BookAddForm";
            this.Text = "BookAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.Label _addLabel;
        private System.Windows.Forms.TextBox _addTextBox;
        private System.Windows.Forms.Button _confirmButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}

namespace BookBorrowingSystem
{
    partial class MenuForm
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
            this._bookBorrowingSystemButton = new System.Windows.Forms.Button();
            this._bookInventorySystemButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._bookManagementSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _bookBorrowingSystemButton
            // 
            this._bookBorrowingSystemButton.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._bookBorrowingSystemButton.Location = new System.Drawing.Point(12, 12);
            this._bookBorrowingSystemButton.Name = "_bookBorrowingSystemButton";
            this._bookBorrowingSystemButton.Size = new System.Drawing.Size(780, 160);
            this._bookBorrowingSystemButton.TabIndex = 0;
            this._bookBorrowingSystemButton.Text = "Book Borrowing System";
            this._bookBorrowingSystemButton.UseVisualStyleBackColor = true;
            this._bookBorrowingSystemButton.Click += new System.EventHandler(this.ClickBookBorrowingSystemButton);
            // 
            // _bookInventorySystemButton
            // 
            this._bookInventorySystemButton.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._bookInventorySystemButton.Location = new System.Drawing.Point(12, 198);
            this._bookInventorySystemButton.Name = "_bookInventorySystemButton";
            this._bookInventorySystemButton.Size = new System.Drawing.Size(780, 160);
            this._bookInventorySystemButton.TabIndex = 1;
            this._bookInventorySystemButton.Text = "Book Inventory System";
            this._bookInventorySystemButton.UseVisualStyleBackColor = true;
            this._bookInventorySystemButton.Click += new System.EventHandler(this.ClickBookInventorySystemButton);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exitButton.Location = new System.Drawing.Point(652, 550);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(140, 60);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // _bookManagementSystemButton
            // 
            this._bookManagementSystemButton.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._bookManagementSystemButton.Location = new System.Drawing.Point(12, 384);
            this._bookManagementSystemButton.Name = "_bookManagementSystemButton";
            this._bookManagementSystemButton.Size = new System.Drawing.Size(780, 160);
            this._bookManagementSystemButton.TabIndex = 3;
            this._bookManagementSystemButton.Text = "Book Management System";
            this._bookManagementSystemButton.UseVisualStyleBackColor = true;
            this._bookManagementSystemButton.Click += new System.EventHandler(this.ClickBookManagementSystemButton);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this._bookManagementSystemButton);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._bookInventorySystemButton);
            this.Controls.Add(this._bookBorrowingSystemButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bookBorrowingSystemButton;
        private System.Windows.Forms.Button _bookInventorySystemButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _bookManagementSystemButton;
    }
}
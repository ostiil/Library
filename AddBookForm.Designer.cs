
namespace Library2022
{
    partial class AddBookForm
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
            this.NameBookText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.PublishingNumeric = new System.Windows.Forms.NumericUpDown();
            this.QueantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PublishingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBookText
            // 
            this.NameBookText.Location = new System.Drawing.Point(162, 41);
            this.NameBookText.Name = "NameBookText";
            this.NameBookText.Size = new System.Drawing.Size(189, 20);
            this.NameBookText.TabIndex = 0;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(162, 88);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(189, 20);
            this.AuthorText.TabIndex = 1;
            // 
            // PublishingNumeric
            // 
            this.PublishingNumeric.Location = new System.Drawing.Point(162, 141);
            this.PublishingNumeric.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.PublishingNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.PublishingNumeric.Name = "PublishingNumeric";
            this.PublishingNumeric.Size = new System.Drawing.Size(120, 20);
            this.PublishingNumeric.TabIndex = 3;
            this.PublishingNumeric.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // QueantityNumeric
            // 
            this.QueantityNumeric.Location = new System.Drawing.Point(162, 189);
            this.QueantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QueantityNumeric.Name = "QueantityNumeric";
            this.QueantityNumeric.Size = new System.Drawing.Size(120, 20);
            this.QueantityNumeric.TabIndex = 4;
            this.QueantityNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(34, 236);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(144, 23);
            this.AddBookBtn.TabIndex = 9;
            this.AddBookBtn.Text = "Добавить запись";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(204, 236);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(147, 56);
            this.ReturnBtn.TabIndex = 10;
            this.ReturnBtn.Text = "Вернуться к базе книг";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(34, 269);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(144, 23);
            this.EditBookButton.TabIndex = 11;
            this.EditBookButton.Text = "Редактировать запись";
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueantityNumeric);
            this.Controls.Add(this.PublishingNumeric);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.NameBookText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this.PublishingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReturnBtn;
        public System.Windows.Forms.Button EditBookButton;
        public System.Windows.Forms.Button AddBookBtn;
        public System.Windows.Forms.TextBox NameBookText;
        public System.Windows.Forms.TextBox AuthorText;
        public System.Windows.Forms.NumericUpDown PublishingNumeric;
        public System.Windows.Forms.NumericUpDown QueantityNumeric;
    }
}
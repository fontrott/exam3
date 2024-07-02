namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(49, 47);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(67, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(122, 47);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(67, 20);
            this.tbAuthor.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(195, 47);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(67, 20);
            this.tbYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год выпуска";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(556, 43);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(239, 186);
            this.lbBooks.TabIndex = 6;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(42, 94);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(80, 37);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Добавить";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(182, 94);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(80, 37);
            this.btnDeleteBook.TabIndex = 8;
            this.btnDeleteBook.Text = "Удалить";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сортировать название";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortByTitleButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сортировать автора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SortByAuthorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 68);
            this.button3.TabIndex = 11;
            this.button3.Text = "Сортировать год";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SortByYearButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 212);
            this.listBox1.TabIndex = 12;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(254, 247);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(91, 20);
            this.Name.TabIndex = 13;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(254, 302);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(91, 20);
            this.Autor.TabIndex = 14;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(254, 355);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(91, 20);
            this.Year.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Год выпуска";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Искать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(351, 240);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(74, 32);
            this.SearchName.TabIndex = 20;
            this.SearchName.Text = "Искать";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(351, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 32);
            this.button6.TabIndex = 21;
            this.button6.Text = "Искать";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(351, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 32);
            this.button7.TabIndex = 22;
            this.button7.Text = "Искать";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}


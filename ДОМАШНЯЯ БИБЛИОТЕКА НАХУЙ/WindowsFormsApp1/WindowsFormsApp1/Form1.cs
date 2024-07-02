using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            int year = int.Parse(tbYear.Text);

            // Создание нового объекта книги
            Book newBook = new Book(title, author, year);

            // Добавление книги в список
            books.Add(newBook);

            // Обновление списка книг
            UpdateBookList();

            // Очистка текстовых полей
            tbTitle.Clear();
            tbAuthor.Clear();
            tbYear.Clear();
        }

        private void UpdateBookList()
        {
            // Очистка списка книг
            lbBooks.Items.Clear();

            // Добавление книг в список
            foreach (Book book in books)
            {
                lbBooks.Items.Add($"{book.Title} ({book.Author}, {book.Year})");
            }
        }
        private void UpdateBookList2()
        {
            // Очистка списка книг
            listBox1.Items.Clear();

            // Добавление книг в список
            foreach (Book book in books)
            {
                listBox1.Items.Add($"{book.Title} ({book.Author}, {book.Year})");
            }
        }
        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получение выбранной книги
            if (lbBooks.SelectedIndex != -1)
            {
                Book selectedBook = books[lbBooks.SelectedIndex];

                // Заполнение текстовых полей
                tbTitle.Text = selectedBook.Title;
                tbAuthor.Text = selectedBook.Author;
                tbYear.Text = selectedBook.Year.ToString();
            }
        }
        private void SortByTitleButton_Click(object sender, EventArgs e)
        {
            // Сортируем книги по названию
            books.Sort((b1, b2) => string.Compare(b1.Title, b2.Title));
            UpdateBookList();
        }

        private void SortByAuthorButton_Click(object sender, EventArgs e)
        {
            // Сортируем книги по автору
            books.Sort((b1, b2) => string.Compare(b1.Author, b2.Author));
            UpdateBookList();
        }

        private void SortByYearButton_Click(object sender, EventArgs e)
        {
            // Сортируем книги по году выпуска
            books.Sort((b1, b2) => b1.Year.CompareTo(b2.Year));
            UpdateBookList();
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // Удаление выбранной книги
            if (lbBooks.SelectedIndex != -1)
            {
                books.RemoveAt(lbBooks.SelectedIndex);

                // Обновление списка книг
                UpdateBookList();
            }
            tbTitle.Clear();
            tbAuthor.Clear();
            tbYear.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name=Name.Text;
            string autor=Autor.Text;
            int year = int.Parse(Year.Text);
            foreach (var book in books) 
            {
                if ((book.Title == name) || (book.Author == autor) || (book.Year == year)) UpdateBookList2();

            }
            Name.Clear();
            Autor.Clear();
            Year.Clear();
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = Name.Text;
            foreach (var book in books)
            {
                if (book.Title == name) listBox1.Items.Add($"{book.Title} ({book.Author}, {book.Year})");

            }
            Name.Clear();
            Autor.Clear();
            Year.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

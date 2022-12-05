using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2022
{
    public partial class AddBookForm : Form
    {
        private books current_book = new books();
        public int currentIdBook;
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            current_book.name_book = NameBookText.Text;
            current_book.autor = AuthorText.Text;
            current_book.year_of_public = PublishingNumeric.Value.ToString();
            current_book.quantity = QueantityNumeric.Value;

            current_book.id_book = usersForm.BookdataGridView.Rows.Count + 1;
            libraryEntities1.GetContext().books.Add(current_book);
            try
            {
                libraryEntities1.GetContext().SaveChanges();
                MessageBox.Show("Книга добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            current_book.id_book = currentIdBook;

            try
            {
                var item = libraryEntities1.GetContext().books.Find(currentIdBook);
                item.name_book = NameBookText.Text;
                item.autor = AuthorText.Text;
                item.year_of_public = PublishingNumeric.Value.ToString();
                item.quantity = QueantityNumeric.Value;

                libraryEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация отредактирована");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

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
    public partial class UsersForm : Form
    {
        private history current_history = new history();
        private books current_book = new books();
        public int idRemove;

        public UsersForm()
        {
            InitializeComponent();
            ReadersdataGridView.DataSource = libraryEntities1.GetContext().readers.ToList();
            BookdataGridView.DataSource = libraryEntities1.GetContext().books.ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddFormReaders addForm = new AddFormReaders();
            addForm.Text = "Добавление записи";
            addForm.EditButton.Visible = false;
            addForm.AddButton.Visible = true;
            addForm.Show();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddFormReaders editFormReaders = new AddFormReaders();
            editFormReaders.Owner = this;
            editFormReaders.Text = "Редактирование записи";
            editFormReaders.EditButton.Visible = true;
            editFormReaders.AddButton.Visible = false;
            editFormReaders.current_id = Convert.ToInt32(ReadersdataGridView.CurrentRow.Cells[0].Value);
            editFormReaders.NametextBox.Text = ReadersdataGridView.CurrentRow.Cells[1].Value.ToString();
            editFormReaders.AgeTextbox.Text = ReadersdataGridView.CurrentRow.Cells[2].Value.ToString();
            editFormReaders.Show();
            
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet5.books". При необходимости она может быть перемещена или удалена.
            //this.booksTableAdapter1.Fill(this.libraryDataSet5.books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet4.readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter2.Fill(this.libraryDataSet4.readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet3.history". При необходимости она может быть перемещена или удалена.
            this.historyTableAdapter.Fill(this.libraryDataSet3.history);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet2.readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter1.Fill(this.libraryDataSet2.readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.libraryDataSet.readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet1.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet1.books);

        }

        private void AddToHistoryButton_Click(object sender, EventArgs e)
        {
            current_history.readers_id = Convert.ToDecimal(ReadercomboBox.SelectedValue);
            current_history.book_id = Convert.ToDecimal(BookcomboBox.SelectedValue);
            current_history.state = StatecomboBox.Text;
            current_history.id_history = HistorydataGridView.Rows.Count + 1;;
            libraryEntities1.GetContext().history.Add(current_history);
            try
            {
                libraryEntities1.GetContext().SaveChanges();
                MessageBox.Show("Запись добавлена");
                libraryEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                HistorydataGridView.DataSource = libraryEntities1.GetContext().history.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UsersForm_Activated(object sender, EventArgs e)
        {
            libraryEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            ReadersdataGridView.DataSource = libraryEntities1.GetContext().readers.ToList();
            BookdataGridView.DataSource = libraryEntities1.GetContext().books.ToList();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            addBook.Text = "Добавление записи";
            addBook.EditBookButton.Visible = false;
            addBook.AddBookBtn.Visible = true;
            addBook.Show();
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            var idbookRemove = BookdataGridView.SelectedCells[0].Value;
            current_history.book_id = Convert.ToDecimal(idbookRemove);
            //var item = libraryEntities1.GetContext().history.Find(current_history);
            //current_book.id_book = Convert.ToDecimal(idbookRemove);
            if (MessageBox.Show("Вы действительно хотите удалить эту книгу?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                libraryEntities1.GetContext().history.Attach(current_history);
                libraryEntities1.GetContext().history.Remove(current_history);
                libraryEntities1.GetContext().books.Remove(libraryEntities1.GetContext().books.Find(idbookRemove));
                libraryEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                libraryEntities1.GetContext().SaveChanges();

                
                HistorydataGridView.DataSource = libraryEntities1.GetContext().history.ToList();
                MessageBox.Show("Запись успешно удалена");
                BookdataGridView.DataSource = libraryEntities1.GetContext().books.ToList(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm editBookForm = new AddBookForm();
            editBookForm.Owner = this;
            editBookForm.Text = "Редактирование записи";
            editBookForm.EditBookButton.Visible= true;
            editBookForm.AddBookBtn.Visible= false;
            editBookForm.currentIdBook = Convert.ToInt32(BookdataGridView.CurrentRow.Cells[0].Value);
            editBookForm.NameBookText.Text = BookdataGridView.CurrentRow.Cells[1].Value.ToString();
            editBookForm.AuthorText.Text = BookdataGridView.CurrentRow.Cells[2].Value.ToString();
            editBookForm.PublishingNumeric.Value = Convert.ToDecimal(BookdataGridView.CurrentRow.Cells[3].Value);
            editBookForm.QueantityNumeric.Value = Convert.ToDecimal(BookdataGridView.CurrentRow.Cells[4].Value);
            editBookForm.Show();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<ReadersdataGridView.Rows.Count; i++)
            {
                ReadersdataGridView.Rows[i].Selected = false;
                for (int j = 0; j < ReadersdataGridView.Columns.Count; j++)
                {
                    if (ReadersdataGridView.Rows[i].Cells[1].Value.ToString().Contains(comboBox1.Text))
                    {
                        ReadersdataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void FindBookButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BookdataGridView.Rows.Count; i++)
            {
                BookdataGridView.Rows[i].Selected = false;
                for (int j = 0; j < BookdataGridView.Columns.Count; j++)
                {
                    if (BookdataGridView.Rows[i].Cells[1].Value.ToString().Contains(FindBookcomboBox.Text))
                    {
                        BookdataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }




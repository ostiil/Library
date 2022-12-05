using System;
using System.Data.Linq;
using System.Windows.Forms;

namespace Library2022
{
    public partial class AddFormReaders : Form
    {
        private readers currentreader = new readers();
        public int current_id ;
        public AddFormReaders()
        {
            InitializeComponent();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            currentreader.fio = NametextBox.Text ;
            currentreader.age = Convert.ToDecimal(AgeTextbox.Text);

            currentreader.id_readers = usersForm.ReadersdataGridView.Rows.Count + 1;
            libraryEntities1.GetContext().readers.Add(currentreader);
            try
            {
                libraryEntities1.GetContext().SaveChanges();
                MessageBox.Show("Читатель добавлен");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentreader.id_readers = current_id;
            try
            {
                var item = libraryEntities1.GetContext().readers.Find(current_id);
                item.fio = NametextBox.Text;
                item.age = Convert.ToDecimal(AgeTextbox.Text);

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

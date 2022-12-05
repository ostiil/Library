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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }   
            
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (libraryEntities1.GetContext().users.Any(x => x.login_user == LogintextBox.Text))
            {
                if (libraryEntities1.GetContext().users.Any(x => x.password_user == PassswordtextBox.Text))
                {
                    var users = new UsersForm();
                    users.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин");
            }
                
        }
    }
}

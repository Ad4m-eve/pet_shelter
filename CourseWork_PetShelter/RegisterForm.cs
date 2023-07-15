using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork_PetShelter
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void registerButon_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passField.Text;
            string nameUser = nameT.Text;
            string surnameUser = surnameT.Text;
            string positionUser = positionT.Text;
            string emailUser = "";

            if (emailT.Text.Contains("@"))
            {
                if (emailT.Text.Contains(".com"))
                {
                    emailUser = emailT.Text;
                }
            }
            else
            {
                MessageBox.Show("Неправильно вказано електронну пошту");
                emailT.Clear();
            }
            
            string phoneUser = phoneT.Text;

            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `worker` (`worker_surname`, `worker_name`, `position`, `phone`, `email`, `worker_login`, `worker_password`) " +
                "VALUES (@uS, @uN, @uPost, @uPhone, @uEmail, @uLogin, @uPass);", dB.getConnection());
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = nameUser;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = surnameUser;
            command.Parameters.Add("@uPost", MySqlDbType.VarChar).Value = positionUser;
            command.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phoneUser;
            command.Parameters.Add("@uEmail", MySqlDbType.VarChar).Value = emailUser;
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = passwordUser;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт було створено");
            }
            else
            {
                MessageBox.Show("Помилка. Акаунт не було створено");
            }
            dB.closeConnection();

            loginField.Clear();
            passField.Clear();
            nameT.Clear();
            surnameT.Clear();
            positionT.Clear();
            emailT.Clear();
            phoneT.Clear();
        }

        private void toMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
        }
    }
}

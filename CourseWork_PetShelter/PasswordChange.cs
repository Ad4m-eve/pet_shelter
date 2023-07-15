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

namespace CourseWork_PetShelter
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            string loginUser = login.Text;
            string oldPassword = oldPass.Text;
            string newPassword = newPass.Text;

            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `petshelter`.`worker` SET `worker_password` = @nPass " +
                "WHERE (`worker_login` = @uL) AND (`worker_password` = @oPass);", dB.getConnection());
            command.Parameters.Add("@nPass", MySqlDbType.VarChar).Value = newPassword;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@oPass", MySqlDbType.VarChar).Value = oldPassword;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль було змінено");
            }
            else
            {
                MessageBox.Show("Помилка. Пароль не було змінено");
            }
            dB.closeConnection();

            login.Clear();
            oldPass.Clear();
            newPass.Clear();
        }

        private void toMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }
}

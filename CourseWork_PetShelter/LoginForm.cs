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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void authorizeButon_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            DB dB = new DB();

            DataTable datatable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `worker_login` = @uL AND `worker_password` = @uP", dB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            if(datatable.Rows.Count > 0)
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль");
            }            
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange();
            this.Hide();
            passwordChange.ShowDialog();
        }
    }
}

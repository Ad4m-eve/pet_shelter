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
    public partial class Adoptation : Form
    {
        public Adoptation()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void toArchive_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `petshelter`.`adoption` (`animal_id`, `adopter_surname`, `adopter_name`, `adopter_email`, `adopter_phone`, `adoption_date`) VALUES (@aN, @adS, @adN, @adE, @adP, @adY);", dB.getConnection());
            command.Parameters.Add("@aN", MySqlDbType.Int32).Value = numberAn.Text;
            command.Parameters.Add("@adS", MySqlDbType.VarChar).Value = adopterSur.Text;
            command.Parameters.Add("@adN", MySqlDbType.VarChar).Value = adopterName.Text;
            command.Parameters.Add("@adE", MySqlDbType.VarChar).Value = adopterMail.Text;
            command.Parameters.Add("@adP", MySqlDbType.VarChar).Value = adopterPhone.Text;
            command.Parameters.Add("@adY", MySqlDbType.DateTime).Value = adoptionDate.Value;
            MySqlCommand command2 = new MySqlCommand("UPDATE `petshelter`.`animal` SET `archive` = 'архівовано' WHERE (`animal_id` = @aN);", dB.getConnection());
            command2.Parameters.Add("@aN", MySqlDbType.Int32).Value = numberAn.Text;
            dB.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Тварину архівовано");
                }
                else
                {
                    MessageBox.Show("Тварину не архівовано");
                }
            }
            catch
            {
                MessageBox.Show("Тварина вже архівована");
            }
            dB.closeConnection();
            numberAn.Clear();
            adopterSur.Clear();
            adopterName.Clear();
            adopterMail.Clear();
            adopterPhone.Clear();
            adoptionDate.Value = DateTime.Now;
        }

        private void onMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
        }
    }
}

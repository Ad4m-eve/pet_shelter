using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_PetShelter
{
    public partial class Animal : Form
    {
        public Animal()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void registerAnimal_Click(object sender, EventArgs e)
        {
            string nameAnimal = nameAn.Text;
            string speciesAnimal = speciesAn.Text;
            string breedAnimal = breedAn.Text;
            DateTime birthAnimal = Convert.ToDateTime(birthAn.Value);
            string sexAnimal = sexAn.SelectedItem.ToString();
            string colorAnimal = colorAn.Text;
            double weightAnimal = Convert.ToDouble(weightAn.Text);
            DateTime intakeAnimal = Convert.ToDateTime(intakeDateAn.Value);

            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `petshelter`.`animal` (`animal_name`, `species`, `breed`, `birth_date`, `animal_gender`, `color`, `weight`, `intake_date`) " +
                "VALUES (@uN, @uSp, @uBr, @uAg, @uSex, @uCol, @uW, @uIntakeDate);", dB.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nameAnimal;
            command.Parameters.Add("@uSp", MySqlDbType.VarChar).Value = speciesAnimal;
            command.Parameters.Add("@uBr", MySqlDbType.VarChar).Value = breedAnimal;
            command.Parameters.Add("@uAg", MySqlDbType.DateTime).Value = birthAnimal;
            command.Parameters.Add("@uSex", MySqlDbType.VarChar).Value = sexAnimal;
            command.Parameters.Add("@uCol", MySqlDbType.VarChar).Value = colorAnimal;
            command.Parameters.Add("@uW", MySqlDbType.Double).Value = weightAnimal;
            command.Parameters.Add("@uIntakeDate", MySqlDbType.DateTime).Value = intakeAnimal;

            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Тварину зареєстровано");
            }
            else
            {
                MessageBox.Show("Тварину не зареєстровано");
            }
            dB.closeConnection();

            nameAn.Clear();
            breedAn.Clear();
            colorAn.Clear();
            weightAn.Clear();
            birthAn.Value = DateTime.Now;
            intakeDateAn.Value = DateTime.Now;
        }

        private void onMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.ShowDialog();
        }

        private void addChanges_Click(object sender, EventArgs e)
        {
            int numberAnimal = Convert.ToInt32(numberAn.Text);
            DB dB = new DB();

            string medReason = reasonForMed.Text;
            DateTime startMed = Convert.ToDateTime(startDateAn.Value);
            DateTime endMed = Convert.ToDateTime(endDateAn.Value);
            MySqlCommand command3 = new MySqlCommand("INSERT INTO `petshelter`.`medical_conditions` (`animal_id`, `med_reason`, `start_date`, `end_date`) VALUES (@anNum, @mR, @mSD, @mED);", dB.getConnection());
            command3.Parameters.Add("@anNum", MySqlDbType.Int32).Value = numberAnimal;
            command3.Parameters.Add("@mR", MySqlDbType.VarChar).Value = medReason;
            command3.Parameters.Add("@mSD", MySqlDbType.DateTime).Value = startMed;
            command3.Parameters.Add("@mED", MySqlDbType.DateTime).Value = endMed;
            dB.openConnection();
            command3.ExecuteNonQuery();
            dB.closeConnection();
                        
            reasonForMed.Clear();
            startDateAn.Value = DateTime.Now;
            endDateAn.Value = DateTime.Now;
        }

        private void changeWeight_Click(object sender, EventArgs e)
        {
            int numberAnimal = Convert.ToInt32(numberAn.Text);
            double weightAnimal = Convert.ToDouble(changedWeight.Text);

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `petshelter`.`animal` SET `weight` = @anWe WHERE (`animal_id` = @anNum);", dB.getConnection());
            command.Parameters.Add("@anWe", MySqlDbType.Double).Value = weightAnimal;
            command.Parameters.Add("@anNum", MySqlDbType.Int32).Value = numberAnimal;
            dB.openConnection();
            command.ExecuteNonQuery();
            dB.closeConnection();

            changedWeight.Clear();
        }

        private void addVac_Click(object sender, EventArgs e)
        {
            int numberAnimal = Convert.ToInt32(numberAn.Text);
            DB dB = new DB();
            string vacForAnimal = Convert.ToString(vacForAn.Text);
            DateTime vacDateAnimal = Convert.ToDateTime(vacDateAn.Value);
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `petshelter`.`vaccination` (`animal_id`, `vac_for`, `vac_date`) VALUES (@anNum, @vacF, @vacD);", dB.getConnection());
            command2.Parameters.Add("@anNum", MySqlDbType.Int32).Value = numberAnimal;
            command2.Parameters.Add("@vacF", MySqlDbType.VarChar).Value = vacForAnimal;
            command2.Parameters.Add("@vacD", MySqlDbType.DateTime).Value = vacDateAnimal;
            dB.openConnection();
            command2.ExecuteNonQuery();
            dB.closeConnection();

            vacForAn.Clear();
            vacDateAn.Value = DateTime.Now;
        }
    }
}

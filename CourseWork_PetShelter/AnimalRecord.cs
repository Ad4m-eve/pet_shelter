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
    public partial class AnimalRecord : Form
    {
        public AnimalRecord()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }
        private void AnimalRecord_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT animal.animal_id, animal_name, species, breed, DATE_FORMAT(`birth_date` , '%d.%m.%Y'), animal_gender, color, weight, DATE_FORMAT(`intake_date`, '%d.%m.%Y'), DATE_FORMAT(`vac_date`, '%d.%m.%Y') FROM animal LEFT JOIN vaccination USING (`animal_id`);", dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> animals = new List<string[]>();
            while (reader.Read())
            {
                animals.Add(new string[11]);
                for (int i = 0; i < 10; i++)
                {
                    animals[animals.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();
            dB.closeConnection();

            foreach(string[] s in animals)
            {
                animInfoGridView.Rows.Add(s);
            }
        }

        private void animalEnter_Click(object sender, EventArgs e)
        {
            animInfoGridView.Rows.Clear();
            DateTime start = Convert.ToDateTime(dateStart.Value);
            DateTime end = Convert.ToDateTime(dateEnd.Value);

            DB dB = new DB();
            dB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT animal.animal_id, animal_name, species, breed, DATE_FORMAT(`birth_date` , '%d.%m.%Y'), animal_gender, color, weight, DATE_FORMAT(`intake_date`, '%d.%m.%Y') AS `take_date`, DATE_FORMAT(`vac_date`, '%d.%m.%Y') FROM animal LEFT JOIN vaccination USING (`animal_id`) WHERE `intake_date` BETWEEN @uStart AND @uEnd ORDER BY `take_date`;", dB.getConnection());
            command.Parameters.Add("@uStart", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@uEnd", MySqlDbType.DateTime).Value = end;
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> animals = new List<string[]>();
            while (reader.Read())
            {
                animals.Add(new string[9]);
                for (int i = 0; i < 9; i++)
                {
                    animals[animals.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();
            dB.closeConnection();

            foreach (string[] s in animals)
            {
                animInfoGridView.Rows.Add(s);
            }
        }

        /*private void animalExclude_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateStart.Value);
            DateTime end = Convert.ToDateTime(dateEnd.Value);

            DB dB = new DB();
            dB.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT animal.animal_id, animal_name, species, breed, DATE_FORMAT(`birth_date` , '%d.%m.%Y'), animal_gender, color, weight, DATE_FORMAT(`intake_date`, '%d.%m.%Y'), DATE_FORMAT(`adoption.adoption_date`, '%d.%m.%Y'), DATE_FORMAT(`vac_date`, '%d.%m.%Y') FROM animal, vaccination, adoption WHERE `adoption.adoption_date` BETWEEN start AND end order by animal_id;", dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> animals = new List<string[]>();
            while (reader.Read())
            {
                animals.Add(new string[11]);
                for (int i = 0; i < 11; i++)
                {
                    animals[animals.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();
            dB.closeConnection();

            foreach (string[] s in animals)
            {
                animInfoGridView.Rows.Add(s);
            }
        }*/

        private void toMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }
}

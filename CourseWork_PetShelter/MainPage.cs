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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ShowIcon = false;
            ShowInTaskbar = false;
        }

        private void toAnimals_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            this.Hide();
            animal.ShowDialog();
        }

        private void toFeedings_Click(object sender, EventArgs e)
        {
            Feeding feeding = new Feeding();
            this.Hide();
            feeding.ShowDialog();
        }

        private void toAnimalRecord_Click(object sender, EventArgs e)
        {
            AnimalRecord animal = new AnimalRecord();
            this.Hide();
            animal.ShowDialog();
        }

        private void toPasswordChange_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange();
            this.Hide();
            passwordChange.ShowDialog();
        }

        private void toAdoptation_Click(object sender, EventArgs e)
        {
            Adoptation adoptation = new Adoptation();
            this.Hide();
            adoptation.ShowDialog();
        }
    }
}

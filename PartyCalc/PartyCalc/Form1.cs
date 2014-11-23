using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyCalc
{
    public partial class Form1 : Form
    {

        public bool fancy = false;
        public bool healthy = true;
        public int numberOfPeople = 5;
        DinnerParty dinnerPartyStart = new DinnerParty();
        public Form1()
        {

            InitializeComponent();
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();

        }
        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {

            fancy = fancyBox.Checked;
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();
        }
        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            healthy = healthyBox.Checked;
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            decimal Cost = dinnerPartyStart.CalculateCost();
            costLabel.Text = Cost.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfPeople = (int)numericUpDown1.Value;
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fancy = fancyBox.Checked;
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            healthy = healthyBox.Checked;
            dinnerPartyStart = new DinnerParty(numberOfPeople, fancy, healthy);
            DisplayDinnerPartyCost();
        }

        private void tabBirthdayParty_Click(object sender, EventArgs e)
        {

        }

        private void tabDinnerParty_Click(object sender, EventArgs e)
        {

        }






    }
}

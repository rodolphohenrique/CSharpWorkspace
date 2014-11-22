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
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { numberOfPeople = 5 };
            dinnerParty.setHealthyOption(healthyBox.Checked);
            dinnerParty.CalculateCostOfDecoration(fancyBox.Checked);
            DisplayDinnerPartyCost();
            
        }
        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecoration(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.setHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost();
            costLabel.Text = Cost.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.numberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

     



 
    }
}

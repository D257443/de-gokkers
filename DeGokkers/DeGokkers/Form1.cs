using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnBet1_Click(object sender, EventArgs e)
        {
            int Bet1 = Decimal.ToInt32(inpMoney1.Value);
            int AnimalNumber1 = Decimal.ToInt32(inpAnNum1.Value);

            if (btnPlayer1.Checked)
            {
                lblPlayer1.Text = btnPlayer1.Text + " heeft " + Bet1 + " ingezet op nummer " + AnimalNumber1 + ".";
            }
        }

        private void btnBet2_Click(object sender, EventArgs e)
        {
            int Bet2 = Decimal.ToInt32(inpMoney2.Value);
            int AnimalNumber2 = Decimal.ToInt32(inpAnNum2.Value);

            if (btnPlayer2.Checked)
            {
                lblPlayer2.Text = btnPlayer2.Text + " heeft " + Bet2 + " ingezet op nummer " + AnimalNumber2 + ".";
            }
        }

        private void btnBet3_Click(object sender, EventArgs e)
        {
            int Bet3 = Decimal.ToInt32(inpMoney3.Value);
            int AnimalNumber3 = Decimal.ToInt32(inpAnNum3.Value);

            if (btnPlayer3.Checked)
            {
                lblPlayer3.Text = btnPlayer3.Text + " heeft " + Bet3 + " ingezet op nummer " + AnimalNumber3 + ".";
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (btnName1.Checked)
            {
                btnPlayer1.Text = txtInpName.Text;
            }
            else if (btnName2.Checked)
            {
                btnPlayer2.Text = txtInpName.Text;
            }
            else if (btnName3.Checked)
            {
                btnPlayer3.Text = txtInpName.Text;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrDog.Enabled = true;
           // tmrPanther.Enabled = true;
           // tmrHamster.Enabled = true;
           // tmrElephant.Enabled = true;
           // tmrPanda.Enabled = true;
        }

        private void tmrDog_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

            picDog1.Left += x;
            x = rnd.Next(0, 10);
            picDog2.Left += x;
            x = rnd.Next(0, 10);
            picDog3.Left += x;
            x = rnd.Next(0, 10);
            picDog4.Left += x;

        }

        private void tmrPanther_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

           //  picPanther1.Left += x;
           //  x = rnd.Next(0, 10);
           //  picPanther2.Left += x;
           //  x = rnd.Next(0, 10);
           //  picPanther3.Left += x;
           //  x = rnd.Next(0, 10);
           //  picPanther4.Left += x;
        } 
    }
}

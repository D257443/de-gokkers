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
        private int BalancePlayerOne = 50;
        private int BalancePlayerTwo = 50;
        private int BalancePlayerThree = 50;
        private bool HasBetOne;
        private bool HasBetTwo;
        private bool HasBetThree;
        private int Winner;
        private int Bet1;
        private int Bet2;
        private int Bet3;
        private int AnimalNumber1;
        private int AnimalNumber2;
        private int AnimalNumber3;


        public Form1()
        {

            InitializeComponent();
            lblMonOne.Text = "€" + BalancePlayerOne;
            lblMonTwo.Text = "€" + BalancePlayerTwo;
            lblMonThree.Text = "€" + BalancePlayerThree;
            button1.Visible = false;
            cbAnSel.Items.Add("Dog");
            cbAnSel.Items.Add("Elephant");
            cbAnSel.Items.Add("");
        }

        private void btnBet1_Click(object sender, EventArgs e)
        {
            Bet1 = Decimal.ToInt32(inpMoney1.Value);
            int AnimalNumber1 = Decimal.ToInt32(inpAnNum1.Value);

            if (btnPlayer1.Checked)
            {
                lblPlayer1.Text = btnPlayer1.Text + " heeft " + Bet1 + " ingezet op nummer " + AnimalNumber1 + ".";
                BalancePlayerOne -= Bet1;
                UpdateMoney();
                btnBet1.Visible = false;
                HasBetOne = true;
            }
        }

        private void btnBet2_Click(object sender, EventArgs e)
        {
            Bet2 = Decimal.ToInt32(inpMoney2.Value);
            int AnimalNumber2 = Decimal.ToInt32(inpAnNum2.Value);

            if (btnPlayer2.Checked)
            {
                lblPlayer2.Text = btnPlayer2.Text + " heeft " + Bet2 + " ingezet op nummer " + AnimalNumber2 + ".";
                BalancePlayerTwo -= Bet2;
                UpdateMoney();
                btnBet2.Visible = false;
                HasBetTwo = true;
            }
        }

        private void btnBet3_Click(object sender, EventArgs e)
        {
            Bet3 = Decimal.ToInt32(inpMoney3.Value);
            int AnimalNumber3 = Decimal.ToInt32(inpAnNum3.Value);

            if (btnPlayer3.Checked)
            {
                lblPlayer3.Text = btnPlayer3.Text + " heeft " + Bet3 + " ingezet op nummer " + AnimalNumber3 + ".";
                BalancePlayerThree -= Bet3;
                UpdateMoney();
                btnBet3.Visible = false;
                HasBetThree = true;
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
            if (HasBetOne == true && HasBetTwo == true && HasBetThree == true)
            {
                tmrDog.Enabled = true;
            }
            else
            {
                MessageBox.Show("Not everyone has bet");
            }
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

            if(picDog1.Location.X >= 500 || picDog2.Location.X >= 500 || picDog3.Location.X >= 500 || picDog4.Location.X >= 500)
            {
                tmrDog.Enabled = false;
                btnStart.Visible = false;
                button1.Visible = true;
            }
            if(picDog1.Location.X >= 499)
            {
                MessageBox.Show("Hond 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (picDog2.Location.X >= 499)
            {
                MessageBox.Show("Hond 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (picDog3.Location.X >= 499)
            {
                MessageBox.Show("Hond 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (picDog4.Location.X >= 499)
            {
                MessageBox.Show("Hond 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
            }
            
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

           // if (picPanther1.Location.X >= 500 || picPanther2.Location.X >= 500 || picPanther3.Location.X >= 500 || picPanther4.Location.X >= 500)
            {
           //     tmrPanther.Enabled = false;
            }
        }

        private void tmrHamster_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

            //  picHmaster1.Left += x;
            //  x = rnd.Next(0, 10);
            //  picHmaster2.Left += x;
            //  x = rnd.Next(0, 10);
            //  picHmaster3.Left += x;
            //  x = rnd.Next(0, 10);
            //  picHmaster4.Left += x;

           // if (picHamster1.Location.X >= 500 || picHamster2.Location.X >= 500 || picHamster3.Location.X >= 500 || picHamster4.Location.X >= 500)
            {
           //    tmrHamster.Enabled = false;
            }
        }

        private void tmrElephant_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

            //  picElephant1.Left += x;
            //  x = rnd.Next(0, 10);
            //  picElephant2.Left += x;
            //  x = rnd.Next(0, 10);
            //  picElephant3.Left += x;
            //  x = rnd.Next(0, 10);
            //  picElephant4.Left += x;

           // if (picElephant1.Location.X >= 500 || picElephant2.Location.X >= 500 || picElephant3.Location.X >= 500 || picElephant4.Location.X >= 500)
            {
           //     tmrElephant.Enabled = false;
            }
        }

        private void tmrPanda_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

            //  picPanda1.Left += x;
            //  x = rnd.Next(0, 10);
            //  picPanda2.Left += x;
            //  x = rnd.Next(0, 10);
            //  picPanda3.Left += x;
            //  x = rnd.Next(0, 10);
            // picPanda4.Left += x;

          //  if (picPanda1.Location.X >= 500 || picPanda2.Location.X >= 500 || picPanda3.Location.X >= 500 || picPanda4.Location.X >= 500)
            {
          //      tmrPanda.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrBack1.Enabled = true;
            tmrBack2.Enabled = true;
            tmrBack3.Enabled = true;
            tmrBack4.Enabled = true;             
        }

        private void tmrBack1_Tick(object sender, EventArgs e)
        {
            picDog1.Left -= 1;
            if (picDog1.Location.X == 12)
            {
                tmrBack1.Enabled = false;
                button1.Visible = false;
                btnStart.Visible = true;
            }
        }

        private void tmrBack2_Tick(object sender, EventArgs e)
        {
            picDog2.Left -= 1;
            if (picDog2.Location.X == 12)
            {
                tmrBack2.Enabled = false;
                button1.Visible = false;
                btnStart.Visible = true;
            }
        }

        private void tmrBack3_Tick(object sender, EventArgs e)
        {
            picDog3.Left -= 1;
            if (picDog3.Location.X == 12)
            {
                tmrBack3.Enabled = false;
                button1.Visible = false;
                btnStart.Visible = true;
            }
        }

        private void tmrBack4_Tick(object sender, EventArgs e)
        {
            picDog4.Left -= 1;
            if (picDog4.Location.X == 12)
            {
                tmrBack4.Enabled = false;
                button1.Visible = false;
                btnStart.Visible = true;
            }
        }
        private void UpdateMoney()
        {
            lblMonOne.Text = "€" + BalancePlayerOne;
            lblMonTwo.Text = "€" + BalancePlayerTwo;
            lblMonThree.Text = "€" + BalancePlayerThree;
        }
        private void ResetToStart()
        {
            lblMonOne.Text = "€" + BalancePlayerOne;
            lblMonTwo.Text = "€" + BalancePlayerTwo;
            lblMonThree.Text = "€" + BalancePlayerThree;
            btnBet1.Visible = true;
            btnBet2.Visible = true;
            btnBet3.Visible = true;
            HasBetOne = false;
            HasBetTwo = false;
            HasBetThree = false;
        }
        private void WinnerAssign()
        {
            if (Winner == AnimalNumber1)
            {
                BalancePlayerOne += Bet1 * 2;
            }
            if (Winner == AnimalNumber2)
            {
                BalancePlayerTwo += Bet2 * 2;
            }
            if (Winner == AnimalNumber3)
            {
                BalancePlayerThree += Bet3 * 2;
            }
            ResetToStart();
        }




    }
}

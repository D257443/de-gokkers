﻿using System;
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
        protected int Winner;
        private int Bet1;
        private int Bet2;
        private int Bet3;
        private int AnimalNumber1 = 0;
        private int AnimalNumber2 = 0;
        private int AnimalNumber3 = 0;
        protected string Animal;
        protected int selectedIndex;
        private bool HasChosen;






        public Form1()
        {

            
            InitializeComponent();
            lblMonOne.Text = "€" + BalancePlayerOne;
            lblMonTwo.Text = "€" + BalancePlayerTwo;
            lblMonThree.Text = "€" + BalancePlayerThree;
            btnBack.Visible = false;
            cbAnSel.Text = "Hond";


            MessageBox.Show("Dankjewel voor je deelnamen voor DeGokkers, we hebben je 50 euro gegeven om mee te starten, als je in de min staat gaat het ook van je eigen geld af...veel gok plezier!");
        }

        private void btnBet1_Click(object sender, EventArgs e)
        {
            Bet1 = Decimal.ToInt32(inpMoney1.Value);
            AnimalNumber1 = Decimal.ToInt32(inpAnNum1.Value);

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
            AnimalNumber2 = Decimal.ToInt32(inpAnNum2.Value);

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
            AnimalNumber3 = Decimal.ToInt32(inpAnNum3.Value);

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
            if(HasChosen == false)
            {
                MessageBox.Show("Je moet een dier kiezen!");
                return;
            }
            
            if (HasBetOne == true && HasBetTwo == true && HasBetThree == true && selectedIndex == 0)
            {
                tmrDog.Enabled = true;
            }
            else if (HasBetOne == true && HasBetTwo == true && HasBetThree == true && selectedIndex == 1)
            {
                tmrElephant.Enabled = true;
            }
            else if (HasBetOne == true && HasBetTwo == true && HasBetThree == true && selectedIndex == 2)
            {
                tmrHamster.Enabled = true;
            }
            else if (HasBetOne == true && HasBetTwo == true && HasBetThree == true && selectedIndex == 3)
            {
                tmrPanda.Enabled = true;
            }
            else if (HasBetOne == true && HasBetTwo == true && HasBetThree == true && selectedIndex == 4)
            {
                tmrPanther.Enabled = true;
            }
            else {
                MessageBox.Show("Nog niet iedereen heeft gewedt");
            }
            btnAnimalChooser.Visible = false;

        }


            private void tmrDog_Tick(object sender, EventArgs e)
            {
                Random rnd = new Random();
                int x = rnd.Next(0, 10);

                pic1.Left += x;
                x = rnd.Next(0, 10);
                pic2.Left += x;
                x = rnd.Next(0, 10);
                pic3.Left += x;
                x = rnd.Next(0, 10);
                pic4.Left += x;

                if (pic1.Location.X >= 500 || pic2.Location.X >= 500 || pic3.Location.X >= 500 || pic4.Location.X >= 500)
                {
                    tmrDog.Enabled = false;
                    btnStart.Visible = false;
                    btnBack.Visible = true;
                    
                }
                if (pic1.Location.X >= 500)
                {
                    MessageBox.Show("Hond 1 heeft gewonnen");
                    Winner = 1;
                    WinnerAssign();
                }
                else if (pic2.Location.X >= 500)
                {
                    MessageBox.Show("Hond 2 heeft gewonnen");
                    Winner = 2;
                    WinnerAssign();
                }
                else if (pic3.Location.X >= 500)
                {
                    MessageBox.Show("Hond 3 heeft gewonnen");
                    Winner = 3;
                    WinnerAssign();
                }
                else if (pic4.Location.X >= 500)
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


            pic1.Left += x;
            x = rnd.Next(0, 10);
            pic2.Left += x;
            x = rnd.Next(0, 10);
            pic3.Left += x;
            x = rnd.Next(0, 10);
            pic4.Left += x;

            if (pic1.Location.X >= 500 || pic2.Location.X >= 500 || pic3.Location.X >= 500 || pic4.Location.X >= 500)
            {
                tmrPanther.Enabled = false;
                btnStart.Visible = false;
                btnBack.Visible = true;
                
            }
            if (pic1.Location.X >= 500)
            {
                MessageBox.Show("Panther 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (pic2.Location.X >= 500)
            {
                MessageBox.Show("Panther 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (pic3.Location.X >= 500)
            {
                MessageBox.Show("Panther 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (pic4.Location.X >= 500)
            {
                MessageBox.Show("Panther 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
            }

        }

        private void tmrHamster_Tick(object sender, EventArgs e)
        { 

            Random rnd = new Random();
            int x = rnd.Next(0, 10);


            pic1.Left += x;
            x = rnd.Next(0, 10);
            pic2.Left += x;
            x = rnd.Next(0, 10);
            pic3.Left += x;
            x = rnd.Next(0, 10);
            pic4.Left += x;

            if (pic1.Location.X >= 500 || pic2.Location.X >= 500 || pic3.Location.X >= 500 || pic4.Location.X >= 500)
            {
                tmrHamster.Enabled = false;
                btnStart.Visible = false;
                btnBack.Visible = true;
                
            }
            if (pic1.Location.X >= 500)
            {
                MessageBox.Show("Hamster 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (pic2.Location.X >= 500)
            {
                MessageBox.Show("Hamster 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (pic3.Location.X >= 500)
            {
                MessageBox.Show("Hamster 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (pic4.Location.X >= 500)
            {
                MessageBox.Show("Hamster 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
            }

        }

        private void tmrElephant_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int x = rnd.Next(0, 10);


            pic1.Left += x;
            x = rnd.Next(0, 10);
            pic2.Left += x;
            x = rnd.Next(0, 10);
            pic3.Left += x;
            x = rnd.Next(0, 10);
            pic4.Left += x;

            if (pic1.Location.X >= 500 || pic2.Location.X >= 500 || pic3.Location.X >= 500 || pic4.Location.X >= 500)
            {
                tmrElephant.Enabled = false;
                btnStart.Visible = false;
                btnBack.Visible = true;
                
            }
            if (pic1.Location.X >= 500)
            {
                MessageBox.Show("Olifant 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (pic2.Location.X >= 500)
            {
                MessageBox.Show("Olifant 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (pic3.Location.X >= 500)
            {
                MessageBox.Show("Olifant 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (pic4.Location.X >= 500)
            {
                MessageBox.Show("Olifant 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
            }

        }

        private void tmrPanda_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int x = rnd.Next(0, 10);


            pic1.Left += x;
            x = rnd.Next(0, 10);
            pic2.Left += x;
            x = rnd.Next(0, 10);
            pic3.Left += x;
            x = rnd.Next(0, 10);
            pic4.Left += x;

            if (pic1.Location.X >= 500 || pic2.Location.X >= 500 || pic3.Location.X >= 500 || pic4.Location.X >= 500)
            {
                tmrPanda.Enabled = false;
                btnStart.Visible = false;
                btnBack.Visible = true;
                
            }
            if (pic1.Location.X >= 500)
            {
                MessageBox.Show("Panda 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (pic2.Location.X >= 500)
            {
                MessageBox.Show("Panda 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (pic3.Location.X >= 500)
            {
                MessageBox.Show("Panda 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (pic4.Location.X >= 500)
            {
                MessageBox.Show("Panda 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
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
            pic1.Left -= 1;
            if (pic1.Location.X == 12)
            {
                tmrBack1.Enabled = false;
                btnBack.Visible = false;
                btnStart.Visible = true;
                btnAnimalChooser.Visible = true;
            }
        }

        private void tmrBack2_Tick(object sender, EventArgs e)
        {
            pic2.Left -= 1;
            if (pic2.Location.X == 12)
            {
                tmrBack2.Enabled = false;
                btnBack.Visible = false;
                btnStart.Visible = true;
                btnAnimalChooser.Visible = true;
            }
        }

        private void tmrBack3_Tick(object sender, EventArgs e)
        {
            pic3.Left -= 1;
            if (pic3.Location.X == 12)
            {
                tmrBack3.Enabled = false;
                btnBack.Visible = false;
                btnStart.Visible = true;
                btnAnimalChooser.Visible = true;
            }
        }

        private void tmrBack4_Tick(object sender, EventArgs e)
        {
            pic4.Left -= 1;
            if (pic4.Location.X == 12)
            {
                tmrBack4.Enabled = false;
                btnBack.Visible = false;
                btnStart.Visible = true;
                btnAnimalChooser.Visible = true;
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
            btnAnimalChooser.Visible = true;
        }
        protected void WinnerAssign()
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

        private void btnAnimalChooser_Click(object sender, EventArgs e)
        {
            selectedIndex = cbAnSel.SelectedIndex;
            HasChosen = true;
            Object selectedItem = cbAnSel.SelectedItem;
            btnAnimalChooser.Visible = false;

            if(selectedIndex == 0)
            {
                pic1.Image = DeGokkers.Properties.Resources.dog1;
                pic2.Image = DeGokkers.Properties.Resources.dog1;
                pic3.Image = DeGokkers.Properties.Resources.dog1;
                pic4.Image = DeGokkers.Properties.Resources.dog1;
            }
            if(selectedIndex == 1)
            {
                pic1.Image = DeGokkers.Properties.Resources.elephant;
                pic2.Image = DeGokkers.Properties.Resources.elephant;
                pic3.Image = DeGokkers.Properties.Resources.elephant;
                pic4.Image = DeGokkers.Properties.Resources.elephant;
            }
            if(selectedIndex == 2)
            {
                pic1.Image = DeGokkers.Properties.Resources.hamster;
                pic2.Image = DeGokkers.Properties.Resources.hamster;
                pic3.Image = DeGokkers.Properties.Resources.hamster;
                pic4.Image = DeGokkers.Properties.Resources.hamster;
            }
            if (selectedIndex == 3)
            {
                pic1.Image = DeGokkers.Properties.Resources.panda;
                pic2.Image = DeGokkers.Properties.Resources.panda;
                pic3.Image = DeGokkers.Properties.Resources.panda;
                pic4.Image = DeGokkers.Properties.Resources.panda;
            }
            if (selectedIndex == 4)
            {
                pic1.Image = DeGokkers.Properties.Resources.panther;
                pic2.Image = DeGokkers.Properties.Resources.panther;
                pic3.Image = DeGokkers.Properties.Resources.panther;
                pic4.Image = DeGokkers.Properties.Resources.panther;
            }
        }
    }
}

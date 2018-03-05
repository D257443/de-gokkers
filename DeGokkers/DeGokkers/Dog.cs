using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    class Dog : Form1
    {
        protected void tmrDog_Tick(object sender, EventArgs e)
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
    }
}

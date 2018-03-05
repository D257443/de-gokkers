using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGokkers
{
    class Elephant : Form1
    {
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
                button1.Visible = true;
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
    }
}

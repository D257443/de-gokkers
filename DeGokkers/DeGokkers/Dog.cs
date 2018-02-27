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

            if (picDog1.Location.X >= 500 || picDog2.Location.X >= 500 || picDog3.Location.X >= 500 || picDog4.Location.X >= 500)
            {
                tmrDog.Enabled = false;
                btnStart.Visible = false;
                button1.Visible = true;
            }
            if (picDog1.Location.X >= 500)
            {
                MessageBox.Show("Hond 1 heeft gewonnen");
                Winner = 1;
                WinnerAssign();
            }
            else if (picDog2.Location.X >= 500)
            {
                MessageBox.Show("Hond 2 heeft gewonnen");
                Winner = 2;
                WinnerAssign();
            }
            else if (picDog3.Location.X >= 500)
            {
                MessageBox.Show("Hond 3 heeft gewonnen");
                Winner = 3;
                WinnerAssign();
            }
            else if (picDog4.Location.X >= 500)
            {
                MessageBox.Show("Hond 4 heeft gewonnen");
                Winner = 4;
                WinnerAssign();
            }

        }
    }
}

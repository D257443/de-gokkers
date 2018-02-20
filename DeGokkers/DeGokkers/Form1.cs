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

        private void btnBet_Click(object sender, EventArgs e)
        {
            int Bet = Decimal.ToInt32(inpMoney.Value);
            int AnimalNumber = Decimal.ToInt32(inpAnNum.Value);
            if (btnPlayer1.Checked)
            {
                lblPlayer1.Text = "Gijs heeft " + Bet + " gezet op nummer " + AnimalNumber + ".";
            }
            if (btnPlayer2.Checked)
            {
                lblPlayer2.Text = ""
            }

        }
    }
}

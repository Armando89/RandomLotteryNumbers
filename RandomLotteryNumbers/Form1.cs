using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLotteryNumbers
{
    public partial class LotteryForm : Form
    {
        public LotteryForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumbersButton_Click(object sender, EventArgs e)
        {
            Random numbers = new Random();
        }
    }
}

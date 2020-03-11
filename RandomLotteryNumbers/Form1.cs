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
            //declares an "int" constant, SIZE, set to the value 5. This statement is used as an array size declarator.
            const int SIZE = 5; 
            
            //creates an "int" array, lotteryNumbers, w/five elements.
            int[] lotteryNumbers = new int[SIZE];
            
            //creates a "Random" object that is referenced by a variable, randNum. 
            Random randNum = new Random();

            //for-loop uses an "int" variable, index, initialized to 0
            //for-loop iterates as long as "index" is less than "lotteryNumbers.Length"(5)
            //uses "index" as its counter and is incremented after each loop iteration
            //it will iterate 5 times and "index" is assigned the values 0-4
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                //gets a random # in the range 0-99 & assigns it to "lotteryNumbers[index]"
                //the first iteration assigns a random # to "lotteryNumbers[0]", the second iteration to "lotteryNumbers[1]", etc.
                //the process continues until the loop is finished & each array element is assigned a random #
                lotteryNumbers[index] = randNum.Next(100);
            }

            //displaying the array elements in the label controls
            NumLabel1.Text = lotteryNumbers[0].ToString();
            NumLabel2.Text = lotteryNumbers[1].ToString();
            NumLabel3.Text = lotteryNumbers[2].ToString();
            NumLabel4.Text = lotteryNumbers[3].ToString();
            NumLabel5.Text = lotteryNumbers[4].ToString();
        }
    }
}

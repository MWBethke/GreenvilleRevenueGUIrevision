//Written By Matthew Bethke, Andrew Poppenberg
//Date: 02/15/17
//Chapter 4, Case Problem 1
//Program Calculates Estimated revenue for contest and displays revenue and whether or not it increased from the year prior
//No Issues Encountered again
using System;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        private void getRevenue_Click(object sender, EventArgs e)
        {
            int lastAttend = Convert.ToInt32(lastYearInput.Text);
            int thisAttend = Convert.ToInt32(thisYearInput.Text);
            bool isGreater = (thisAttend > lastAttend);
            bool isDouble = (thisAttend >= (2 * lastAttend));
            if (thisAttend < 0 || thisAttend > 30 || lastAttend < 0 || lastAttend > 30)
            {
                greaterOutput.Text = "error pick a number between 0-30";
            }
            else
            {
                if ((isGreater == true) && (isDouble == true))
                {
                    greaterOutput.Text = "The compertition is more than twice as big this year";
                }
                else if ((isGreater == true) && (isDouble == false))
                {
                    greaterOutput.Text = "The compertition is bigger than ever";
                }
                else
                {
                    greaterOutput.Text = "A tighter race this year! Come out and cast your vote!";
                }
                revenueOutput.Text = Convert.ToString(thisAttend * 25);
            }
        }
        private void TYALabel_Click(object sender, EventArgs e)
        {

        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {

        }
    }
}

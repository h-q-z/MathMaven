using MurvunMuthFun.NumberTheory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurvunMuthFun
{
    public partial class MurvunMuthMain : Form
    {
        private static String question = "NA";
        public MurvunMuthMain()
        {
            InitializeComponent();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trigonometryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void arml2007T4MenuItem_Click(object sender, EventArgs e)
        {
            question = "NUMBERTHEORY_ARML_2007_T4";
            QuestionBox.Text = "Consider the increasing list of positive integers that do not contain the digit 0; i.e., 1,2,3,...,8,9,11,12,.... Compute the 2007th integer in this list.";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (question.Equals("NUMBERTHEORY_ARML_2007_T4"))
            {
                ARML_muncher aMuncher = new ARML_muncher();
                String result = aMuncher.compute2007_Team_4();
                AnswerBox.Text = result;
            }
        }
    }
}

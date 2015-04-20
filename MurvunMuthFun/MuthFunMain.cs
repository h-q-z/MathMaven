using MurvunMuthFun.NumberTheory.ARML._2007;
using MurvunMuthFun.Other;
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
        private static String typeOfQuestion = "NA";
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
            typeOfQuestion = "NUMBERTHEORY_ARML_2007_T4";
            QuestionBox.Text = "Consider the increasing list of positive integers that do not contain the digit 0; i.e., 1,2,3,...,8,9,11,12,.... Compute the 2007th integer in this list.";
            AnswerBox.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (typeOfQuestion.Equals("NUMBERTHEORY_ARML_2007_T4"))
            {
                TeamWorker teamWorker = new TeamWorker();
                String result = teamWorker.computeT4();
                AnswerBox.Text = result;
            } else if (typeOfQuestion.Equals("SillyAnswerMachine")) {
                handleSam(); 
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sillyAnswerMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfQuestion = "SillyAnswerMachine";
            handleSam();

        }

        private void handleSam()
        {
            SillyAnswerMachine sam = new SillyAnswerMachine();
            // 1. Get a random question from our question list
            String q = sam.getQuestion();

            // 2. Get a random answer
            String a = sam.getAnswer();
            // 3. Display 2 in QuestionBox
            QuestionBox.Text = q;
            // 4. Display 4 in AnswerBox
            AnswerBox.Text = a;
        }

        private void QuestionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnswerBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

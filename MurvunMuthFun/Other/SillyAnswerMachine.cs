using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurvunMuthFun.Other
{
    class SillyAnswerMachine
    {
        // Have a private static list of questions
        private static List<String> sillyQuestions = new List<String>();

        // Have a private static list of answers
        private static List<String> sillyAnswers = new List<String>();

        public SillyAnswerMachine() {
            if (sillyQuestions.Count() == 0) {
                sillyQuestions.Add("How many apples are on the table?"); //1
                sillyQuestions.Add("How many cities are there in the world?"); //2
                sillyQuestions.Add("How many stars are in the sky?"); //3
                sillyQuestions.Add("How many digits are there in pi?"); //4
                sillyQuestions.Add("How many milliliters are there in a cup?"); //5
                sillyQuestions.Add("How many books are in a shelf?"); //6 
                sillyQuestions.Add("How many pages are in a novel?"); //7
            }
            if (sillyAnswers.Count() == 0) {
                sillyAnswers.Add("4.");
                sillyAnswers.Add("600 thousand.");
                sillyAnswers.Add("1 gazillion.");
                sillyAnswers.Add("Infinity");
                sillyAnswers.Add("240");
                sillyAnswers.Add("80");
                sillyAnswers.Add("500");
            }

        }

        public String getQuestion()
        {
            Random rand = new Random();
            int nQIndex = rand.Next(7);
            return sillyQuestions[nQIndex];
        }

        public String getAnswer()
        {
            Random rand = new Random();
            int nAIndex = (rand.Next(700) % 7);
            return sillyAnswers[nAIndex];
            
        }

    }
}


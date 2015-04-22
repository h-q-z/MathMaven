using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurvunMuthFun.Controller
{
    class Question
    {
        private String testID { get; set; }
        private String testName { get; set; }
        private String testYear { get; set; }
        private String testRound { get; set; }
        private String questionNumber { get; set; }
        private String question { get; set; }
        private String questionGraphPath { get; set; }
        private String answerKey { get; set; }
    };

    class Test
    {
        private List<Question> questions = new List<Question>();

        public int loadTest(String testFile) {

            return 0;
        }
    };
}

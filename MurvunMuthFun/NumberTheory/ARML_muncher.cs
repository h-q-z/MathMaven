using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurvunMuthFun.NumberTheory
{
    class ARML_muncher
    {
        public String compute2007_Team_4()
        {
            String answer = "";
            int count = 0;
            int number = 0;
            while (true)
            {
                if (!number.ToString().Contains('0'))
                {
                    answer += number + "\t";
                    count++;
                }
                if (count == 2007)
                    return answer + "\nSo the answer is " + number;
                number++;
            }
        }
    }
}

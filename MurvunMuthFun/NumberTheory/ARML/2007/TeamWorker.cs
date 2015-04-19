using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurvunMuthFun.NumberTheory.ARML._2007
{
    class TeamWorker
    {
        public int computeT4()
        {
            int count = 0;
            int number = 0;
            while (true)
            {
                if (!number.ToString().Contains('0'))
                {
                    count++;
                }
                if (count == 2007)
                    return number;
                number++;
            }
        }
    }
}

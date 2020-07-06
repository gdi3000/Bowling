using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple
{
    public class Calculator
    {
        public int Points { get; set; }

        //Da alle 2 tal er et par, og har inflydelse på den totale score, lægger jeg dem sammen en efter en.

        public static List<int> Calc(List<int> numTemp)
        {

            int tempint1 = 0;
            int tempint2 = 0;
            int counter = 1;
            List<int> Score = new List<int>();

            foreach (int n in numTemp)
            {
                if(counter == 1)
                {
                    tempint1 = n;
                }
                
                              
                if(counter == 2)
                {
                    tempint2 = n;

                    Score.Add(rules(tempint1, tempint2));

                    counter = 0;
                }
                counter++;
            }
            return Score;                  
                    
        }


        public static int rules(int n1, int n2)
        {

            if (n1 == 10)
            {
                return 30;
            }

            if (n1 + n2 == 10)
            {
                return 10 + n1;
            }

            return n1+n2;
        }

    }
}

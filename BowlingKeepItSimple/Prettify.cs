using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple
{
    class Prettify
    {
        public static string JsonPrettify(string UPs)
        {

           //Tager det JSON jeg har behov for

            string UP = UPs;

            string[] temp = UP.Split(':');

            UP = temp[1];
            


            // Går UP igennem efter alle tal og komma, så jeg ved hvor mange kejler det blev taget i hver runde
            // - da 2 tal vil være en runde.
            // Derefter puttede jeg dem i en Val. List<int>.

            List<int> val = new List<int>();
            string b = string.Empty;
            for (int i = 0; i < UP.Length; i++)
            {
                if (Char.IsDigit(UP[i]) || UP[i] == ',')
                {
                    b += UP[i];

                }

            }

            string[] tmparry = b.Split(',');

            string Rounds = "Bowling Rounds: Pins struck \n";
            foreach (var q in tmparry)
            {
                if (q != "")
                {
                    val.Add(int.Parse(q));
                    Rounds += q +"\n";
                }
          
            }
           
            

            // Udregner point
            List<int> Score = Calculator.Calc(val);

            // Læger informationerne i en string som bliver retuneret.
            string result = Rounds + " \n \n Points: \n";
            int tmp =0;
            
            foreach (int i in Score)
            {
                tmp += i;
                result += i.ToString();
                result += "\n";
            }

            
            result += "\n \n Total Score \n";
            result += tmp.ToString();
            return result;

        }

    }
}

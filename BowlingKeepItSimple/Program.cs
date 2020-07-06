using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling-point calculator Console App. \n");
            System.Threading.Thread.Sleep(1500);


            RunApp App = new RunApp();

            Console.WriteLine(App.run());

            Console.ReadLine();



        }
    }
}

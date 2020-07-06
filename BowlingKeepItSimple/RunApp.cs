using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple
{
    internal class RunApp
    {
        
        //Som sådan ingen behov for at lave denne klasse, tænkte bare det kunne gøre det mere overskueligt

        RestClient rc = new RestClient();
        List<object> list = new List<object>();



        public string run()
        {
            
            //For at gøre det testbart, vælger jeg at metoden skal tage i mod parameter.

            var x = rc.MakeRequest("http://13.74.31.101/api/points");


            return Prettify.JsonPrettify(x);


        }

    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKeepItSimple
{
    public class RestClient
    {
        public enum httpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        //public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            //endPoint = "http://13.74.31.101/api/points";
            httpMethod = httpVerb.GET;
        }

        public string MakeRequest(string endPoint)
        {
            

            string result = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ArgumentException("Error Code: " + response.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            result = reader.ReadToEnd();

                            //testing
                            if(result == "")
                            {
                                throw new ArgumentException("No Data Found");
                            }
                            //
                        }

                    }
                }
            }

            return result;
        }
    }

}


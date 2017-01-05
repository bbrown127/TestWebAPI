using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyHttp.Http;

namespace TestWebAPI.Client
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void GetPeople()
        {
            var client = new HttpClient();
            client.Request.Accept = HttpContentTypes.ApplicationJson;
            var result = client.Get("http://localhost:54842/api/people");
            var tree = result.DynamicBody;
        }
    }
}

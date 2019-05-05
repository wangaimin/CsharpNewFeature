using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
   public static class Csharp_5
    {

        public static async void GetHtmlStr(string url) {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine("GetStringAsync Begin");
            string str = await httpClient.GetStringAsync(url);
            Console.WriteLine("GetStringAsync End");
            Console.WriteLine($"Result:{str}");
        }
    }
}

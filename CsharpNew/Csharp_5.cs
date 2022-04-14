using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpNew
{
   public static class Csharp_5
    {

        public static async void WriteLineHtmlStr(string url) {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine("***************WriteLineHtmlStr Begin");
            string str = await httpClient.GetStringAsync(url);
            Console.WriteLine("***************WriteLineHtmlStr End");
            Console.WriteLine($"***************WriteLineHtmlStr Result:{str}");
        }

        public static async Task<string> GetHtmlStr(string url)
        {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine("***************GetStringAsync Begin");
            string str = await httpClient.GetStringAsync(url);
            Thread.Sleep(2000);
            Console.WriteLine("***************GetStringAsync End");
          //  Console.WriteLine($"Result:{str}");
            return str;
        }
    }
}

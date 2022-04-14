using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
    class Program
    {
        static void Main(string[] args)
        {
            EncodingUTF8.HttpPost("https://www.baidu.com", "王", Encoding.UTF8, Encoding.UTF8);

            Csharp_5.WriteLineHtmlStr(@"http://localhost:31956/Login/jc");

            Task<string> task = Csharp_5.GetHtmlStr(@"http://localhost:31956/Login/jc");
            Console.WriteLine($"***********Console Result:{task.Result}");


            // Console.WriteLine(Csharp_6.GetFullName("Gene", "WANG"));


            Csharp_7.PatternMatching();
            Console.ReadKey();
        }
    }
}

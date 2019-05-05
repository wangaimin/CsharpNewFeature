using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
    public static class Csharp_7
    {
        public static void OutVariate() {

            string str = "1";
            if (int.TryParse(str, out int num))
            {
                Console.WriteLine($"out变量转换成功。int值为{num}");
            }
            else {
                Console.WriteLine($"out变量转换失败。string值为{str}");
            }
        }

        /// <summary>
        /// 用is判断类型并把值赋给新变量
        /// </summary>
        public static void PatternMatching() {
            object obj = "1";
            if (obj is int num)
            {
                Console.WriteLine($"int类型，值为{num}");
            }
            else if(obj is string str)
            {
                Console.WriteLine($"string类型，值为{str}");
            }

        }

    }
}

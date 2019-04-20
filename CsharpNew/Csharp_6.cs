using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
    /*
     
    Expression-bodied 函数成员     
         
         
    */
    static class Csharp_6 
    {

        /// <summary>
        /// Expression-bodied 函数成员     
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public static string GetFullName(string lastName, string firstName)
        {
            return $"{lastName} {firstName}";
        }
    }
}

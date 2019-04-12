using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //"^" shift +6
            //Console.WriteLine(Regex.IsMatch("234", "\\d{2}"));
            //Console.WriteLine(Regex.IsMatch("234", "\\^d{2}$"));
            //Console.WriteLine(Regex.IsMatch("23888888883", @"^1\d{10}$"));
            // Console.WriteLine(Regex.IsMatch("192.168.1.15342", @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$"));
            Console.WriteLine(Regex.IsMatch("2003-03-2259", @"^\d{4}\-\d{1,2}\-\d{1,2}$"));
            Console.ReadKey();
        }
    }
}

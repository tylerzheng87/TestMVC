using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式提取
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用()获取“分组”
            Match match = Regex.Match("2008-8-08", @"^(\d{4})\-(\d{1,2})\-(\d{1,2})$");
            if (match.Success)
            {
                string year = match.Groups[1].Value;
                string month = match.Groups[2].Value;
                string day = match.Groups[3].Value;
                Console.WriteLine("年" + year + "月" + month + "日" + day);
            }
            else
            {
                Console.WriteLine("匹配失败");
            }
            Console.ReadKey();
        }
    }
}

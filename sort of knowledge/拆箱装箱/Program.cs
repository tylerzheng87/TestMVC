using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拆箱装箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //拆箱的时候一定要用装箱的类型
            /*
            int i = 5;
            object obj1 = i;
            long j2 = i;
            long j3 = (long)i;
            long j4 = (long)obj1;//会报错
            object  ExecuteScalar("select count(*) from t") long int
            int i=Convert.toInt32(obj1)
            */
            

            int i = 5;
            object obj = i;//object C#,Object CTS 装箱（boxing）
            int i1 = (int)obj;//拆箱
             
            
            Console.WriteLine(i1);
            Console.ReadKey();
        }


        public  class MyClass
        {
            void cctv()
            {
            }

            public  int cctv(int i)
            {
                return 1;
            }

        }
    }
}

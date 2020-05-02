using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleGameAirGuess
{
    class Program
    {
        static int[] Maps = new int[100];
        //幸运轮盘：○ 1   地雷：☆ 2   暂停：△ 3   时空隧道：## 4
        static int[] Players = new int[2];
        
        static void Main(string[] args)
        {
            InitailMap();
            DrowMap();
            Shotgun.ColorConsole.ColorConsole.WriteLine("$Y ************************************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$G ****飞行棋终结版********************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$R ************************************");
            Console.ReadLine();





        }
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘○
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }

            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }

            int[] pause = { 9, 27, 63, 93 };//暂停△
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }

            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道##
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }

        public static void DrowMap()
        {
            //第一行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrowingMap(i));
               
            }
            Console.WriteLine();
          


        }

        private static string DrowingMap(int i)
        {
            string str = "";
            if (Players[0]==Players[1]&& Players[0]==i)
            {
                str = "<>";
            }
            if ( Players[0] == i)
            {
                str = "A";
            }
            if (Players[1] == i)
            {
                str = "B";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "○";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "△";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        str = "##";
                        break;
                }
            }
            return str;
        }
    }
}

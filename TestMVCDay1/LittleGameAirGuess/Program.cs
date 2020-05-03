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

        static string[] PlayersName = new string[2];

        static void Main(string[] args)
        {

            GameHead();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的名字");
            PlayersName[0] = Console.ReadLine();
            while (PlayersName[0]=="")
            {
                Console.WriteLine("玩家A的名字不能为空");
                PlayersName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的名字");
            PlayersName[1] = Console.ReadLine();
            while (PlayersName[1]== PlayersName[0]|| PlayersName[1]=="")
            {
                if (PlayersName[1] == "")
                {
                    Console.WriteLine("玩家B的名字不能为空");
                    PlayersName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家AB的名字不能为空");
                    PlayersName[1] = Console.ReadLine();
                }

            }
            #endregion

            Console.Clear();

            GameHead();
            Console.WriteLine("对战开始");
            Console.WriteLine("{0}的士兵用A表示",PlayersName[0]);
            Console.WriteLine("{0}的士兵用A表示", PlayersName[1]);
            InitailMap();
            DrowMap();
            Console.ReadLine();





        }
        #region 添加头
        public static void GameHead()
        {
            Shotgun.ColorConsole.ColorConsole.WriteLine("$Y ************************************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$G ****飞行棋终结版********************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$R ************************************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$R ************************************");
            Shotgun.ColorConsole.ColorConsole.WriteLine("$R ************************************");

        }

        #endregion

        #region 初始化地图
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

        #endregion

        #region 画地图
        public static void DrowMap()
        {
            Console.WriteLine("图例：幸运轮盘◎   地雷：☆   暂停：▲   时空隧道：卐");

            //第一行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrowingMap(i));
               
            }
            Console.WriteLine();
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrowingMap(i));
               　Console.WriteLine();
            }
            #endregion
           
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrowingMap(i));

            }
            Console.WriteLine();
            #endregion

            # region 第二竖行

            for (int i = 65; i < 69; i++)
            {
                Console.WriteLine(DrowingMap(i));
            }
            #endregion

            #region  最后一横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrowingMap(i));
                
            }
            Console.WriteLine();
            #endregion



        }

        #endregion
        private static string DrowingMap(int i)
        {
            
            string str = "";
            if (Players[0]==Players[1]&& Players[0]==i)
            {
                str = "<>";
            }
            else  if ( Players[0] == i)
            {
                str = "Ａ";　//shift+空格
            }
            else  if (Players[1] == i)
            {
                str = "Ｂ";
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
                        str = "卐";
                        break;
                }
            }
            return str;
        }
    }
}

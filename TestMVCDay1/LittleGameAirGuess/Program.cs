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
        static bool[] Flag = new bool[2];
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

            while (Players[0]<99&&Players[1]<99)
            {
                if (Flag[0]==false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flag[0] = false;
                }
                if (Players[0]>=99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayersName[0], PlayersName[1]);
                    break;
                }
                if (Flag[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flag[1] = false;
                }
                if (Players[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayersName[1], PlayersName[0]);
                    break;
                }
            }
            Win();
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

        /// <summary>
        /// 抽象出来的画地图的方法，返回一个要画的字符串
        /// </summary>
        /// <param name="i">当前地图坐标</param>
        /// <returns></returns>
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

        public static void PlayGame(int playerNumber)
        {
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayersName[playerNumber]);
            Console.ReadKey(true);//按下的任意键不在控制台显示
            Random rd = new Random();
            int rdnumber = rd.Next(1, 7);
            Console.WriteLine("玩家{0}掷出了{1}", PlayersName[playerNumber], rdnumber);
            Players[playerNumber] += rdnumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动", PlayersName[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", PlayersName[playerNumber]);
            Console.ReadKey(true);
            //如果玩家A踩到玩家B
            //    游戏规则：
            //如果玩家A踩到了玩家B 玩家B退6格
            //踩到了地雷 退6格
            //踩到了时空隧道 进10格
            //踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格
            //踩到了暂停 暂停一回合 3
            //踩到了方块 神马都不干 0
            if (Players[playerNumber] == Players[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退六格", PlayersName[playerNumber], PlayersName[1- playerNumber], PlayersName[playerNumber]);
                Players[1] -= 6;
                ChangePos();
            }
            else
            {
                switch (Maps[Players[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块什么都不发生", PlayersName[playerNumber]);
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘,1--交换位置,2--轰炸对方 使对方退6格", PlayersName[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}与玩家{1}选择1--交换位置", PlayersName[playerNumber], PlayersName[1 - playerNumber]);
                                int temp = Players[playerNumber];
                                Players[playerNumber] = Players[1 - playerNumber];
                                Players[1 - playerNumber] = temp;
                                ChangePos();
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸对方{1}退6格", PlayersName[playerNumber], PlayersName[1 - playerNumber]);
                                Players[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("玩家{0}踩到了幸运轮盘,1--交换位置,2 轰炸对方 使对方退6格", PlayersName[playerNumber]);
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到地雷玩家{1}退六格", PlayersName[playerNumber], PlayersName[playerNumber]);
                        Players[playerNumber] -= 6;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到暂停", PlayersName[playerNumber], PlayersName[playerNumber]);
                        Flag[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到时空隧道近十格", PlayersName[playerNumber]);
                        Players[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;

                }

            }
            Console.Clear();
            DrowMap();
        }

        public static void ChangePos()
        {
            if (Players[0]<=0)
            {
                Players[0] = 0;
            }
            if(Players[0] >= 99)
            {
                Players[0] = 99;
            }
            if (Players[1] <= 0)
            {
                Players[1] = 0;
            }
            if (Players[1] >= 99)
            {
                Players[1] = 99;
            }
        }
        /// <summary>
        /// 胜利啦
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice
{ 

    class MainClass
    {
        public static void drawChessboard()
        {
            int[,] board = new int[10, 17];
            int Width = 17;
            int Height = 10;
            board[4, 4] = 1;
            board[4, 5] = -1;
            board[5, 4] = -1;
            board[5, 4] = 1;

            for (int y = 0; i < Height; i++)
            {    
                    Console.Write("+---------------+");         
                    for (int j = 0; j < Width; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("|");
                        }
                        else if (board[i, j] == 0)
                        {
                            Console.Write(".");
                        }
                        else if (board[i, j] == 1)
                        {
                            Console.Write("●");
                        }
                        else
                        {
                            Console.Write("◯");
                        }
                    }            
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Game start");

            //０１２３４５６７８ Width9 Height9
            //２・・・・・・・・
            //３・・・・・・・・
            //４・・・〇仝・・・
            //５・・・仝〇・・・
            //６・・・・・・・・
            //７・・・・・・・・
            //８・・・・・・・・

            //+---------------+ Width17 Height10
            //|.|.|.|.|.|.|.|.|
            //|.|.|.|.|.|.|.|.|
            //|.|.|.|.|.|.|.|.|
            //|.|.|.|●|◯|.|.|.|
            //|.|.|.|◯|●|.|.|.|
            //|.|.|.|.|.|.|.|.|
            //|.|.|.|.|.|.|.|.|
            //|.|.|.|.|.|.|.|.|
            //+---------------+

            //初期盤面の描写
            drawChessboard();
            
            //ゲーム開始
            Console.WriteLine("Enter your placement");
        }
    }
}
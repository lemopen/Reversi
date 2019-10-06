using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice
{
    class Program
    {
        private static bool UTF8Encoding(string v)
        {
            throw new NotImplementedException();
        }

        public static void DrawGameboard(int[,]board)
        {
            string stringUTF8 = someFunctionReturnsUtf8();
            byte[] bytesUTF8 = System.Text.Encoding.Default.GetBytes(stringUTF8);
            string stringSJIS = System.Text.Encoding.UTF8.GetString(bytesUTF8);

            Console.Clear();
            Console.WriteLine("ＡＢＣＤＥＦＧＨ");
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    //if (x == 0 + y)
                    //{
                    //    Console.Write();
                    //}
                    if (board[x, y] == 0)
                    {
                        Console.Write("・");
                    }
                    else if (board[x, y] == 1)
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

        private static string someFunctionReturnsUtf8()
        {
            throw new NotImplementedException();
        }

        public static void Reversi(string[] args)
        {
            Console.WriteLine("Game start");
            //　１２３４５６７８
            //Ａ・・・・・・・・
            //Ｂ・・・・・・・・
            //Ｃ・・・・・・・・
            //Ｄ・・・❍●・・・
            //Ｅ・・・●❍・・・
            //Ｆ・・・・・・・・
            //Ｇ・・・・・・・・
            //Ｈ・・・・・・・・

            //初期盤面の描写
            int[,] board = new int[9, 9];
            board[4, 4] = 1;
            board[4, 5] = -1;
            board[5, 4] = -1;
            board[5, 4] = 1;
            int width = board.GetLength(0);
            int height = board.GetLength(1);
            DrawGameboard(board);

            //ゲーム開始
            Console.WriteLine("Enter your placement");
        }
    }
}

//stringUTF8に何らかUTF8の文字列が入ってくる
//string stringUTF8 = someFunctionReturnsUtf8();

//まずはバイト配列に変換する
//byte[] bytesUTF8 = System.Text.Encoding.Default.GetBytes(stringUTF8);

//バイト配列をUTF8の文字コードとしてStringに変換する
//string stringSJIS = System.Text.Encoding.UTF8.GetString(bytesUTF8);
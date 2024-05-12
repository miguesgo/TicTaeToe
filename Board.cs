using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * File: Board.cs
 * Programmer: miguesgo
 * Date: 11/05/2024
 * Main class of creation of board game
 * 
 */

namespace TicTaeToe
{
    internal class Board
    {
        public List<string> ticTaeToeBoard {  get; set; }

        public void makeBoard()
        {
            ticTaeToeBoard = new List<string>();
            ticTaeToeBoard = [" ", " ", " ",
                              " ", " ", " ",
                              " ", " ", " "];
        }

        public void showBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write($"{ticTaeToeBoard[i]} |");
                        break;
                    case 1:
                        Console.Write($" {ticTaeToeBoard[i]} ");
                        break;
                    case 2:
                        Console.Write($"| {ticTaeToeBoard[i]}\n");
                        Console.Write("---------\n");
                        break;
                    case 3:
                        Console.Write($"{ticTaeToeBoard[i]} |");
                        break;
                    case 4:
                        Console.Write($" {ticTaeToeBoard[i]} ");
                        break;
                    case 5:
                        Console.Write($"| {ticTaeToeBoard[i]}\n");
                        Console.Write("---------\n");
                        break;
                    case 6:
                        Console.Write($"{ticTaeToeBoard[i]} |");
                        break;
                    case 7:
                        Console.Write($" {ticTaeToeBoard[i]} ");
                        break;
                    case 8:
                        Console.Write($"| {ticTaeToeBoard[i]}\n");
                        Console.Write("---------\n");
                        break;
                    default:
                        break;
                }
                    
            }
        }
    }
}

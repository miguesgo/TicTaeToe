using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
 * 
 * File: Program.cs
 * Programmer: miguesgo
 * Date: 11/05/2024
 * Main class for custom logic of the TicTaeToe game!
 * 
 */

namespace TicTaeToe
{
    internal class Game : Board
    {
        private int contPositions = 9;
        private int input = 0;
        private bool gameOver = false;

        public void startGame(Dictionary<string, int> player1, Dictionary<string, int> player2)
        {
            /*
             * The logic of the game consist in determine if the position elected could be
             * implemented, for example, the board has 9 positions, but if the game 
             * is extended until the 9 positions full, well, that means the game has to over
             * that's way the game is being used inside a while of positions grater than zero,
             * in this way, the contPositions is decremented every position marked.
             * 
             */

            makeBoard();
            while (contPositions > 0)
            {
                ticTaeToeInAction(player1);
                if (gameOver || contPositions < 1)
                    break;
                
                ticTaeToeInAction(player2);
                if (gameOver)
                    break;
            }
            Console.WriteLine("GAMEOVER!");
        }

        public void ticTaeToeInAction(Dictionary<string, int> player)
        {
            /*
             *  Then, we have to determine if the position is correct in the board context
             *  io if the position is between 1 and 9 and if there's not
             *  another mark at the position elected, if not, the player have to continue
             *  choosing another position until he/she choose a valid one.
             */

            foreach (KeyValuePair<string, int> element in player)
            {
                while ((input >= 1 &&
                        input <= 9 &&
                        ticTaeToeBoard[input - 1] != "X" &&
                        ticTaeToeBoard[input - 1] != "O") == false)
                {
                    Console.WriteLine($">> PLAYER {element.Key}: Enter position to mark '{element.Key}' <<");
                    int.TryParse(Console.ReadLine(), out input);
                }

                contPositions--;
                player[element.Key] = input;
                if (player[element.Key] >= 1 &&
                    player[element.Key] <= 9 &&
                    ticTaeToeBoard[player[element.Key] - 1] != "X" &&
                    ticTaeToeBoard[player[element.Key] - 1] != "O")
                {
                    ticTaeToeBoard[player[element.Key] - 1] = element.Key;
                    showBoard();
                }

                checkWinner(contPositions, player);
            }
        }

        public bool checkWinner(int contPositions, Dictionary<string, int> player)
        {
            /*
             * After 3 iterations, it checks if the player X or O, wins the game,
             * comparing the actual position with the last 3 of them, in this case,
             * we can just compare all the board marks, for example, the player
             * wins if he/she marks 3 in a row in left-right, up-down and in cross.
             * 
             */

            if (contPositions <= 6)
            {
                foreach (KeyValuePair<string, int> element in player)
                {
                    if ((ticTaeToeBoard[0] == element.Key && 
                         ticTaeToeBoard[1] == element.Key &&
                         ticTaeToeBoard[2] == element.Key) ||
                        (ticTaeToeBoard[0] == element.Key &&
                         ticTaeToeBoard[3] == element.Key &&
                         ticTaeToeBoard[6] == element.Key) ||
                        (ticTaeToeBoard[6] == element.Key && 
                         ticTaeToeBoard[7] == element.Key && 
                         ticTaeToeBoard[8] == element.Key) ||
                        (ticTaeToeBoard[2] == element.Key && 
                         ticTaeToeBoard[5] == element.Key && 
                         ticTaeToeBoard[8] == element.Key) ||
                        (ticTaeToeBoard[1] == element.Key && 
                         ticTaeToeBoard[4] == element.Key && 
                         ticTaeToeBoard[7] == element.Key) ||
                        (ticTaeToeBoard[0] == element.Key && 
                         ticTaeToeBoard[4] == element.Key &&
                         ticTaeToeBoard[8] == element.Key) ||
                        (ticTaeToeBoard[6] == element.Key && 
                         ticTaeToeBoard[4] == element.Key && 
                         ticTaeToeBoard[2] == element.Key))
                    {
                        Console.WriteLine($"{element.Key} WINS!");
                        gameOver = true;
                    }
                }
            }
            return gameOver;
        }
    }
}

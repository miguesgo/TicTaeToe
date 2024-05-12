using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * File: Players.cs
 * Programmer: miguesgo
 * Date: 11/05/2024
 * Main class of creation of players
 *  (this could be customize at future!)
 * 
 */

namespace TicTaeToe
{
    internal class Players
    {
        public Dictionary<string, int> player1 { get; set; }
        public Dictionary<string, int> player2 { get; set; }

        public void makePlayers()
        {
            /*
             * The dictionary will have the next structure:
             * key: letter of the mark (could be customize ;'D)
             * value: the position of the board to be marked
             *  (initialized at zero)
             */
            player1 = new Dictionary<string, int>();
            player2 = new Dictionary<string, int>();
            player1.Add("X", 0);
            player2.Add("O", 0);
        }
    }
}

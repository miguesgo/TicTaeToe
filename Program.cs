using TicTaeToe;

/*
 * 
 * File: Program.cs
 * Programmer: miguesgo
 * Date: 11/05/2024
 * Main program of the TicTaeToe game!
 * 
 */

Console.WriteLine("======= WELCOME =======");
Players players = new Players();
Game newGame = new Game();
players.makePlayers();
newGame.startGame(players.player1, players.player2);
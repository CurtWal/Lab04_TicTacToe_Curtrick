using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
			
			//TODO: Output the board to the console
	  string line = "   1  |  2  |  3";
      Console.WriteLine("\n\n");
      Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
      Console.WriteLine($"\t{GameBoard[0,0]}  |  {GameBoard[0,1]}  |  {GameBoard[0,2]}\n");
      Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
      Console.WriteLine($"\t{GameBoard[1,0]}  |  {GameBoard[1,1]}  |  {GameBoard[1,2]}\n");
      Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
      Console.WriteLine($"\t{GameBoard[2,0]}  |  {GameBoard[2,1]}  |  {GameBoard[2,2]}\n\n");
		}
	}
}
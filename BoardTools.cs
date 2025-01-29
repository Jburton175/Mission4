using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission4
{
    internal class BoardTools
    {

        //Receive the “board” array from the driver class
        //Contain a method that prints the board based on the information passed to it
        public static void printBoard(char[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("---|---|---");
        }

        //Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public static bool gameWinner(char[] board, out char winner)
        {
            // Winning combinations
            int[,] winningCombos =
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
                { 0, 4, 8 }, { 2, 4, 6 } // Diagonals
            };

            for (int i = 0; i < winningCombos.GetLength(0); i++) // Loop through each winning combo
            {
                if (board[winningCombos[i, 0]] == board[winningCombos[i, 1]] &&
                    board[winningCombos[i, 1]] == board[winningCombos[i, 2]])
                {
                    winner = board[winningCombos[i, 0]];
                    Console.WriteLine($"The winner is {board[winningCombos[i, 0]]}");
                    return true;
                }
            }

            winner = ' ';
            return false;
        }
    }
}

using System;
using System.Collections.Generic;

namespace tetris.Models
{
	public class Board
	{
		public int BoardColumns {get;set;}
		public int BoardRows {get;set;}
		public object Pile {get;set;}
		public bool[,] Field {get;set;}
		public char VerticalBorder {get;set;}
		public char[] HorizontalBorder {get;set;}
		public int VerticalBuffer {get;set;}
		public bool F = false;
		public bool T = true;
		public Board()
		{
			BoardColumns = 10;
			BoardRows = 20;
			VerticalBuffer = 3;
			ClearBoard();
			HorizontalBorder = new char[] {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'};
			VerticalBorder = '|';
		}
		
		private void ClearBoard()
		{
			Field = new bool[23,10]
				{
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F},
					{F,F,F,F,F,F,F,F,F,F}
				};
		}

		public void DrawGameState(Piece current) {
			ClearBoard();
			// DrawHeap();
			DrawPiece(current);
			DrawBoard();
		}
		private void DrawBoard()
		{
			// Console.SetWindowSize(1,1);
			// Console.SetBufferSize(100,100);
			// Console.SetWindowPosition(50,50);
			// Console.CursorVisible = false;
			// Console.SetWindowSize(BoardColumns + 33, BoardRows + 23);
			// Console.BackgroundColor = ConsoleColor.DarkMagenta;
			// Console.ForegroundColor = ConsoleColor.White;

		foreach(char c in HorizontalBorder)
			Console.Write(c);
		Console.Write("\n");
		for (int i = VerticalBuffer; i < 23; i++)
		{
			System.Console.Write($"{VerticalBorder}");
			for (int j = 0; j < 10; j++)
			{
				if (Field[i,j])
				{
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					System.Console.Write("  ");
				}
				else
				{
					Console.BackgroundColor = ConsoleColor.DarkMagenta;
					System.Console.Write("  ");
				}
			}
			Console.Write($"{VerticalBorder}\n");
		}
		foreach(char c in HorizontalBorder)
			Console.Write(c);
		Console.Write("\n");
		}
		public void DrawPiece(Piece piece)
		{
			for(int i = 0; i < piece.Width; i++)
			{
				for(int j = piece.Height-1; j >= 0 ; j--)
				{
					Field[piece.Position['y']+j+VerticalBuffer,piece.Position['x']+i] = piece.Container[j,i];
				}
			}
			DrawBoard();
		}
		private void SavePile() {}
		public bool Collision(object piece) {return true;}

	}
}
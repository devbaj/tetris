using System;
using System.Collections.Generic;

namespace tetris.Models
{
	public abstract class Piece
	{
		public bool Live {get;set;}
		public bool[,] Container {get;set;}
		public Dictionary<char,int> Position {get;set;}
		public int Width {get;set;}
		public int Height {get;set;}

		public Piece()
		{
			Position = new Dictionary<char, int>();
			Position.Add('x',5);
			Position.Add('y',0);
			Live = true;
		}

		public void Descend(Board thisBoard)
		{
			Position['y'] += 1;
		}

		public virtual void Rotate()
		{
			for (int x = 0; x < Width / 2; x++)
			{
				for (int y = x; y < Width - x - 1; y++)
				{
					bool temp = Container[x,y];
					Container[x,y] = Container[y,Width - 1 - x];
					Container[y, Width - 1 - x ] = Container[Width-1-x,Width-1-y];
					Container[Width-1-x,Width-1-y] = Container[Width - 1 - y, x];
					Container[Width - 1 - y, x] = temp;
				}
			}
		}

		public virtual void Move(string direction, Board thisBoard)
		{
			if (direction == "L")
			{
				if (Position['x'] - 1 >= 0)
					Position['x'] -= 1;
			}
			else
			{
				if (Position['x'] + Width + 1 < thisBoard.BoardColumns)
					Position['x'] += 1;
			}
		}
	}

	class Square : Piece
	{
		public Square()
		{
			Container = new bool[2,2] {{true,true},{true,true}};
			Width = 2;
			Height = 2;
		}

		public override void Rotate() { return; }
	}

	class L : Piece
	{
		public L()
		{
			Container = new bool[3,3] {
				{true,false,false},
				{true,false,false},
				{true,true,false}
				};
			Width = 3;
			Height = 3;
		}
	}

	class ReverseL : Piece
	{
		public ReverseL()
		{
			Container = new bool[3,3] {
				{false,false,true},
				{false,false,true},
				{false,true,true}
			};
			Width = 3;
			Height = 3;
		}
	}

	class I : Piece
	{
		public I()
		{
			Container = new bool[4,4] {
				{true,false,false,false},
				{true,false,false,false},
				{true,false,false,false},
				{true,false,false,false}
			};
			Width = 4;
			Height = 4;
		}
	}

	class T : Piece
	{
		public T()
		{
			Container = new bool[3,3] {
				{false,false,false},
				{false,true,false},
				{true,true,true}
			};
			Width = 3;
			Height = 3;
		}
	}

	class Z : Piece
	{
		public Z()
		{
			Container = new bool[3,3] {
				{false,false,false},
				{true,true,false},
				{false,true,true}
			};
			Width = 3;
			Height = 3;
		}
	}

		class S : Piece
		{
			public S()
			{
				Container = new bool[3,3] {
					{false,false,false},
					{false,true,true},
					{true,true,false}
				};
			Width = 3;
			Height = 3;
			}
		}
}
using System;
using System.Text;

namespace tetris.Models
{
	public class Block
	{
		public char Symbol {get;set;}
		private UTF8Encoding utf8 = new UTF8Encoding();
		private char Symbol32 = '\x9209';
		public Block()
		{
		}
	}
}
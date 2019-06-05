using System;
using tetris.Models;
using System.Threading;

namespace tetris
{
    class Program
    {
        public static void RenderLoop(bool gaming, Board thisBoard)
        {
            Piece thisPiece = NewPiece();
            // Thread Listen = new Thread(ListenForInput).Start(thisPiece);
            while (gaming)
            {
                thisBoard.DrawGameState(thisPiece);
                if (thisPiece.Live)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Spacebar) 
                        {
                            thisPiece.Rotate();
                        }
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            thisPiece.Move("L",thisBoard);
                        }
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            thisPiece.Move("R", thisBoard);
                        }
                    }
                    thisPiece.Descend(thisBoard);
                }
                Thread.Sleep(500);
            }
        }
        
        // public static void ListenForInput(Piece thisPiece)
        // {
            // while (Console.ReadKey(true).KeyChar == ' ')
            // {
                // thisPiece.Rotate();
            // }
        // }
        public static Piece NewPiece()
        {
            string[] PieceList = new string[] {
                "Square",
                "L",
                "ReverseL",
                "I",
                "T",
                "Z",
                "S"
            };
            Random rand = new Random();
            int result = rand.Next(0,7);
            switch(PieceList[result])
            {
                case "Square":
                    return new Square();
                case "L":
                    return new L();
                case "ReverseL":
                    return new ReverseL();
                case "I":
                    return new I();
                case "T":
                    return new T();
                case "Z":
                    return new Z();
                case "S":
                    return new S();
            }
            return null;
        }

        static void Main(string[] args)
        {
            Board Russia = new Board();
            Piece test = NewPiece();
            bool Gaming = true;
            RenderLoop(Gaming, Russia);
//             while (true)
//             {
//                 const int soundLenght = 200;
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1320, soundLenght);
//                 Console.Beep(1188, soundLenght);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 6);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1056, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Thread.Sleep(soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1408, soundLenght * 2);
//                 Console.Beep(1760, soundLenght * 4);
//                 Console.Beep(1584, soundLenght * 2);
//                 Console.Beep(1408, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 6);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 4);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1056, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Thread.Sleep(soundLenght * 4);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1320, soundLenght);
//                 Console.Beep(1188, soundLenght);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 6);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1056, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Thread.Sleep(soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1408, soundLenght * 2);
//                 Console.Beep(1760, soundLenght * 4);
//                 Console.Beep(1584, soundLenght * 2);
//                 Console.Beep(1408, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 6);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1188, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(990, soundLenght * 4);
//                 Console.Beep(990, soundLenght * 2);
//                 Console.Beep(1056, soundLenght * 2);
//                 Console.Beep(1188, soundLenght * 4);
//                 Console.Beep(1320, soundLenght * 4);
//                 Console.Beep(1056, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 4);
//                 Thread.Sleep(soundLenght * 4);
//                 Console.Beep(660, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(594, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(440, soundLenght * 8);
//                 Console.Beep(419, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(660, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(594, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 4);
//                 Console.Beep(660, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 8);
//                 Console.Beep(838, soundLenght * 16);
//                 Console.Beep(660, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(594, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(440, soundLenght * 8);
//                 Console.Beep(419, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(660, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 8);
//                 Console.Beep(594, soundLenght * 8);
//                 Console.Beep(495, soundLenght * 8);
//                 Console.Beep(528, soundLenght * 4);
//                 Console.Beep(660, soundLenght * 4);
//                 Console.Beep(880, soundLenght * 8);
//                 Console.Beep(838, soundLenght * 16);
                    // }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessG
{
    class Knight : Piece
    {
        public override Point[] GetMoves(Point p)
        {
            return new Point[]
            {
                new Point(p.X + 1, p.Y - 2), //up
                new Point(p.X - 1, p.Y - 2), //up
                new Point(p.X + 1, p.Y + 2), //bottom
                new Point(p.X - 1, p.Y + 2),  //bottom
                new Point(p.X + 2, p.Y + 1), //bottomR
                new Point(p.X + 2, p.Y - 1), //upR
                new Point(p.X - 2, p.Y + 1), //bottomL
                new Point(p.X - 2, p.Y - 1) //upL
            };
        }
    }
}

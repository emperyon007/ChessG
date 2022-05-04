using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessG
{
    class Pawn : Piece
    {
        public override Point[] GetMoves(Point p)
        {
            return new Point[]
            {
                new Point(p.X, p.Y - 1),
                new Point(p.X, p.Y - 2),
                new Point(p.X + 1, p.Y - 1), //r
                new Point(p.X - 1, p.Y - 1) //l
            };
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ChessG
{
    abstract class Piece
    {
        bool isAlive;

        public abstract Point[] GetMoves(Point p);
    }
}

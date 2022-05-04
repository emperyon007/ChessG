using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessG
{
    class Rook : Piece
    {
        public override Point[] GetMoves(Point p)
        {
            Point[] points = new Point[28];

            for (int i = 0; i < 28; i += 4)
            {
                int j = (i + 1) / 4;

                points[i] = new Point(p.X, p.Y - j);
                points[i + 1] = new Point(p.X, p.Y + j);
                points[i + 2] = new Point(p.X - j, p.Y);
                points[i + 3] = new Point(p.X + j, p.Y);
            }

            return points;
        }
    }
}

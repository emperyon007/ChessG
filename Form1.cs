using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessG
{
    public partial class Form1 : Form
    {
        int clickedP = 0;
        int clickedK = 0;
        int clickedB = 0;
        int clickedR = 0;
        int clickedQ = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void chessBoard_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);

            Point coordinate = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));

            int cbqX = (coordinate.X - 10) / 75;
            int cbqY = (coordinate.Y - 10) / 75;

            Point currentPawnPosition = new Point((pawn1.Left - 12) / 75, (pawn1.Top - 12) / 75);
            Point currentKnightPosition = new Point((knight.Left - 12) / 75, (knight.Top - 12) / 75);
            Point currentBishopPosition = new Point((bishop.Left - 12) / 75, (bishop.Top - 12) / 75);
            Point currentRookPosition = new Point((rook.Left - 12) / 75, (rook.Top - 12) / 75);
            Point currentQueenPosition = new Point((queen.Left - 12) / 75, (queen.Top - 12) / 75);

            Point wannaBePosition = new Point(cbqX, cbqY);

            Pawn p = new Pawn();
            Knight k = new Knight();
            Bishop b = new Bishop();
            Rook r = new Rook();
            Queen q = new Queen();

            if(p.GetMoves(currentPawnPosition).Contains(wannaBePosition))
            {
                if (clickedP == 1)
                {
                    pawn1.Top = cbqY * 75 + 12;
                    clickedP = 0;
                }
            }

            if(k.GetMoves(currentKnightPosition).Contains(wannaBePosition))
            {
                if (clickedK == 1)
                {
                    knight.Top = cbqY * 75 + 12;
                    knight.Left = cbqX * 75 + 12;
                    clickedK = 0;
                }
            }

            if (b.GetMoves(currentBishopPosition).Contains(wannaBePosition))
            {
                if (clickedB == 1)
                {
                    bishop.Top = cbqY * 75 + 12;
                    bishop.Left = cbqX * 75 + 12;
                    clickedB = 0;
                }
            }

            if (r.GetMoves(currentRookPosition).Contains(wannaBePosition))
            {
                if (clickedR == 1)
                {
                    rook.Top = cbqY * 75 + 12;
                    rook.Left = cbqX * 75 + 12;
                    clickedR = 0;
                }
            }

            if (q.GetMoves(currentQueenPosition).Contains(wannaBePosition))
            {
                if (clickedQ == 1)
                {
                    queen.Top = cbqY * 75 + 12;
                    queen.Left = cbqX * 75 + 12;
                    clickedQ = 0;
                }
            }

            //MessageBox.Show("X: " + cbqX + " Y:" + cbqY);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pawn1.Top -= 75;
                    break;
                case Keys.A:
                    pawn1.Left -= 75;
                    break;
                case Keys.D:
                    pawn1.Left += 75;
                    break;
                case Keys.S:
                    pawn1.Top += 75;
                    break;
            }
        }

        private void bishop_Click(object sender, EventArgs e)
        {
            clickedB = 1;
        }

        private void knight_Click(object sender, EventArgs e)
        {
            clickedK = 1;
        }

        private void rook_Click(object sender, EventArgs e)
        {
            clickedR = 1;
        }

        private void queen_Click(object sender, EventArgs e)
        {
            clickedQ = 1;
        }

        private void pawn1_Click(object sender, EventArgs e)
        {
            clickedP = 1;
        }
    }
}

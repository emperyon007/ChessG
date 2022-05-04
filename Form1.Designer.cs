
namespace ChessG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chessBoard = new System.Windows.Forms.PictureBox();
            this.pawn1 = new System.Windows.Forms.PictureBox();
            this.knight = new System.Windows.Forms.PictureBox();
            this.bishop = new System.Windows.Forms.PictureBox();
            this.rook = new System.Windows.Forms.PictureBox();
            this.queen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen)).BeginInit();
            this.SuspendLayout();
            // 
            // chessBoard
            // 
            this.chessBoard.Image = ((System.Drawing.Image)(resources.GetObject("chessBoard.Image")));
            this.chessBoard.Location = new System.Drawing.Point(12, 12);
            this.chessBoard.Name = "chessBoard";
            this.chessBoard.Size = new System.Drawing.Size(600, 600);
            this.chessBoard.TabIndex = 0;
            this.chessBoard.TabStop = false;
            this.chessBoard.Click += new System.EventHandler(this.chessBoard_Click);
            // 
            // pawn1
            // 
            this.pawn1.BackColor = System.Drawing.Color.Transparent;
            this.pawn1.Image = ((System.Drawing.Image)(resources.GetObject("pawn1.Image")));
            this.pawn1.Location = new System.Drawing.Point(12, 462);
            this.pawn1.Margin = new System.Windows.Forms.Padding(0);
            this.pawn1.Name = "pawn1";
            this.pawn1.Size = new System.Drawing.Size(75, 75);
            this.pawn1.TabIndex = 1;
            this.pawn1.TabStop = false;
            this.pawn1.Click += new System.EventHandler(this.pawn1_Click);
            // 
            // knight
            // 
            this.knight.Image = ((System.Drawing.Image)(resources.GetObject("knight.Image")));
            this.knight.Location = new System.Drawing.Point(87, 537);
            this.knight.Margin = new System.Windows.Forms.Padding(0);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(75, 75);
            this.knight.TabIndex = 2;
            this.knight.TabStop = false;
            this.knight.Click += new System.EventHandler(this.knight_Click);
            // 
            // bishop
            // 
            this.bishop.Image = ((System.Drawing.Image)(resources.GetObject("bishop.Image")));
            this.bishop.Location = new System.Drawing.Point(162, 537);
            this.bishop.Margin = new System.Windows.Forms.Padding(0);
            this.bishop.Name = "bishop";
            this.bishop.Size = new System.Drawing.Size(75, 75);
            this.bishop.TabIndex = 3;
            this.bishop.TabStop = false;
            this.bishop.Click += new System.EventHandler(this.bishop_Click);
            // 
            // rook
            // 
            this.rook.Image = ((System.Drawing.Image)(resources.GetObject("rook.Image")));
            this.rook.Location = new System.Drawing.Point(12, 537);
            this.rook.Margin = new System.Windows.Forms.Padding(0);
            this.rook.Name = "rook";
            this.rook.Size = new System.Drawing.Size(75, 75);
            this.rook.TabIndex = 4;
            this.rook.TabStop = false;
            this.rook.Click += new System.EventHandler(this.rook_Click);
            // 
            // queen
            // 
            this.queen.Image = ((System.Drawing.Image)(resources.GetObject("queen.Image")));
            this.queen.Location = new System.Drawing.Point(237, 537);
            this.queen.Margin = new System.Windows.Forms.Padding(0);
            this.queen.Name = "queen";
            this.queen.Size = new System.Drawing.Size(75, 75);
            this.queen.TabIndex = 5;
            this.queen.TabStop = false;
            this.queen.Click += new System.EventHandler(this.queen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 635);
            this.Controls.Add(this.queen);
            this.Controls.Add(this.rook);
            this.Controls.Add(this.bishop);
            this.Controls.Add(this.knight);
            this.Controls.Add(this.pawn1);
            this.Controls.Add(this.chessBoard);
            this.Name = "Form1";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chessBoard;
        private System.Windows.Forms.PictureBox pawn1;
        private System.Windows.Forms.PictureBox knight;
        private System.Windows.Forms.PictureBox bishop;
        private System.Windows.Forms.PictureBox rook;
        private System.Windows.Forms.PictureBox queen;
    }
}


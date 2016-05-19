namespace RockPaperScissors
{
    partial class frmPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblStartOver = new System.Windows.Forms.Button();
            this.lblPcScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picPc = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScoreKeeper = new System.Windows.Forms.Label();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(67, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 3;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vs. ";
            // 
            // lblPC
            // 
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.Location = new System.Drawing.Point(415, 195);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(100, 23);
            this.lblPC.TabIndex = 5;
            this.lblPC.Text = "PC";
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserScore
            // 
            this.lblUserScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(173, 256);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(68, 23);
            this.lblUserScore.TabIndex = 6;
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 374);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "&Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblStartOver
            // 
            this.lblStartOver.Location = new System.Drawing.Point(495, 345);
            this.lblStartOver.Name = "lblStartOver";
            this.lblStartOver.Size = new System.Drawing.Size(75, 23);
            this.lblStartOver.TabIndex = 9;
            this.lblStartOver.Text = "&Start Over";
            this.lblStartOver.UseVisualStyleBackColor = true;
            this.lblStartOver.Click += new System.EventHandler(this.lblStartOver_Click);
            // 
            // lblPcScore
            // 
            this.lblPcScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPcScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcScore.Location = new System.Drawing.Point(342, 256);
            this.lblPcScore.Name = "lblPcScore";
            this.lblPcScore.Size = new System.Drawing.Size(68, 23);
            this.lblPcScore.TabIndex = 10;
            this.lblPcScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Score:";
            // 
            // picPc
            // 
            this.picPc.Location = new System.Drawing.Point(416, 222);
            this.picPc.Name = "picPc";
            this.picPc.Size = new System.Drawing.Size(100, 85);
            this.picPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPc.TabIndex = 2;
            this.picPc.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(67, 222);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 85);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissors.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblScoreKeeper
            // 
            this.lblScoreKeeper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreKeeper.Location = new System.Drawing.Point(218, 318);
            this.lblScoreKeeper.Name = "lblScoreKeeper";
            this.lblScoreKeeper.Size = new System.Drawing.Size(147, 23);
            this.lblScoreKeeper.TabIndex = 13;
            // 
            // picPaper
            // 
            this.picPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPaper.Image = global::RockPaperScissors.Properties.Resources.paper1;
            this.picPaper.Location = new System.Drawing.Point(67, 137);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(64, 55);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 14;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picRock
            // 
            this.picRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRock.Image = global::RockPaperScissors.Properties.Resources.rock1;
            this.picRock.Location = new System.Drawing.Point(207, 137);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(64, 55);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 15;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picScissor
            // 
            this.picScissor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picScissor.Image = global::RockPaperScissors.Properties.Resources.scissor1;
            this.picScissor.Location = new System.Drawing.Point(137, 137);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(64, 55);
            this.picScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissor.TabIndex = 16;
            this.picScissor.TabStop = false;
            this.picScissor.Click += new System.EventHandler(this.picScissor_Click);
            // 
            // frmPlay
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 409);
            this.Controls.Add(this.picScissor);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.lblScoreKeeper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPcScore);
            this.Controls.Add(this.lblStartOver);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPc);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button lblStartOver;
        private System.Windows.Forms.Label lblPcScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScoreKeeper;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissor;
    }
}
//karim
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmPlay : Form
    {
        int x = 0;
        int y = 0;
        Random rnd = new Random();
        public frmPlay(String userName)
        {
            InitializeComponent();
            lblName.Text = userName;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int player2 = rnd.Next(0, 4);

            if (picUser.Image == null)
            {
                MessageBox.Show("Please select Rock, Paper, or Scissors");

            }
            else
            {

                switch (player2)
                {
                    case 1:
                        picPc.Image = Properties.Resources.paper2;
                        break;
                    case 2:
                        picPc.Image = Properties.Resources.rock2;
                        break;
                    case 3:
                        picPc.Image = Properties.Resources.scissor2;
                        break;

                }

                if (picUser.Image == picPaper.Image && player2 == 1 || picUser.Image == picRock.Image && player2 == 2 || picUser.Image == picScissor.Image && player2 == 3)
                {
                    lblScoreKeeper.Text = "Tie";
                }
                if (picUser.Image == picPaper.Image && player2 == 2 || picUser.Image == picScissor.Image && player2 == 1 || picUser.Image == picRock.Image && player2 == 3)
                {
                    ++x;
                    lblUserScore.Text = x.ToString();
                    lblScoreKeeper.Text = lblName.Text + " Won";
                }
                if (picUser.Image == picPaper.Image && player2 == 3 || picUser.Image == picRock.Image && player2 == 1 || picUser.Image == picScissor.Image && player2 == 2)
                {
                    ++y;
                    lblPcScore.Text = y.ToString();
                    lblScoreKeeper.Text = "PC Won";
                }
            }
        
      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            picUser.Image = picPaper.Image;
        }

        private void picScissor_Click(object sender, EventArgs e)
        {
            picUser.Image = picScissor.Image;
        }

        private void picRock_Click(object sender, EventArgs e)
        {
            picUser.Image = picRock.Image;

            
        }

        private void lblStartOver_Click(object sender, EventArgs e)
        {
            int userScore, pcScore, winner=0;
            string winnerMsg;

            int.TryParse(lblUserScore.Text, out userScore);
            int.TryParse(lblPcScore.Text, out pcScore);

            if(userScore > pcScore)
            {
                userScore = winner;
                winnerMsg = lblName.Text +"\nYou Won, Game is being restarted";
            }
            else if(userScore < pcScore)
            {
                pcScore = winner;
                winnerMsg = "You Lost, Good luck on your next game\nGame is being restarted";
            }
            else
            {
                winnerMsg = "That was a tie,\nGame is being restarted";
            }

            lblUserScore.Text = "";
            lblPcScore.Text = "";
            picUser.Image = null;
            picPc.Image = null;
            lblScoreKeeper.Text = "";
            MessageBox.Show(winnerMsg.ToString(), "Start Over");

        }
    }
}

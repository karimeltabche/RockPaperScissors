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
    public partial class frmRockPaperScissors : Form
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmPlay frm2 = new frmPlay(txtName.Text);
            frmRockPaperScissors frm1 = new frmRockPaperScissors();

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name!!", "Invalid Entry");
            }
            else
            {
                this.Hide();
                frm2.ShowDialog();
                this.Close();
                
            }
            

            
        }

    }
}

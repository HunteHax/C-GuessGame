using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE3_new
{

    public partial class Form1 : Form
    {

        Random r = new Random();
        int secret;
        int guessCnt = 0;

        public Form1()
        {
            InitializeComponent();


            this.AcceptButton = btnGuess;
            this.CancelButton = btnReset;


            secret = r.Next(0, 100);
        }
        
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess;


            guess = Convert.ToInt32(tbGuess.Text);


            guessCnt += 1;

            lblNumberOfTries.Text = "Guess Count: " + guessCnt;


            if (guess < secret)
            {

                lblResult.Text = guess + " is too low";


                this.BackColor = System.Drawing.Color.Orange;
            }
            else if (guess > secret)
            {

                lblResult.Text = guess + " is too high";


                this.BackColor = System.Drawing.Color.Green;
            }
            else
            {

                lblResult.Text = " You got the right number... You Won! ";


                this.BackColor = System.Drawing.Color.Gold;
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            tbGuess.Text = "";
            guessCnt = 0;
            this.BackColor = System.Drawing.Color.Purple;


            secret = r.Next(0, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

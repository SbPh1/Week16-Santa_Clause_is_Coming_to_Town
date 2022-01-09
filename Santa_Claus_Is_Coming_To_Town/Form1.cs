using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Claus_Is_Coming_To_Town
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int obsticleSpeed = 6;
        int score = 0;
        int backroundSpeed = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santaClaus.Top += gravity;
            snowFlake.Left -= obsticleSpeed;
            tree.Left -= obsticleSpeed;
            moon.Left -= backroundSpeed;
            hut.Left -= backroundSpeed;
            scoreLabel.Text = $"score: {score}";

            if (snowFlake.Left < -100)
            {
                snowFlake.Left = 700;
                score++;
            }
            if (tree.Left < -100)
            {
                tree.Left = 600;
                score++;
            }
            if (moon.Left < -100)
            {
                moon.Left = 800;
            }
            if (hut.Left < -100)
            {
                hut.Left = 600;
            }
            if (santaClaus.Top < -25)
            {
                gameOver();
            }
            if (santaClaus.Bounds.IntersectsWith(snowFlake.Bounds) || santaClaus.Bounds.IntersectsWith(tree.Bounds) || santaClaus.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over!";
            playAgain.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hut_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

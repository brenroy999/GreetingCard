using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = this.CreateGraphics();
            Pen starLines = new Pen(Color.AntiqueWhite);
            SolidBrush starBrush = new SolidBrush(Color.AntiqueWhite); //Brush used for Stars
            Font titleFont = new Font("Times New Roman", 18, FontStyle.Bold);
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.song905);
            SoundPlayer lineSound = new SoundPlayer(Properties.Resources.song936);
            SoundPlayer titleSound = new SoundPlayer(Properties.Resources.gong___sound_effect);


            g.FillEllipse(starBrush, 100, 100, 20, 20); //Star One
            starSound.Play();
            Thread.Sleep(1000); //Time before next star is drawn

            g.FillEllipse(starBrush, 400, 200, 27, 27); //Star Two
            starSound.Play();
            Thread.Sleep(1000);

            g.FillEllipse(starBrush, 510, 270, 23, 23); //Star Three
            starSound.Play();
            Thread.Sleep(1000);

            g.FillEllipse(starBrush, 540, 330, 20, 20); //Star Four
            starSound.Play();
            Thread.Sleep(1000);

            g.DrawLine(starLines, 130, 118, 390, 205); //Line from 1 to 2
            lineSound.Play();
            Thread.Sleep(1000);

            g.DrawLine(starLines, 435, 225, 505, 270); //Line from 2 to 3
            lineSound.Play();
            Thread.Sleep(1000);

            g.DrawLine(starLines, 532, 298, 544, 324);
            lineSound.Play();
            Thread.Sleep(2000);

            titleSound.Play();
            Thread.Sleep(500);
            g.DrawString("ARIES", titleFont, starBrush, 350, 30);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
    }
}

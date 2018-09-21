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
/// Aries Zodiac Card by Brendon Roy
/// Last Update September 21st 2018
/// </summary>

namespace GreetingCard
{
    public partial class TedCruz : Form
    {
        public TedCruz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Inner Page
            Refresh(); //Reset on click
            Graphics g = this.CreateGraphics(); //Create graphics
            Pen starLines = new Pen(Color.AntiqueWhite); //Define pen
            SolidBrush starBrush = new SolidBrush(Color.AntiqueWhite); //Brush used for Stars
            Font titleFont = new Font("Times New Roman", 18, FontStyle.Bold); //Define fonts
            Font descFont = new Font("Arial", 14, FontStyle.Bold); //Define Font
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.song905); //Define sounds
            SoundPlayer lineSound = new SoundPlayer(Properties.Resources.song936);
            SoundPlayer dingSound = new SoundPlayer(Properties.Resources.Ding_Sound_Effect);
            SoundPlayer titleSound = new SoundPlayer(Properties.Resources.gong___sound_effect);


            g.FillEllipse(starBrush, 100, 100, 20, 20); //Star One
            starSound.Play(); //Play sound
            Thread.Sleep(1000); //Time before next star is drawn

            g.FillEllipse(starBrush, 400, 200, 27, 27); //Star Two
            starSound.Play(); //Play sound
            Thread.Sleep(1000); //Sleep

            g.FillEllipse(starBrush, 510, 270, 23, 23); //Star Three
            starSound.Play(); //Play sound
            Thread.Sleep(1000); //Sleep

            g.FillEllipse(starBrush, 540, 330, 20, 20); //Star Four
            starSound.Play(); //Play sound
            Thread.Sleep(1000); //Sheep

            g.DrawLine(starLines, 130, 118, 390, 205); //Line from 1 to 2
            lineSound.Play(); //Play sound
            Thread.Sleep(1000); //Sleep

            g.DrawLine(starLines, 435, 225, 505, 270); //Line from 2 to 3
            lineSound.Play(); //Play sound
            Thread.Sleep(1000); //Sleep

            g.DrawLine(starLines, 532, 298, 544, 324); //Line from 3 to 4
            lineSound.Play(); //Play sound
            Thread.Sleep(2000); //Sleep

            //Aries Title
            titleSound.Play(); //Play sound
            Thread.Sleep(500); //Sleep
            g.DrawString("ARIES", titleFont, starBrush, 370, 30); //Title

            Thread.Sleep(3000); //Sleep

            //Description
            dingSound.Play(); //Play Sound
            g.DrawString("Aries is known to be completely adventurous; " + //Description text
                "\nthey love new things and to seek new thrills in life. " +
                "\nThey never want to be stagnant; " +
                "\nthey always want to be on the go.", descFont, starBrush, 10, 340);
        } 

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Front Page
            Graphics g = this.CreateGraphics(); //Create graphics
            SolidBrush frontBrush = new SolidBrush(Color.Gray); //Define brushes
            SolidBrush royBrush = new SolidBrush(Color.DarkGoldenrod);
            Font frontFont = new Font("Times New Roman", 18, FontStyle.Bold); //Define font
            g.DrawString("ARIES", frontFont, frontBrush, 370, 80); //Create titles
            g.DrawString("By; Brendon Roy", frontFont, royBrush, 330, 130);

        }
    }
}

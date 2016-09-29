
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

namespace zodiacFinalProjectCamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //disposing title components
            title.Dispose();
            prompt.Dispose();
            ram.Dispose();


            //declaring variables and creating objects
            int txthtplc = 10;
            int[] strx = new int[4] { 60, 300, 385, 400 };
            int[] stry = new int[4] { 190, 240, 285, 320 };
            string[] words = new string[5] { "Aries is one of the constellations of the zodiac. It is located in the northern celestial hemisphere", "between Pisces to the west and Taurus to the east. The name Aries is Latin for ram, and its symbol is", " ♈, representing a ram's horns. It is one of the 48 constellations described by the", "2nd century astronomer Ptolemy, and remains one of the 88 modern constellations. It is a mid-sized", "constellation, ranking 39th overall size, with an area of 441 square degrees (1.1% of the celestial sphere)." };
            Graphics Print = this.CreateGraphics();
            Font printFont = new Font("Verdana", 9, FontStyle.Regular);
            Font logoFont = new Font("Georgia", 30, FontStyle.Bold);
            SolidBrush printBrush = new SolidBrush(Color.White);
            SolidBrush logoBrush = new SolidBrush(Color.Red);
            Pen linePen = new Pen(Color.FromArgb(255,0,255,0), 5);
            Pen starPen = new Pen(Color.Orange, 5);
            Pen notCoolStarPen = new Pen(Color.FromArgb(255, 255, 255, 51), 2);
            Print.Clear(Color.Black);
            SoundPlayer boom = new SoundPlayer(Properties.Resources.boom);
            SoundPlayer fog = new SoundPlayer(Properties.Resources.foghorn);
            SoundPlayer cycle = new SoundPlayer(Properties.Resources.UFOcycle);
            SoundPlayer boop = new SoundPlayer(Properties.Resources.boop);
            SoundPlayer lazer = new SoundPlayer(Properties.Resources.lazer);
            //random star background
            Random randGen = new Random();
            int xVal = 0;
            int yVal = 0;

            fog.Play();
            Print.DrawString("a Central Skywalk Program", logoFont, logoBrush, 40, 80);
            Thread.Sleep(4000);
            Print.Clear(Color.Black);
            cycle.Play();
            Thread.Sleep(500);
            for (int s = 0; s < 100; s++)
            {
                xVal = randGen.Next(1, 700);
                yVal = randGen.Next(100, 500);
                Print.DrawEllipse(notCoolStarPen, xVal, yVal, 5, 5);
                Thread.Sleep(25);
            }
            boom.Play();
            //proper star placement
            for (int i = 0; i < 4; i++)
            {
                Print.DrawEllipse(starPen, strx[i], stry[i], 5, 5);
                Thread.Sleep(1000);
            }
            //text printing
            boop.Play();
            for (int i = 0; i < 5; i++)
            {
                Print.DrawString(words[i], printFont, printBrush, 10, txthtplc);
                txthtplc = txthtplc + 15;
                Thread.Sleep(1500);
            }
            //line drawing
            for (int i = 0; i < 3; i++)
            {
                lazer.Play();
                Print.DrawLine(linePen, strx[i], stry[i], strx[i + 1], stry[i + 1]);
                Print.DrawEllipse(starPen, strx[i], stry[i], 5, 5);
                Print.DrawEllipse(starPen, strx[i + 1], stry[i + 1], 5, 5);
                Thread.Sleep(1000);
            }
        }
    }
}
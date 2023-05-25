using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCircles
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public static Random Random { get; set; }

        public Form1()
        {
            InitializeComponent();
            Scene=new Scene(this.Width, this.Height);
            Random = new Random();
            timer1.Interval = 100;
            timer2.Interval = 6000;
            DoubleBuffered = true;
            UpdateStatusLabel();

        }
        private void AddRandomCircles()
        {
            for(int i = 0; i < 3; i++)
            {
                Scene.List0fCircles.Add(new Circle(Random.Next(20,70),new Point(Random.Next(10,this.Width-100), Random.Next(10, this.Height - 100))));

            }
            Invalidate();
        }

       

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.isHit(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawCircles(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Start")
            {
                startToolStripMenuItem.Text = "Stop";
                timer1.Start();
            }
            else
            {
                startToolStripMenuItem.Text = "Start";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveCircles();
            UpdateStatusLabel();
            Invalidate();
        }
        private void UpdateStatusLabel()
        {
            toolStripStatusLabel1.Text = $"Вкупно поени: {Scene.Score}";
        }

        private void startGeneratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(startGeneratingToolStripMenuItem.Text=="Start Generating")
            {
                startGeneratingToolStripMenuItem.Text = "Stop Generating";
                timer2.Start();
            }
            else
            {
                startGeneratingToolStripMenuItem.Text = "Start Generating";
                timer2.Stop();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            AddRandomCircles();
        }
    }
}

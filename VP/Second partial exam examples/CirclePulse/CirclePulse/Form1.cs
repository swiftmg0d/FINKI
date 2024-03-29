﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirclePulse
{
    [Serializable]
    public partial class Form1 : Form
    {
        private Scene Scene { get; set; }
        public static Random Random { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Height, this.Width);
            DoubleBuffered = true;
            timer1.Interval = 100;
            timer2.Interval = 100;
            Random = new Random();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.List0fCircles.Add(new Circle(Random.Next(20, 41), e.Location, Random.Next(0, 4),Random.Next(0,2)));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawCircles(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Start moving")
            {
                startToolStripMenuItem.Text = "Stop moving";
                timer1.Start();
            }
            else
            {
                startToolStripMenuItem.Text = "Start moving";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveCircles();
            Scene.CheckHit();
            Invalidate();
        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {
            Scene.PulseCircles();
            Invalidate();
        }

        private void startPulsingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(startPulsingToolStripMenuItem.Text=="Start pulsing")
            {
                startPulsingToolStripMenuItem.Text = "Stop pulsing";
                timer2.Start();
            }
            else
            {
                startPulsingToolStripMenuItem.Text = "Start pulsing";
                timer2.Stop();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(dialog.FileName, FileMode.OpenOrCreate);
                IFormatter formater = new BinaryFormatter();
                formater.Serialize(file, Scene);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(dialog.FileName, FileMode.Open);
                IFormatter formater = new BinaryFormatter();
                Scene=(Scene)formater.Deserialize(file);
                Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(this.Height,this.Width);
            Invalidate();
        }
    }
}

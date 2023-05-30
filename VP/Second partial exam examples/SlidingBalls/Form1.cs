using System;
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

namespace SlidingBalls
{
    [Serializable]

    public partial class Form1 : Form
    {
        public static Random Random { get; set; }
        public Scene Scene { get; set; }
        public bool CanMake { get; set; }
        

        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(Height,Width);
            Random=new Random();
            DoubleBuffered = true;
            timer1.Interval = 100;
            CanMake=true;
            UpdateStatus();
        }
        private void UpdateStatus()
        {
            toolStripStatusLabel1.Text = $"Вкупно топчиња: {Scene.List0fCircles.Count()}";
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawCircles(e.Graphics);
            UpdateStatus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Scene.canMake)
            {
                if (Scene.isHit(e.Location))
                {
                    timer1.Start();
                    Scene.canMake = false;
                }
                else
                {
                    Scene.List0fCircles.Add(new Circle(30, e.Location, Color.Red, Random.Next(0, 4)));
                }
                Invalidate();
               
            }
           
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Random.Next(0, 2) == 0)
            {
                Scene.List0fCircles.Add(new Circle(30, e.Location, Color.Green, Random.Next(0, 4)));

            }
            else
            {
                Scene.List0fCircles.Add(new Circle(30, e.Location, Color.Blue, Random.Next(0, 4)));

            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveCircle();
            Scene.Stacked();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file=new FileStream(saveFileDialog.FileName,FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, Scene);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openFileDialog.FileName,FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(file);
                Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(Height, Width);
            Invalidate();
        }
    }
}

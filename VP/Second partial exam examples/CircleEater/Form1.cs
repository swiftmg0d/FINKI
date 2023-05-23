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

namespace CirlcesEater
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public static Random Random { get; set; }
        public bool CanMove { get; set; }
        public bool CanMake { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene=new Scene(this.Height,this.Width);
            Random=new Random();
            DoubleBuffered = true;
            timer2.Interval = 2000;
            timer2.Start();
            timer1.Start();
            CanMove = false;
            CanMake = true;
            for(int i = 0; i < 3; i++)
            {
                Scene.List0fCircles.Add(new Circle(15,new Point(Random.Next(30,this.Width-30),Random.Next(30,this.Height-30)),Color.Red,Random.Next(0,4)));    
            }
            Invalidate();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (CanMake)
            {
                Scene.CurrentCircle = new Circle(25, e.Location, Color.Black, 0);
                Invalidate();
                CanMove = true;
                CanMake = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawCircles(e.Graphics);
            if(Scene.CurrentCircle!=null) Scene.CurrentCircle.DrawCircle(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanMove)
            {
                Scene.CurrentCircle.Center = e.Location;
                Scene.isNear();
                if (Scene.CurrentCircle.IsEaten)
                {
                    Scene.CurrentCircle = null;
                    CanMove = false;
                    CanMake = true;
                }
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveCircles();

            Invalidate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Stop")
            {
                startToolStripMenuItem.Text = "Start";
                timer1.Stop();
            }
            else
            {
                startToolStripMenuItem.Text = "Stop";

                timer1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Scene.List0fCircles.Add(new Circle(15, new Point(Random.Next(30, this.Width - 30), Random.Next(30, this.Height - 30)), Color.Red, Random.Next(0, 4)));
            }
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                IFormatter formater = new BinaryFormatter();
                formater.Serialize(file, Scene);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file=new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
               Scene=(Scene)formatter.Deserialize(file);
                Invalidate();
            }
        }
    }
}

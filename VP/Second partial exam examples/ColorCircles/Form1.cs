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

namespace ColorCircles
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public Color Color { get; set; }
        public Point CurrentPoint { get; set; }
        public Boolean CanShow { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            Color = Color.Red;
            CurrentPoint = Point.Empty;
            CanShow = false;
            DoubleBuffered = true;
            toolStripStatusLabel1.Text = "Вкупно топчиња: 0";
        }
        private void UpdateStatusStrip()
        {
            toolStripStatusLabel1.Text = $"Вкупно топчиња: {Scene.List0fCircles.Count}";

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (Scene.IsNear(e.Location))
            {
                Invalidate();
            }
            else
            {
                if (CurrentPoint == Point.Empty)
                {
                    CurrentPoint = e.Location;
                    Scene.CurrentCircle.Center = CurrentPoint;
                    CanShow = true;
                }
                else
                {
                    Scene.List0fCircles.Add(new Circle(Scene.CurrentCircle.Center, Scene.CurrentCircle.Radius, Color));
                    UpdateStatusStrip();    
                    Scene.CurrentCircle = new Circle();
                    CanShow = false;
                    CurrentPoint = Point.Empty;
                    Invalidate();
                }
            }
            
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawCircles(e.Graphics);
            Scene.CurrentCircle.DrawShape(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(CanShow)
            {
                int Radius = (int)Math.Sqrt(Math.Pow((e.X - Scene.CurrentCircle.Center.X), 2) + Math.Pow((e.Y - Scene.CurrentCircle.Center.Y), 2));
                Scene.CurrentCircle.Radius = Radius;
                Invalidate();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Back)
            {
                Scene = new Scene();
                Color = Color.Red;
                CurrentPoint = Point.Empty;
                CanShow = false;
                DoubleBuffered = true;
                Invalidate();
                UpdateStatusStrip();

            }
            if (e.KeyChar == (Char)Keys.Escape)
            {
                if (CanShow)
                {
                    Scene.CurrentCircle=new Circle();
                    CurrentPoint= Point.Empty;
                    Invalidate();
                    CanShow= false;
                }
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog=new SaveFileDialog();
            saveFileDialog.Title = "Save the scene";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);

                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, Scene);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog=new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file=new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter=new BinaryFormatter();
                Scene=(Scene)formatter.Deserialize(file);
                Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

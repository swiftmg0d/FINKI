using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePulse
{
    [Serializable]
    public class Scene
    {
        public List<Circle> List0fCircles { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Scene(int height,int width)
        {
            Height = height;
            Width = width;
            List0fCircles = new List<Circle>();
        }
        public void DrawCircles(Graphics e)
        {
            List0fCircles.ForEach(i => { i.Draw(e); });
        }

        internal void MoveCircles()
        {
            List0fCircles.ForEach(i => { i.Move(Height,Width); });
        }

        internal void PulseCircles()
        {
            List0fCircles.ForEach(i => { i.Pulse(); });
        }
        private int Distance(Point p1,Point p2)
        {
            return (int)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
       
        internal void CheckHit()
        {
            List<Circle> newList = new List<Circle>();

            foreach (Circle c in List0fCircles)
            {
                foreach(Circle c1 in List0fCircles)
                {
                    if (c.Equals(c1)) { continue; }
                    if(!c.isCollided && !c1.isCollided)
                    {
                        if (Distance(c.Center, c1.Center) <= c.Radius)
                        {
                            c.isCollided = true;
                            c1.isCollided = true;
                            newList.Add(new Circle((int)((c.Radius + c1.Radius) / 2.0), c.Center, Form1.Random.Next(0, 4), Form1.Random.Next(0, 2)));
                        }
                    }
                }
            }
            newList.ForEach(i =>
            {
                List0fCircles.Add(i);
            });
            
        }
    }
}

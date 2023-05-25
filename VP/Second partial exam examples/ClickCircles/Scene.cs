using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCircles
{
    public class Scene
    {
        public List<Circle> List0fCircles { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Score { get; set; }

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
            List0fCircles=new List<Circle>();
            Score = 0;
        }
        public void DrawCircles(Graphics g)
        {
            List0fCircles.ForEach(c => {c.DrawCircle(g);});
        }

        internal void MoveCircles()
        {
            List0fCircles.ForEach(c =>
            {
                c.Move(Width);
            });
            for (int i = List0fCircles.Count - 1; i >= 0; i--)
            {
                if (List0fCircles[i].IsGone)
                {
                    if (List0fCircles[i].HitCount == 0)
                    {
                        Score -= 5;
                    }else if (List0fCircles[i].HitCount == 1)
                    {
                        Score -= 3;
                    }
                    else
                    {
                        Score += 1;
                    }
                    List0fCircles.Remove(List0fCircles[i]);


                }
            }
        }
        public int getDistance(Point Start,Point End)
        {
            return (int)Math.Sqrt(Math.Pow((Start.X-End.X), 2) + Math.Pow((Start.Y-End.Y), 2)); 
        }
        internal void isHit(Point location)
        {
            List0fCircles.ForEach(c =>
            {
                if (getDistance(location, c.Center) < c.Radius)
                {
                    if (c.HitCount < 3)
                    {
                        c.HitCount++;
                    }
                }
            });

            for(int i= List0fCircles.Count -1; i >= 0; i--) {

                if (List0fCircles[i].HitCount == 3)
                {
                    Score += 20;
                    List0fCircles.Remove(List0fCircles[i]);
                }
            }
        }
    }
}

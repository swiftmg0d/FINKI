using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CirlcesEater
{
    [Serializable]
    public class Scene
    {
        public List<Circle> List0fCircles { get; set; }
        public Circle CurrentCircle { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Scene(int height, int width)
        {
            Height = height;
            Width = width;
            List0fCircles=new List<Circle>();
            CurrentCircle = new Circle();
        }

        public void DrawCircles(Graphics e)
        {
            List0fCircles.ForEach(c => { c.DrawCircle(e); });
        }

        internal void MoveCircles()
        {
            List0fCircles.ForEach(i =>
            {
                // 0 - RIGHT , 1 - LEFT, 2 - TOP, 3 - BOT

                if (i.Direction == 0)
                {
                    if (i.Center.X+15 <= Width)
                    {
                        i.Center=new Point(i.Center.X+15,i.Center.Y);
                    }
                    else
                    {
                        i.Direction = 1;
                    }

                }else if(i.Direction == 1)
                {
                    if (i.Center.X-15 >= 0)
                    {
                        i.Center = new Point(i.Center.X - 15, i.Center.Y);
                    }
                    else
                    {
                        i.Direction = 0;
                    }
                }
                else if (i.Direction == 2)
                {
                    if (i.Center.Y+15 <= Height)
                    {
                        i.Center = new Point(i.Center.X, i.Center.Y+15);
                    }
                    else
                    {
                        i.Direction = 3;
                    }
                }
                else
                {
                    if(i.Center.Y-15 >= 0)
                    {
                        i.Center = new Point(i.Center.X, i.Center.Y - 15);
                    }
                    else
                    {
                        i.Direction = 2;
                    }
                }




            });
        }

        internal void isNear()
        {
            List0fCircles.ForEach(i =>
            {
                int distance = (int)Math.Sqrt(Math.Pow((i.Center.X-CurrentCircle.Center.X), 2) + Math.Pow((i.Center.Y - CurrentCircle.Center.Y), 2));
                if (distance <= i.Radius) { i.IsEaten = true; CurrentCircle.Radius += 10; if (CurrentCircle.Radius > 70) { CurrentCircle.IsEaten =true; } }           
            });
            for(int i=List0fCircles.Count-1; i>=0; i--) {
                if (List0fCircles[i].IsEaten)
                {
                    List0fCircles.Remove(List0fCircles[i]);
                }
            }
            
        }
    }
}

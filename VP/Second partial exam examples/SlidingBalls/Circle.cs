using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Direction { get; set; }
        public bool isHit { get; set; }
        public bool isOut { get; set; }
        public bool isEaten { get; set; }

        public Circle(int radius, Point center, Color color, int direction)
        {
            Radius = radius;
            Center = center;
            Color = color;
            Direction = direction;
            isHit = false;
            isOut = false;
            isEaten = false;
        }
        public void DrawCircle(Graphics e) { e.FillEllipse(new SolidBrush(Color), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius); }
        public void Move(int Width,int Height)
        {
            if (Color == Color.Red)
            {
                if(isHit)
                {
                    if (Direction == 0)
                    {
                        if (Center.X <= Width)
                        {
                            Center = new Point(Center.X + 10, Center.Y);
                        }
                        else
                        {
                            isOut = true;
                        }

                    }
                    else if (Direction == 1)
                    {
                        if (Center.X > 0)
                        {
                            Center = new Point(Center.X - 10, Center.Y);
                        }
                        else
                        {
                            isOut = true;
                        }
                    }
                    else if (Direction == 2)
                    {
                        if (Center.Y <= Height)
                        {
                            Center = new Point(Center.X, Center.Y + 10);
                        }
                        else
                        {
                            isOut = true;
                        }
                    }
                    else if (Direction == 3)
                    {
                        if (Center.Y >= 0)
                        {
                            Center = new Point(Center.X, Center.Y - 10);
                        }
                        else
                        {
                            isOut = true;
                        }
                    }
                }
            }
        }
    
    }

}

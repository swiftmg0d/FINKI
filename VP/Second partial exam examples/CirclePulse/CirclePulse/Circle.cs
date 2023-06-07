using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePulse
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public bool isCollided { get; set; }
        public int Direction { get; set; }
        public int Value { get; set; }
        public Circle() { }
        public Circle(int raidus,Point center,int direction,int value)
        {
            Radius = raidus;
            Center = center;
            isCollided = false;
            Direction = direction;
            Value = value;
        }
        public void Draw(Graphics g)
        {
            if (!isCollided)
            {
                g.FillEllipse(new SolidBrush(Color.Red), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
        public void Move(int Height,int Width)
        {
            // 0 - RIGHT, 1 - LEFT, 2 - TOP, 3 - BOT
            if (Direction == 0)
            {
                if (Center.X + 10 <= Width)
                {
                    Center = new Point(Center.X + 10, Center.Y);
                }
                else
                {
                    Direction = 1;
                }
            }else if (Direction == 1)
            {
                if (Center.X - 10 >= 0)
                {
                    Center = new Point(Center.X - 10, Center.Y);
                }
                else
                {
                    Direction = 0;
                }
            }
            else if (Direction == 2)
            {
                if (Center.Y + 10 <= Height)
                {
                    Center = new Point(Center.X, Center.Y + 10);
                }
                else
                {
                    Direction = 3;
                }
            }
            else if (Direction == 3)
            {
                if (Center.Y - 10 >= 0)
                {
                    Center = new Point(Center.X, Center.Y - 10);
                }
                else
                {
                    Direction = 2;
                }
            }


        }

        internal void Pulse()
        {
            if (Value == 1)
            {
                if (Radius + 5 <= 100)
                {
                    Radius += 5;
                }
                else
                {
                    Value = 0;
                }
            }
            else
            {
                if (Radius - 5 >= 0)
                {
                    Radius -= 5;
                }
                else
                {
                    Value = 1;
                }
            }
            
        }
    }
}

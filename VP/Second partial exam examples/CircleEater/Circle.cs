using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirlcesEater
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool IsEaten { get; set; }
        public int Direction  { get; set; }
        public Circle() { IsEaten = false; }
        public Circle(int radius, Point center, Color color,int direction)
        {
            // 0 - RIGHT , 1 - LEFT, 2 - TOP, 3 - BOT
            Radius = radius;
            Center = center;
            Color = color;
            Direction = direction;  
        }
        public void DrawCircle(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }
        
    }
}

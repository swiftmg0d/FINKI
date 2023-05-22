using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public Boolean IsHit { get; set; }
        public Circle() { IsHit = false; ; }

        public Circle(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
            IsHit = false;
        }

        public void DrawBrush(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Center.X-Radius, Center.Y-Radius,2*Radius,2*Radius);   
        }
        public void DrawPen(Graphics g) { 
            g.DrawEllipse(new Pen(Color.Yellow,3),Center.X-Radius,Center.Y-Radius,2*Radius,2*Radius);
        }
        public void DrawShape(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Gray, 5), Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCircles
{
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public int HitCount { get; set; }
        public Color Color { get; set; }
        public Boolean IsGone { get; set; }
        public Circle() { HitCount = 0; }
        public Circle(int radius, Point center)
        {
            Radius = radius;
            Center = center;
            HitCount = 0;
            Color = Color.Red;
            IsGone = false;
        }
        public void DrawCircle(Graphics g)
        {
            if (HitCount == 1) { Color = Color.Yellow; }
            else if (HitCount == 2) {  Color = Color.Green; }
            g.FillEllipse(new SolidBrush(Color),Center.X-Radius,Center.Y-Radius,2*Radius,2*Radius); 
        }

        internal void Move(int width)
        {
            if (Center.X<=width)
            {
                Center=new Point(Center.X+10,Center.Y);
            }
            else
            {
                IsGone = true;
            }
        }
    }
}

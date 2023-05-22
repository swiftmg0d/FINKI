using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> List0fCircles { get; set; }
        public Circle CurrentCircle { get; set; }
        public Scene() {
            List0fCircles= new List<Circle>();
            CurrentCircle= new Circle();
        }
        public void DrawCircles(Graphics g)
        {
            List0fCircles.ForEach(c => { c.DrawBrush(g); if (c.IsHit) { c.DrawPen(g); } });
        }

        internal bool IsNear(Point location)
        {
                foreach(Circle i in List0fCircles){
                int Radius = (int)Math.Sqrt(Math.Pow((location.X - i.Center.X), 2) + Math.Pow((location.Y - i.Center.Y), 2));
                    if (Radius<=i.Radius)
                {
                    i.IsHit = !i.IsHit;
                    return true;
                }
                }
                
          
            return false;
        }
       
    }
}

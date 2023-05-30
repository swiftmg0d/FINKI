using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Scene
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Circle> List0fCircles { get; set; }
        public bool canMake { get; set; }

        public Scene(int height, int width)
        {
            Height = height;
            Width = width;
            List0fCircles=new List<Circle>();
            canMake = true;
        }
        public void DrawCircles(Graphics e)
        {
            List0fCircles.ForEach(c => { c.DrawCircle(e); });
        }
        public int GetDistance(Point x,Point y)
        {
            return (int)Math.Sqrt(Math.Pow((x.X-y.X),2)+ Math.Pow((x.Y - y.Y), 2));
        }
        internal bool isHit(Point location)
        {
            foreach(Circle c in List0fCircles)
            {
                if (GetDistance(location, c.Center) < c.Radius)
                {
                    c.isHit = !c.isHit;
                    return true;
                }
            }


            return false;
        }

        internal void MoveCircle()
        {
            List0fCircles.ForEach(c =>
            {
                c.Move(Width, Height);
            });
            for(int i=List0fCircles.Count-1; i>=0; i--)
            {
                if (List0fCircles[i].isOut)
                {
                    List0fCircles.Remove(List0fCircles[i]);
                    canMake = true;
                }
            } 
        }

        internal void Stacked()
        {
            foreach(Circle c in List0fCircles)
            {
                foreach(Circle k in List0fCircles)
                {
                    if (c.Equals(k)) continue;
                    
                    if(c.isHit)
                    {
                        if(GetDistance(c.Center, k.Center) < c.Radius)
                        {
                
                            if(k.Color == Color.Green) { k.isEaten= true; }
                           
                        }
                    }

                }
            }
            for (int i = List0fCircles.Count - 1; i >= 0; i--)
            {
                if (List0fCircles[i].isEaten)
                {
                    List0fCircles.Remove(List0fCircles[i]);
                    
                }
            }
        }
    }
}

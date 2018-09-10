using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Objects
    {

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = Y;
        }

   
    }
    class Shapes
    {
     public int point { get; set; }
    }

    abstract class shape
    {
        public abstract List<Point> CreatePoints();
    }

    class Quadrilateral : Shapes
    {
        protected List<Point> CreateBaseShape(int width, int height)
        {
            var list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, 4));
            list.Add(new Point(4, 4));
            list.Add(new Point(4, 0));

            return list;
        }

    }

    class Rectangle : Quadrilateral
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
        }

        public List<Point> createBaseShape(int width, int height)
        {
            var list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, Height));
            list.Add(new Point(Width, Height));
            list.Add(new Point(Width, 0));

            return list;
        }

    }




    class Square : Quadrilateral
    {
        public int Size { get; set; }

        public Square()
        {
        }

        public List<Point> createBaseShape(int size)
        {
            var list = new List<Point>();
            list.Add(new Point(0, 0));
            list.Add(new Point(0, Size));
            list.Add(new Point(Size, 0));

            return list;
        }
    }
}

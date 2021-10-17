using System;
using System.Collections;
using System.Collections.Generic;


namespace ДЗ1
{
    abstract class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        private double x;
        private double y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public abstract void Print();

        public virtual void Move(double dx, double dy)
        {
            this.X *= dx;
            this.Y *= dy;
        }

        public abstract void Scale(double temp);

    }

    class Circle : Point
    {
        public Circle(double x,double y, double r) : base(x,y)
        {
            this.R = r;
        }
        private double r;

        public double R { get => r; set => r = value; }

        public override void Scale(double temp)
        {
            this.R *= temp;
        }

        public override void Print()
        {
            Console.WriteLine($"Circle with center ({this.X};{this.Y}) and radius {this.R}");
        }
    }
    class Rectangle : Point
    {
       
        private double dx;
        private double dy;
        public double DX { get => dx; set => dx = value; }
        public double DY { get => dy; set => dy = value; }
        public Rectangle(double x, double y, double dx, double dy):base( x, y)
        {
            this.DX += dx;
            this.DY += dy;

        }

        public override void Scale(double temp)
        {

            this.DX *= temp;
            this.DY *= temp;
        }
        
        public override void Print()
        {
            Console.WriteLine($"Rectangle with dots in ({this.X};{this.Y}) , ({this.X + this.DX};{this.Y}) , " +
                $" ({this.X + this.DX};{this.Y + this.DY}) , ({this.X};{this.Y + this.DY})");
        }



    }
    class Triangle : Rectangle
    {
        private double dx2;
        private double dy2;
        public Triangle(double x, double y, double dx, double dy, double dx2, double dy2):base(x,y,dx,dy)
        {
          
            this.DX2 = dx2;
            this.DY2 = dy2;
        }
        public double DX2 { get => dx2; set => dx2 = value; }
        public double DY2 { get => dy2; set => dy2 = value; }

        public override void Scale(double temp)
        {
            base.Scale(temp);
            this.DX2 *= temp;
            this.DY2 *= temp;
        }
       

        public override void Print()
        {
            Console.WriteLine($"Triangle with dots ({this.X};{this.Y}) , ({this.X + this.DX};{this.Y + this.DY}) , " + 
                $"({this.X + this.DX2};{this.Y + this.DY2})");
        }
    }
    class Image : Rectangle
    {
        public Image() : base(0, 0, 0, 0)
        {
            this.list = new List<Point>();
        }
        List<Point> list;
        public void Add(Point p)
        {
            list.Add(p);
        }
        public override void Scale(double temp)
        {
            foreach(var l in list)
            {
                l.Scale(temp);
            }
            
        }
        public override void Print()
        {
           
            foreach (var l in list)
            {
                l.Print();
            }
            
    }
        public override void Move(double dx, double dy)
        {
            foreach (var l in list)
            {
                l.Move(dx,dy);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Triangle t = new Triangle(1,2,3,4,5,6);
            Rectangle r = new Rectangle(1, 2, 3, 4);
            Circle c = new Circle(1, 2, 3);
            Image i = new Image();
            i.Add(t);
            i.Add(r);
            i.Add(c);

            i.Print();
            Console.WriteLine("---------------");
            i.Move(1, 1);
            i.Print();
            Console.WriteLine("---------------");
            i.Scale(2);
            i.Print();
            Console.WriteLine("---------------");
            Console.ReadLine();




        }

    }
   
}

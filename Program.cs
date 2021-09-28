using System;

namespace ДЗ1
{
    class Program
    {
        
         abstract class Point
         {
          

            protected int X { get; set; }
        protected int Y { get; set; }
           

           
        public abstract void Show();

        public virtual void Move(int X_Move, int Y_Move) 
        {
            Console.WriteLine("Введите перемещение вдоль X");
            X_Move = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите перемещение вдоль Y");
            Y_Move = Convert.ToInt32(Console.ReadLine());
            X = X + X_Move;
            Y = Y + Y_Move;
            Console.WriteLine("Новые координаты Х " + X);

            Console.WriteLine("Новые координаты Y " + Y);
        }
        
        public abstract void Scale(int temp);
         }

         class Circle : Point
    {
        
        int R { get; set; }
      

        public override void Move(int X_Move, int Y_Move)
        {
                Console.WriteLine("Введите перемещение вдоль X");
                X_Move = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите перемещение вдоль Y");
                Y_Move = Convert.ToInt32(Console.ReadLine());
                X = X + X_Move;
                Y = Y + Y_Move;
                Console.WriteLine("Новые координаты Х " + X);

                Console.WriteLine("Новые координаты Y " + Y);
            }

        public override void Scale(int temp)
        {
            R *= temp;
        }

        public override void Show()
        {
        Console.WriteLine("Введите значение координаты X");
        X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение координаты Y");
        Y = Convert.ToInt32(Console.ReadLine());
        R = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"круг со следующими параметрами: ");
        }
    }
   class Rectangle : Point
    {
        Point pointrect;
        int DX ;
        int DY ;
            
        public int DX1 { get => DX; set => DX = value; }
        public int DY1 { get => DY; set => DY = value; }
        internal Point Pointrect { get => pointrect; set => pointrect = value; }

        public override void Scale(int temp)
        {

            DX *= temp;
            DY *= temp;
        }
        public override void Move(int X_Move,int Y_Move)
        {
            Console.WriteLine("Введите перемещение вдоль X");
            X_Move = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите перемещение вдоль Y");
            Y_Move = Convert.ToInt32(Console.ReadLine());
            X = X + X_Move;
            Y = Y + Y_Move;
            DX = DX + X_Move;
            DY = DY + Y_Move;
            Console.WriteLine("Новые координаты Х " + X);
            Console.WriteLine("Новые координаты DХ " + DX);
            Console.WriteLine("Новые координаты Y " + Y);
            Console.WriteLine("Новые координаты DY " + DY);
        }
        public override void Show()
        {
        Console.WriteLine("Введите значение координаты X");
        X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение координаты Y");
        Y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение координаты DX");
        DX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение координаты DY");
        DY = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"прямоугольник со следующими параметрами: "); 
        }


           
    }
   class Triangle : Rectangle
    {
        Point pointtriang;
        Rectangle recttriang;
         int DX2;
         int DY2;
        internal Point Pointtriang { get => pointtriang; set => pointtriang = value; }
        internal Rectangle Recttriang { get => recttriang; set => recttriang = value; }
        public int DX21 { get => DX2; set => DX2 = value; }
        public int DY21 { get => DY2; set => DY2 = value; }

        public override void Scale(int temp)
        {
            DX2 *= temp;
            DY2 *= temp;
        }
        public override void Move(int X_Move, int Y_Move)
        {
            Console.WriteLine("Введите перемещение вдоль X");
            X_Move = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите перемещение вдоль Y");
            Y_Move = Convert.ToInt32(Console.ReadLine());
            X = X + X_Move;
            Y = Y + Y_Move;
            DX1 = DX1 + X_Move;
            DY1 = DY1 + Y_Move;
            DX2 = DX2+ X_Move;
            DY2 = DY2 + Y_Move;
            Console.WriteLine("Новые координаты Х " + X);
            Console.WriteLine("Новые координаты DХ1 " + DX1);
            Console.WriteLine("Новые координаты DХ2 " + DX2);
            Console.WriteLine("Новые координаты Y " + Y);
            Console.WriteLine("Новые координаты DY1 " + DY1);
            Console.WriteLine("Новые координаты DY2 " + DY2);
        }

        public override void Show()
        {
            Console.WriteLine("Введите значение координаты X");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты Y");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты DX1");
            DX1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты DY1");
            DY1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты DX2");
            DX2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты DY2");
            DY2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"треугольник со следующими параметрами: {X},{Y} - {DX1}, {DY1}, -{DX2}, {DY2}");
        }
    }
        class Picture : Rectangle
        {
            static void Main(string[] args)
            {
                
                Circle circle = new Circle();
                circle.Move(1,1);
                circle.Scale(2);
                circle.Show();
                Rectangle rect = new Rectangle();
                rect.Show();
                rect.Scale(3);
                rect.Move(1, 1);
                Triangle tri = new Triangle();
                tri.Move(1,1);
                tri.Show();
                tri.Scale(1);






            }
        }
    }
   
}

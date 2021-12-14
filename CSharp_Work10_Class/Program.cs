using System;

namespace CSharp_Work10_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Square s = new Square(x1, y1, x2, y2);
            s.printLength();
            s.printArea();
            Qube q = new Qube(x1, y1, x2, y2);
            q.printLength();
            q.printQubeArea();
            q.printVolume();
            Console.ReadKey();
        }
    }

    abstract class Figure
    {
        protected string name = "Figure";
        protected double x1;
        protected double y1;
        protected double x2;
        protected double y2;

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        protected abstract double Area();

        protected abstract double Volume();

        protected virtual double Perimetr()
        {
            return 4 * Length();
        }

        protected double Length()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public void printLength()
        {
            Console.WriteLine("Длина стороны {0} = {1:f2}", name, Length());
        }

    }

    class Square : Figure
    {
        public Square() { }
        public Square(double x1i, double y1i, double x2i, double y2i)
        {
            name = "Square";
            X1 = x1i;
            Y1 = y1i;
            X2 = x2i;
            Y2 = y2i;
        }

        protected override double Area()
        {
            return Length() * Length();
        }

        public void printArea()
        {
            Console.WriteLine("Площадь {0} = {1:f2}", name, Area());
        }

        protected override double Volume()
        {
            throw new NotImplementedException();
        }
    }

    class Qube : Square
    {
        public Qube (double x1i, double y1i, double x2i, double y2i)
        {
            name = "Qube";
            X1 = x1i;
            Y1 = y1i;
            X2 = x2i;
            Y2 = y2i;
        }
        protected double qubeArea()
        {
            return 6 * Area();
        }
        public void printQubeArea()
        {
            Console.WriteLine("Площадь {0} = {1:f2}", name, qubeArea());
        }
        protected override double Volume()
        {
            return Length() * Length() * Length();
        }

        public void printVolume()
        {
            Console.WriteLine("Объем {0} = {1:f2}", name, Volume());
        }

        
    }

}

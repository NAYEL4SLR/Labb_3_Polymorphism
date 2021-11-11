using System;
namespace Labb_3_Polymorphism
{
    class Drawing
    {
        public virtual double Area() => 0;
        
        public virtual double Circumference() => 0;
    }
    class Rectangle : Drawing
    {
        private double Length { get; set; }
        private double Width { get; set; }
        private double Diagonal { get; set; }
        public Rectangle()
        {
            Length = 12;
            Width = 5;
            Diagonal = Math.Sqrt(Length * Length + Width * Width);
        }
        public override double Area() => Length * Width;
        public override double Circumference() => (Length + Width);
        public double ReturnDiagonal() => Diagonal;
        public override string ToString()
        {
            return $"\n  Rectangle's area (L = 12 & W = 5): {Area()}\n" +
                $"  Circumference : {Circumference()}\n" +
                $"  Diagonal : {ReturnDiagonal()}\n" +
                $"____________________________________________________________";
        }
    }
    class Square : Drawing
    {
        private double Side { get; set; }
        public Square()
        {
            Side = 4;
        }
        public override double Area() => Side * Side;
        public override double Circumference() => Side * 4;
        public override string ToString()
        {
            return $"\n  Square's area (side = 4): {Area()}\n" +
                $"  Circumference : {Circumference()}\n" +
                $"____________________________________________________________";
        }
    }
    class Circle : Drawing
    {
        private double Radius { get; set; }
        private double _pi = 3.141592653589793238;
        public Circle()
        {
            Radius = 4;
        }
        public override double Area() => Radius * Radius * _pi;
        public override double Circumference() =>  2 * _pi * Radius;
        public override string ToString()
        {
            return $"\n  Circle's area (r = 4): {Area():#.##}\n" +
                $"  Circumference : {Circumference():#.##}\n" +
                $"____________________________________________________________";
        }
    }
}
using System;
namespace LearnCSharp
{
    /// <summary>
    /// 继承 只支持 类和接口
    /// </summary>
    public class Inherit2
    {
        public void Fun()
        {
            Shape[] shapes =
            {
                new Circle(1,"shapes #1"),
                new Rectangle(2,3,"Rectangle #1")
            };
            foreach (Shape s in shapes)
            {

                Console.WriteLine(s);
            }
        }
    }

    public abstract class Shape
    {
        private string name;
        public Shape(string _id)
        {
            Id = _id;
        }
        public string Id
        {
            get { return name; }
            set { name = value; }
        }
        public abstract double Area
        {
            get;
        }
        public abstract void MakeArea();
        public override string ToString()
        {
            return Id + "Area = " + string.Format("{0:F2}", Area);
        }
    }
    public class Circle : Shape
    {
        double length;
        public Circle(double l, string _id) : base(_id)
        {
            this.length = l;
        }
        public override double Area
        {
            get { return length * length * System.Math.PI; }
        }
        public override void MakeArea()
        {
            Console.WriteLine("Circle");
        }
    }

    public class Rectangle : Shape
    {
        double l;
        double w;
        public Rectangle(double _l, double _w, string _id) : base(_id)
        {
            l = _l;
            w = _w;
        }
        public override double Area
        {
            get { return l * w; }
        }
        public override void MakeArea()
        {
            Console.WriteLine("Circle");
        }
    }
}
using System;
//using System.Collections.Generic;
namespace LearnCSharp
{

    /// <summary>
    /// 多态
    /// 特点:1.运行时,在方法参数,集合,数组重,派生对象可作为基类的对象处理,声明类型与运行时不同
    /// 2.基类可以定义并实现虚方法,派生类来重写他们,可以调用基类方法,执行该方法的派生类版本.
    /// </summary>
    public class Inherit2
    {
        public void Fun()
        {
            //多态性特点1.派生对象作为基类对象处理
            Shape[] shapes =
            {
                new Circle(1,"shapes #1"),
                new Rectangle(2,3,"Rectangle #1")
            };
            //多态特点2.虚方法MakeArea() 被每个派生类调用而不是基类.
            foreach (Shape s in shapes)
            {
                s.MakeArea();
                Console.WriteLine(s);
            }
            Console.WriteLine(Shape.conValue);
            Shape shape = new Circle(2, "2222");
            Console.WriteLine(shape.array.Length);

        }
    }

    public abstract class Shape
    {
        public const int conValue = 99;
        public readonly int[] array = new int[3] { 1, 2, 3 };
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
    public interface Ichange
    {
        //int x;//接口不允许字段
        //const int x = 99;//接口不允许常量
        // static void Fun();//接口不允许静态函数
        void Fun();//方法
        int Y { get; set; }//属性
        event EventHandler Onchange;//事件
    }
    public class Change : Ichange
    {
        int _x;
        event EventHandler handler1;
        event EventHandler Ichange.Onchange
        {
            add
            {
                handler1 += value;
            }
            remove
            {
                handler1 -= value;
            }
        }
        public void Fun()
        {

        }
        public int Y
        {
            get { return _x; }
            set { _x = value; }
        }
    }
}
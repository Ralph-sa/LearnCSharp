using System;

namespace LearnCSharp
{
    abstract class SubClass
    {
        public abstract void Request();
    }

    class RealSubclass : SubClass
    {
        public override void Request()
        {
            Console.WriteLine("real subclass");
        }
    }
    /// <summary>
    // 代理模式
    /// </summary>
    class Poxy : SubClass
    {
        private RealSubclass subClass;
        public override void Request()
        {
            if (subClass == null)
            {
                subClass = new RealSubclass();
            }
            subClass.Request();
        }
    }

}
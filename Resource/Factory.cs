using System;
/// <summary>
/// 工厂模式
/// </summary>
namespace LearnCSharp
{


    public class Operation
    {
        public virtual void GetResult()
        {
            Console.WriteLine(" virtual Operation");
        }
    }

    public class Operation1 : Operation
    {
        public override void GetResult()
        {
            base.GetResult();
            Console.WriteLine("Operation1");
        }
    }

    public class Operation2 : Operation
    {
        public override void GetResult()
        {
            base.GetResult();
            Console.WriteLine("Operation2");
        }
    }


    public interface IFactory
    {
        Operation CreateOperation();
    }

    public class Factory : IFactory
    {
        public Operation CreateOperation()
        {
            return new Operation1();
        }
    }
    public class Factory2 : IFactory
    {
        public Operation CreateOperation()
        {
            return new Operation2();
        }
    }



}
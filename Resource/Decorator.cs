using System;

namespace LearnCSharp
{

    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent");
        }
    }
    /// <summary>
    /// 装饰模式
    /// </summary>
    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    class DecoratorA : Decorator
    {
        int a = 11;
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(a + "DecoratorA");
        }
    }
    class DecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            SetName();
        }
        private void SetName()
        {
            Console.WriteLine("SetName Fun DecoratorB");
        }
    }

}
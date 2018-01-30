using System;
namespace LearnCSharp
{
    /// <summary>
    /// 继承 只支持 类和接口
    /// </summary>
    public class CLassInherit1
    {
        public void Fun()
        {
            A classA = new A();
            classA._a = 1;

        }

    }

    public class A
    {
        public int _a;
        private int _b;
        protected int _c;
        public class B : A
        {
            public void SetValue()
            {
                this._a = 1;                                     // 共有的基类成员在其嵌套的派生类中是可见的
                this._b = 1;                                    // 私有的基类成员在其嵌套的派生类中是可见的
                this._c = 1;                                    // 受保护的基类成员在派生类中是可见的
            }
        }
    }

    public class C : A
    {
        public void SetValue()
        {
            this._a = 1;                                     // 共有的基类成员在派生类中是可见的
            //this._b = 1;                                   // 私有的基类成员在派生类中是不可见的
            this._c = 1;                                    // 受保护的基类成员在派生类中是可见的
        }
    }

    public class D
    {
        int _i;
        public virtual int i
        {
            get { return _i; }
            set { _i = value; }
        }
        public virtual void Fun() { }
    }
    public class E : D
    {
        public override int i
        {
            get;
            set;
        }
        public override void Fun()
        {
            base.Fun();
        }
    }
    public class F : D
    {
        public override void Fun()
        {
            int x = 0;
            Console.WriteLine(x);
        }
    }

    /// <summary>
    /// 抽象类 
    /// 抽象类不能实例化
    /// 包含抽象方法 或者访问器
    /// 无法用sealed 修饰符 修改它(sealed 阻止继承)
    /// 必须为所有抽象接口提供实现
    /// </summary>
    public abstract class AbstractClass : Inter
    {
        /// <summary>
        /// 抽象方法
        /// 该方法或者属性不包含实现
        /// 只有抽象类才能有抽象方法
        /// 她的实由override 方法来提供    
        /// 不能有static virtual 修饰符
        /// /// </summary>
        public abstract void Fun();
        public abstract void Fun3();
        public void Fun2()
        {

        }
        //实现接口
        public void InterFun()
        {
            Console.WriteLine("2");
        }
        public abstract int x
        { get; }
    }
    public class OverriderClass : AbstractClass
    {
        public override void Fun()
        {

        }
        public sealed override void Fun3()
        {

        }
        public void Func()
        {
            this.Fun2();
        }
        public override int x
        {
            get
            {
                return 0;
            }
        }
    }
    public class OverriderClass2 : OverriderClass
    {
        //衍生自衍生类 可以继续用过重写的特性
        public override void Fun()
        {

        }
        public override int x
        {
            get
            {
                return 100;
            }
        }
        //因为父类 使用了sealed 修饰符,变成了密封方法,无法继承
        // public override void Fun3()
        // {

        // }
    }
    interface Inter
    {
        void InterFun();
    }
}
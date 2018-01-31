using System.Collections.Generic;
namespace LearnCSharp
{
    /// <summary>
    /// 泛型参数参数 
    /// </summary>
    public class Generic2
    {
        Stack<int> s = new Stack<int>();

    }
    public interface ISessionTl<TSession>
    {
        void Fun(TSession t);//泛型参数
        TSession Fun2(); //泛型返回类型
        TSession Session { get; }

    }

    public class GenericT<T>
    {
        public T t;
        public int ISessionValue<T>()
        {
            return 0;
        }
    }
    public delegate TOutput DelegateT<TInput, TOutput>(TInput from);
    public delegate bool Predicate<T>(T item);


}
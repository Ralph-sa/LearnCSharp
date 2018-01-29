using System;
namespace LearnCSharp
{
    /// <summary>
    ///  单例模式
    /// </summary>
    public class Singleton
    {
        public static Singleton instance;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public void Show()
        {
            Console.WriteLine("singleton!");
        }

    }

}
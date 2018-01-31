using System.Collections.Generic;
using System;
namespace LearnCSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class Generic3
    {
        //IList<T> 使用相同代码循环访问 数组 和其他集合类型
        public void ProcessItems<T>(IList<T> collection)
        {
            foreach (T t in collection)
            {
                Console.WriteLine(t);
            }
        }
    }

}
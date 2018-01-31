using System;
namespace LearnCSharp
{
    public class TestGenericList
    {
        public static void MakeGenericList()
        {
            GenericList1<int> list = new GenericList1<int>();
            for (int i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
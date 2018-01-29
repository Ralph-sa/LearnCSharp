using System;
using System.Collections.Generic;
namespace LearnCSharp
{
    public class BoxTest
    {
        public void OnBox()
        {
            int i = 999;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            object ob = i;
            try
            {
                Console.WriteLine(ob.GetType());

                short s = (short)ob;
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine("err" + e.Message);
            }
        }
    }
}
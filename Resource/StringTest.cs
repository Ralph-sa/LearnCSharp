using System;
namespace LearnCSharp
{
    public class StringTest
    {
        public string s1 = "123";
        public string s2 = "123";
        public void StrCompare()
        {
            Console.WriteLine(s1.GetTypeCode() + "        " + s1.GetHashCode());
            Console.WriteLine(s2.GetTypeCode() + "        " + s2.GetHashCode());
            s1 += s2;
            Console.WriteLine(s1.GetTypeCode() + "        " + s1.GetHashCode());
            Console.WriteLine(s2.GetTypeCode() + "        " + s2.GetHashCode());
        }
    }
}
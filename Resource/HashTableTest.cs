using System.Collections;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
namespace LearnCSharp
{
    public class HashTableTest
    {
        public void OnHash()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "12");
            ht.Add(2, "123");
            ht.Add(3, "1234");
            ht.Add(4, "12345");
            ICollection coll = ht.Keys;
            foreach (int i in coll)
            {
                // Console.WriteLine(i);
            }
        }
        public void OnArrayList()
        {
            BoxTest bt = new BoxTest();
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("123");
            al.Add(333.88f);
            al.Add(bt);
            al.Add("123");
            al.Add("123");
            foreach (var i in al)
            {
                //    Console.WriteLine(GetAddress(i));

            }
            // string s1 = "3";
            // string s2 = "3";
            // string s3 = "3";
            // Console.WriteLine(GetAddress(s1));
            // Console.WriteLine(GetAddress(s2));
            // Console.WriteLine(GetAddress(s3));
            // Console.WriteLine(GetAddress(s1));
            // Console.WriteLine(GetAddress(s2));
            // Console.WriteLine(GetAddress(s3));
            string x1 = "111";
            string x2 = "111";
            Console.WriteLine("x1" + x1.GetHashCode());
            Console.WriteLine("x2" + x2.GetHashCode());

            Console.WriteLine(GetAddress(x1));
            Console.WriteLine(GetAddress(x2));
        }

        public string GetAddress(object o)
        {
            GCHandle h = GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection);

            IntPtr addr = GCHandle.ToIntPtr(h);

            return "0x" + addr.ToString("X");
        }


        public void SpeedGeneric()
        {
            //generic list
            List<int> ListGeneric = new List<int> { 5, 9, 1, 4 };
            //non-generic list
            ArrayList ListNonGeneric = new ArrayList { 5, 9, 1, 4 };
            // timer for generic list sort
            Stopwatch s = Stopwatch.StartNew();
            ListGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: {ListGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");

            //timer for non-generic list sort
            Stopwatch s2 = Stopwatch.StartNew();
            ListNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: {ListNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");
            Console.ReadLine();
        }
    }
}
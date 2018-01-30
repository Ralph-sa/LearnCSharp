using System;
using System.Collections.Generic;
using System.Linq;
namespace LearnCSharp
{
    class Program
    {
        public class IntList : List<int> { }
        static void Main(string[] args)
        {
            // MakeGeneric01();
            //MakeGeneric02();
            //MakeExampleClass1();
            //MakeBox();
            //MakeSingleton();
            //MakeDecorator();
            // MakePoxy();
            //MakeFactory();
            //MakeStrCom();
            //MakeBoxing();
            // MakeHashtable();
            //MakeGeneric();
            //MakeValRefCopy();
            MakeShape();
        }
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static void MakeGeneric01()
        {
            Generic01<int> _generic = new Generic01<int>();
            _generic.BubberSort(new int[3] { 14, 2, 3 });
            Generic01<string> _generic2 = new Generic01<string>();
            _generic2.BubberSort(new string[3] { "twev", "rd", "3666w" });
        }
        static void MakeGeneric02()
        {
            P _p = new P();
            _p.UseArrayList();
            _p.UseList();
        }
        static void MakeExampleClass1()
        {
            var example = new ExampleClass1
            {
                Name = "toro",
                ID = 999,
                Location = "farfarfar",
                age = 3.44
            };
            example.SetCoords();
            Console.WriteLine(example.coords.x);
        }
        static void MakeBox()
        {
            Box box = new Box(1f, 1f);
            Location location = (Location)box;
            Console.WriteLine(location.Get_X());
            Console.WriteLine(location.Get_Y());
        }
        //单例模式
        static void MakeSingleton()
        {
            Singleton.GetInstance().Show();
        }
        //装饰模式
        static void MakeDecorator()
        {
            ConcreteComponent cc = new ConcreteComponent();
            DecoratorA da = new DecoratorA();
            DecoratorB db = new DecoratorB();

            da.SetComponent(cc);
            db.SetComponent(da);
            db.Operation();
        }
        //代理模式 
        static void MakePoxy()
        {
            Poxy poxy = new Poxy();
            poxy.Request();
        }
        static void MakeFactory()
        {
            IFactory factory;
            Operation operation;
            factory = new Factory();

            operation = factory.CreateOperation();
            operation.GetResult();

            Console.WriteLine("--------------------------");

            factory = new Factory2();
            operation = factory.CreateOperation();
            operation.GetResult();
        }
        static void MakeStrCom()
        {
            StringTest st = new StringTest();
            st.StrCompare();
        }
        static void MakeBoxing()
        {
            BoxTest bt = new BoxTest();
            bt.OnBox();
        }
        static void MakeHashtable()
        {
            HashTableTest ht = new HashTableTest();//
            ht.OnHash();
            ht.OnArrayList();
        }
        static void MakeGeneric()
        {
            HashTableTest ht = new HashTableTest();
            ht.SpeedGeneric();
        }
        static void MakeValRefCopy()
        {
            RefClass _ref = new RefClass(1);
            ValClass _val = new ValClass(1);

            ValRefComp v = new ValRefComp(_ref, _val);
            ValRefComp v2 = (ValRefComp)v.Clone();
            Console.WriteLine(v._ref.x + "\\\\" + v._val.x);
            Console.WriteLine(v2._ref.x + "\\\\" + v2._val.x);
            v._ref.x = v._val.x = 10;
            Console.WriteLine(v._ref.x + "\\\\" + v._val.x);
            Console.WriteLine(v2._ref.x + "\\\\" + v2._val.x);
        }
        static void MakeShape()
        {
            Inherit2 in2 = new Inherit2();
            in2.Fun();
        }
    }
}

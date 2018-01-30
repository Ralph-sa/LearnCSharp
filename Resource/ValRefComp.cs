using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace LearnCSharp
{
    [Serializable()]
    public class ValRefComp : ICloneable
    {
        public RefClass _ref;
        public ValClass _val;
        public ValRefComp(RefClass r, ValClass v)
        {
            this._ref = r;
            this._val = v;
        }
        public object Clone()
        {
            return SimpleClone();
        }
        //simple
        public object SimpleClone()
        {
            return base.MemberwiseClone();
        }
        //deep
        public object DeepClone()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return (bf.Deserialize(ms));
        }
    }
    [Serializable()]
    public class RefClass
    {
        public int x;
        public RefClass(int _x)
        {
            this.x = _x;
        }
    }
    [Serializable()]
    public struct ValClass
    {
        public int x;
        public ValClass(int _x)
        {
            this.x = _x;
        }
    }
}
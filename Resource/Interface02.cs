using System;
namespace LearnCSharp
{
    interface Location
    {
        float Get_X();
        float Get_Y();
    }
    public class Box : Location
    {
        float x;
        float y;
        public Box(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        float Location.Get_X()
        {
            return x;
        }
        float Location.Get_Y()
        {
            return y;
        }

    }
}
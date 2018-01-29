namespace LearnCSharp
{
    public class ExampleClass1
    {
        public string Name;
        public int ID;
        public string Location;
        public double age;
        public Coords coords;

        public void SetCoords()
        {
            coords = new Coords(33, 2);
        }

    }
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
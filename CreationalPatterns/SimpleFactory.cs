using System;

namespace DesignPatterns
{
    public interface IDoor
    {
        public float GetWidth();
        public float GetHeight();

    }
    public class WoodenDoor : IDoor
    {
        protected float width;
        protected float height;

        public WoodenDoor(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetWidth()
        {
            return this.width;
        }
        public float GetHeight()
        {
            return this.height;
        }

    }

    public class DoorFactory
    {
        public IDoor makeDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }
    class SimpleFactory
    {
        static void Main(string[] args)
        {
            var door = new DoorFactory();
            var d = door.makeDoor(10, 20);
            Console.WriteLine(d.GetWidth() + d.GetHeight());
        }
    }
}

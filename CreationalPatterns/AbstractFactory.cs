using System;

namespace DesignPatterns
{
    public interface IDoor
    {
        public void GetDescription();

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

        public void GetDescription()
        {
            Console.WriteLine("This is wooden door of {0} * {1}", this.width, this.height);
        }

    }
    public class IronDoor : IDoor
    {
        protected float width;
        protected float height;

        public IronDoor(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public void GetDescription()
        {
            Console.WriteLine("This is iron door of {0} * {1}", this.width, this.height);
        }

    }

    public interface DoorFitting
    {
        public void GetDescription();
    }

    public class Welder : DoorFitting
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a welder , I fit iron doors");
        }
    }

    public class Carpenter : DoorFitting
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a Carpenter , I fit wooden doors");
        }
    }

    public interface DoorFactory
    {
        public IDoor MakeDoors(float w, float h);
        public DoorFitting FitDoors();
    }

    public class WoodenDoorFactory : DoorFactory
    {
        public DoorFitting FitDoors()
        {
            return new Carpenter();
        }

        public IDoor MakeDoors(float w, float h)
        {
            return new WoodenDoor(w, h);
        }

    }
    public class IronDoorFactory : DoorFactory
    {
        public DoorFitting FitDoors()
        {
            return new Welder();
        }

        public IDoor MakeDoors(float w, float h)
        {
            return new IronDoor(w, h);
        }

    }
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            var woodenFactory = new WoodenDoorFactory();
            var woodDoor = woodenFactory.MakeDoors(10, 22);
            var woodFit = woodenFactory.FitDoors();
            woodDoor.GetDescription();
            woodFit.GetDescription();

            var ironFactory = new IronDoorFactory();
            var ironDoor = ironFactory.MakeDoors(30, 60);
            var ironFit = ironFactory.FitDoors();
            ironDoor.GetDescription();
            ironFit.GetDescription();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public interface IDoor
    {
        public void OpenDoor();
        public void CloseDoor();
    }

    public class SimpleDoor : IDoor
    {
        public void OpenDoor()
        {
            Console.WriteLine("Opening door");
        }
        public void CloseDoor()
        {
            Console.WriteLine("Closing door");
        }
    }

    public class SecuredDoor
    {
        IDoor door;

        public SecuredDoor(IDoor door)
        {
            this.door = door;
        }

        public void CloseDoor()
        {
            Console.WriteLine("Closing secured door");
        }

        public void OpenDoor(string password)
        {
            if (IsAuthenticated(password))
                this.door.OpenDoor();
            else
                Console.WriteLine("Access Denied!!!");
        }

        public bool IsAuthenticated(string password)
        {
            if (password == "Admin#123")
                return true;
            else
                return false;
        }
    }
 

    class Proxy
    {
        static void Main(string[] args)
        {
            var securedDoor = new SecuredDoor(new SimpleDoor());
            securedDoor.OpenDoor("asdsdsd");
            securedDoor.OpenDoor("Admin#123");
            securedDoor.CloseDoor();
         

        }
    }
}

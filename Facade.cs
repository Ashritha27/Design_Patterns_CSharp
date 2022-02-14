using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public class Computer
    {
        public void ShowLoadingScreen()
        {
            Console.WriteLine("Loading..");
        }
        public void ShowShuttingDown()
        {
            Console.WriteLine("Shutting down..");

        }
        public void BootSystem()
        {
            Console.WriteLine("Booting up..");
        }

        public void ShowLoginScreen()
        {
            Console.WriteLine("Login Screen...");

        }
        public void ClosePrograms()
        {
            Console.WriteLine("Closing open applications...");
        }
    }

    public class ComputerFacade : Computer
    {
        Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }

        public void TurnComputerOn()
        {
            this.computer.BootSystem();
            this.computer.ShowLoadingScreen();
            this.computer.ShowLoginScreen();

        }
        public void TurnOffComputer()
        {
            this.computer.ClosePrograms();
            this.computer.ShowShuttingDown();
        }

    }

    class Facade
    {
        static void Main(string[] args)
        {
            ComputerFacade comp = new ComputerFacade(new Computer());
            comp.TurnComputerOn();
            comp.TurnOffComputer();

        }
    }
}

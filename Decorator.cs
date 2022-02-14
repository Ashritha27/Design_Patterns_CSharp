using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public interface ICoffee
    {
        public float GetCost();
        public string GetDescription();

    }

    public class SimpleCoffee : ICoffee
    {
        public float GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Simple";
        }
    }

    public class MilkCoffe : ICoffee
    {
        ICoffee coffee;
        
        public MilkCoffe(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return this.coffee.GetCost() + 15;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + "Milk";
        }
    }

    public class VanillaCoffee : ICoffee
    {
        ICoffee coffee;

        public VanillaCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return this.coffee.GetCost() + 25;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + "VanillaC";
        }
    }
    class Decorator
    {
        static void Main(string[] args)
        {
            ICoffee coffee;
            coffee = new SimpleCoffee();
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine(coffee.GetDescription());

            coffee = new MilkCoffe(coffee);
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine(coffee.GetDescription());

            coffee = new VanillaCoffee(coffee);
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine(coffee.GetDescription());


        }
    }
}

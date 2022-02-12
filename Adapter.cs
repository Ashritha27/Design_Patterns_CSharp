using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public interface ITarget
    {
        public string GetRequest();
    }

    public class Adaptee
    {
        private readonly string reqName;
        public Adaptee(string reqName)
        {
            this.reqName = reqName;
        }
        public Adaptee()
        {
            this.reqName = "Default";
        }
        public string GetAdapteeSpecificRequest()
        {
            return reqName;
        }
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is {_adaptee.GetAdapteeSpecificRequest()}";
        }
    }

  
    class Adapter
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee("Adaptee request");
            Adapter adapter = new Adapter(adaptee);

            Console.WriteLine(adapter.GetRequest());
            Adaptee adaptee1 = new Adaptee();
            Adapter adapter1 = new Adapter(adaptee1);

            Console.WriteLine(adapter1.GetRequest());


        }
    }
}

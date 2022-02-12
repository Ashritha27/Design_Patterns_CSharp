using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
      
    public sealed class SingletonBase
    {
        public SingletonBase()
        {
            Console.WriteLine("Initializing constructor");
        }
        private static readonly object lockInstance = new object();
        private static SingletonBase instance = null;
        public static SingletonBase Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockInstance)
                    {
                        instance = new SingletonBase();
                    }
                }
                return instance;
            }
        }

    }
    class Singleton
    {
        static void Main(string[] args)
        {
            var sb = new SingletonBase();
            var sb1 = new SingletonBase();
            if(sb == sb1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
    }
}

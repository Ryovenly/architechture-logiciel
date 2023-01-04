using System;
using System.Collections.Generic;
using System.Threading;

namespace Exercice6
{

    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        public static Singleton GetInstance(Guid id)
        {
  
            if (_instance == null)
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.ID = id;
                    }
                }
            }
            return _instance;
        }

        public Guid ID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            List<Thread> process = new List<Thread>();

            for(var i = 0; i < 10; i++)
            {
                Thread newProcess = new Thread(() =>
                {
                    TestSingleton(Guid.NewGuid());
                });
                process.Add(newProcess);
            }

            for (var i = 0; i < 10; i++)
            {
                process[i].Start();
                process[i].Join();
            }

        }

        public static void TestSingleton(Guid id)
        {
            Singleton singleton = Singleton.GetInstance(id);
            Console.WriteLine(singleton.ID);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void someUsefulCode()
        {
            Console.WriteLine("Singleton stuff");
        }
    }

    //My questions: 

    //1. Why use Singleton instead of static class, what is the difference?
    //-Singleton objects are stored in Heap, but static objects are stored in stack.
    //-We can clone(if the designer did not disallow it) the singleton object, but we can not clone the static class object .
    //-Singleton classes follow the OOP(object oriented principles), static classes do not.
    //-We can implement an interface with a Singleton class, but a class's static methods (or e.g. a C# static class) cannot.

    //as people said the first three are not accurate, beware of not necessarily correct answer
}

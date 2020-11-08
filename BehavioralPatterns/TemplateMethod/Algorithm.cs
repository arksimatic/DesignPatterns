using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    abstract class Algorithm
    {
        public void Execute() 
        {
            Step1();
            Step2();
            Step3();
            Step4();
        }

        protected virtual void Step1()
        {
            Console.WriteLine("Base Step 1");
        }

        protected virtual void Step2()
        {
            Console.WriteLine("Base Step 2");
        }

        protected virtual void Step3()
        {
            Console.WriteLine("Base Step 3");
        }

        protected virtual void Step4()
        {
            Console.WriteLine();
        }
    }
}

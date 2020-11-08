using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    class AlgorithmWithStep2and3 : Algorithm
    {
        protected override void Step2()
        {
            Console.WriteLine("Overrided Step 2");
        }

        protected override void Step3()
        {
            Console.WriteLine("Overrided Step 3");
        }
    }
}

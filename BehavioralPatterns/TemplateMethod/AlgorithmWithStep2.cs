using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    class AlgorithmWithStep2 : Algorithm
    {
        protected override void Step2() 
        {
            Console.WriteLine("Overrided Step 2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    class SubtractingStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }

        public override string ToString()
        {
            return "SubtractingStrategy";
        }
    }
}

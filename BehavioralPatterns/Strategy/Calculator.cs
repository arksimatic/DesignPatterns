using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    class Calculator
    {
        private IStrategy _strategy;
        public Calculator(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy) => _strategy = strategy;

        public void Calculate(int a, int b)
        {
            int result = _strategy.Execute(a, b);
            Console.WriteLine($"Result of {_strategy} on {a} and {b} is {result}");
        }
    }
}

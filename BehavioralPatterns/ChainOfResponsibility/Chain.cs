using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    class Chain
    {
        Processor chain;

        public Chain()
        {
            chain = new NegativeProcessor(new PositiveProcessor());
        }

        public void Process(int request)
        {
            chain.Process(request);
        }
    }
}

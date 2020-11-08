using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    class PositiveProcessor : Processor
    {
        public PositiveProcessor(Processor processor) : base(processor)
        {

        }

        public PositiveProcessor() : base()
        {

        }

        public new void Process(int request)
        {
            if (request > 0)
                Console.WriteLine("positive processor proceeded this request");
            else
            {
                Console.WriteLine("positive processor couldn't handle this request");
                base.Process(request);
            }
        }

    }
}

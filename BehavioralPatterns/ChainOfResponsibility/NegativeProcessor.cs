using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    class NegativeProcessor : Processor
    {
        public NegativeProcessor(Processor processor) : base(processor)
        {
            
        }

        public NegativeProcessor() : base()
        {

        }

        public new void Process(int request)
        {
            if (request < 0)
                Console.WriteLine("negative processor proceeded this request");
            else
            {

                Console.WriteLine("negative processor couldn't handle this request");
                base.Process(request);
            }
        }

    }
}

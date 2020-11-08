using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    class Processor
    {
        private Processor processor;

        public Processor(Processor processor)
        {
            this.processor = processor;
        }

        public Processor()
        {
            processor = null;
        }

        public void Process(int request)
        {
            if (processor != null)
                processor.Process(request);
        }
    }
}

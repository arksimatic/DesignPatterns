using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    abstract class APerson
    {
        protected Mediator mediator;
        protected string name;

        public APerson(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}

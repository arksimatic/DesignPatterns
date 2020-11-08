using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    class RealPerson : APerson
    {
        
        public RealPerson(Mediator mediator, string name) : base(mediator, name) { }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"{name} recieved message ''{message}''");
        }
    }
}
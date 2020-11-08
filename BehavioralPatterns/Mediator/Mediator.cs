using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, APerson person);
        public abstract void AddPerson(APerson person);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    class RealMediator : Mediator
    {
        private List<APerson> persons;

        public RealMediator(List<APerson> persons)
        {
            this.persons = persons;
        }
        
        public RealMediator() 
        {
            this.persons = new List<APerson>();
        }

        public override void AddPerson(APerson person)
        {
            persons.Add(person);
        }

        public override void Send(string message, APerson person)
        {
            foreach(APerson p in persons)
            {
                if (p != person) p.Notify(message);
            }
        }
    }
}

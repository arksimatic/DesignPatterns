using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    class Shop
    {
        public string Name;
        private List<Merchandise> _merchandises;
        private List<Customer> _subscribers;

        public Shop(string name)
        {
            Name = name;
            _merchandises = new List<Merchandise>();
            _subscribers = new List<Customer>();
        }

        public void AddMerchandise(Merchandise merchandise)
        {
            _merchandises.Add(merchandise);
            Nofity(merchandise);
        }

        public void AddSubscriber(Customer customer)
        {
            _subscribers.Add(customer);
        }

        public void DeleteSubscriber(Customer customer)
        {
            _subscribers.Remove(customer);
        }

        private void Nofity(Merchandise merchandise)
        {
            foreach(Customer customer in _subscribers)
            {
                customer.Inform(this, merchandise);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    class ProxyBank : IBank
    {
        Bank bank;

        public ProxyBank()
        {
            bank = new Bank();
        }
        public void Pay()
        {
            Console.WriteLine("validation");
            if(Validate())
            {
                bank.Pay();
            }
        }

        private bool Validate()
        {
            return true;
        }
    }
}

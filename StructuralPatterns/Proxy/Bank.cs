using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    class Bank : IBank
    {
        public void Pay()
        {
            Console.WriteLine("paying");
        }
    }
}

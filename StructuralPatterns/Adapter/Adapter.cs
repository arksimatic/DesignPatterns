using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    class Adapter : IWrite
    {
        private readonly OldClass _oldClass;

        public Adapter(OldClass oldClass)
        {
            this._oldClass = oldClass;
        }

        public void PrintMessage()
        {
            _oldClass.DoSomething();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public class SomeObject
    {
        public int? number = null;
        public static int? count = 0;

        public SomeObject()
        {
            number = count++;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}

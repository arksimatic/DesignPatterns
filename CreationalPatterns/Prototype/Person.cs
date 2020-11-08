using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    class Person : IPrototype
    {
        public IdInfo id;
        public int age;
        public string name;

        public Person(int id, int age, string name)
        {
            this.id = new IdInfo(id);
            this.age = age;
            this.name = name;
        }

        public IPrototype ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public IPrototype DeepCopy()
        {
            return new Person(id.idNumber, age, name);
        }

        public override string ToString()
        {
            return $"{id.idNumber}. {name}, {age} years old";
        }
    }
}

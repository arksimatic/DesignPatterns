using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderDesign
{
    public class ItemBuilder
    {
        public int id;
        public string name;
        public string type;

        //id is mandatory so it is inside the basic constructor
        public ItemBuilder(int id) 
        {
            this.id = id;
        }
        public ItemBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ItemBuilder SetType(string type)
        {
            this.type = type;
            return this;
        }

        public Item build()
        {
            Item item = new Item(this);
            validateItemObject(item);
            return item;
        }

        private void validateItemObject(Item user)
        {
            //validation
        }
    }
}

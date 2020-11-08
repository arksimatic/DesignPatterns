using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderDesign
{
    public class Item
    {
        public int id;
        public string name;
        public string type;

        public Item(ItemBuilder builder)
        {
            this.id = builder.id;
            this.name = builder.name;
            this.type = builder.type;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lab3App
{
    class Collectable
    {
        protected string Description;
        public CollectionBoard Board;

        public Collectable(string description)
        {
            Description = description;
        }
        public virtual void AddMe(List<Collectable> collected)
        {
            collected.Add(this);
        }

        public virtual void AddMe()
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Description: {Description}");
        }
    }
}

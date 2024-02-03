using System;

namespace Lab3App
{
    class Tool : Collectable
    {
        public Tool(string description) : base(description)
        {
        }

        public virtual void DoAction()
        {
            Console.WriteLine("Tool is used.");
        }
    }
}


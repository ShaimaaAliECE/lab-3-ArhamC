﻿using System;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string description) : base(description)
        {
        }

        public override void DoAction()
        {
            base.DoAction();
            Console.WriteLine("MagicWand is used.");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
    }
}

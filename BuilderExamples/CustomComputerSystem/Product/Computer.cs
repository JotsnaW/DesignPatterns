﻿using System;

namespace CustomComputerSystem.Product
{
    public class Computer
    {
        public string GraphicsCard {  get; set; }
        public string CPU {  get; set; }
        public string RAM {  get; set; }
        public string OperatingSystem {  get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Created custom computer with {GraphicsCard} Graphics card, {CPU} CPU, {RAM} RAM and {OperatingSystem} operating system.");
        }

    }
}
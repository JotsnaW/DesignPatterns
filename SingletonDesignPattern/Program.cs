using System;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // call to get the instance of Singleton class
            Singleton SingletonInstance1 = Singleton.GetInstance();

            SingletonInstance1.setValue("Jotsna Waghmare");

            Singleton SingletonInstance2 = Singleton.GetInstance();

            Console.WriteLine(SingletonInstance2.getValue());

        }
    }
}

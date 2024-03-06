using System;

namespace SingletonDesignPattern
{
    internal class Program
    {
        public static void Main()
        {
            // call to get the instance of Singleton class
            Singleton firstSingletonInstance = Singleton.GetInstance();

            firstSingletonInstance.SetValue("Jotsna Waghmare");

            Singleton secondSingletonInstance = Singleton.GetInstance();

            Console.WriteLine(secondSingletonInstance.GetValue());

        }
    }
}

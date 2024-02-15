using System;

namespace SingletonDesignPattern
{
    internal class Singleton
    {
        private string m_name;

        //static instance creation
        private static Singleton instance = new Singleton();

        // private çonstructor
        private Singleton()
        {
        }

        // static method to get Instance
        public static Singleton GetInstance()
        {
            return instance;
        }

        public string GetValue()
        {
            return m_name;
        }

        public void SetValue(string name)
        {
            m_name = name;
        }
    }
}

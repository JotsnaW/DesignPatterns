namespace SingletonDesignPattern
{
    internal class Singleton
    {
        private string name;

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

        public string getValue()
        {
            return name;
        }

        public void setValue(string text)
        {
            name = text;
        }
    }
}

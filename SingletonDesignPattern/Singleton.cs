namespace SingletonDesignPattern
{
    internal class Singleton
    {
        private string name;

        private static Singleton instance = new Singleton();

        // private çonstructor
        private Singleton()
        {

        }

        // static method
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

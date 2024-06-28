namespace TextEditor
{
    public class Memento : IMemento
    {
        public string Text { get; private set; }

        public Memento(string text)
        {
            Text = text;
        }
    }
}

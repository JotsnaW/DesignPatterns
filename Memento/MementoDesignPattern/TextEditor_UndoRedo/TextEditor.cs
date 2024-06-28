using System;

namespace TextEditor
{
    //Originator class
    public class TextEditor
    {
        public string Text { get; set; }

        public IMemento CreateMemento()
        {
            return new Memento(Text);
        }

        public void RestoreMemento(IMemento memento)
        {
            if (memento != null)
                Text = memento.Text;
            else
                Console.WriteLine("memento is empty.");
        }

        
    }
}

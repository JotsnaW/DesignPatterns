using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            TextEditorHistory caretaker = new TextEditorHistory();

            editor.Text = "Jotsna";
            caretaker.SaveMemento(editor.CreateMemento());

            editor.Text = "Waghmare";
            caretaker.SaveMemento(editor.CreateMemento());

            caretaker.HistoryItems();

            // Undo the last change
            editor.RestoreMemento(caretaker.Undo());
            Console.WriteLine("\nRestored/Undo text: " + editor.Text);

            caretaker.HistoryItems();

            // Redo the undone change
            editor.RestoreMemento(caretaker.Redo());
            Console.WriteLine("\nRedo text: " + editor.Text);

            caretaker.HistoryItems();
        }
    }
}

using System;
using System.Collections.Generic;

namespace TextEditor
{
    //caretaker class
    class TextEditorHistory
    {
        private Stack<IMemento> undoStack = new Stack<IMemento>();
        private Stack<IMemento> redoStack = new Stack<IMemento>();

        public void HistoryItems()
        {
            if(undoStack.Count == 0)
            {
                Console.WriteLine("undo stack is empty.");
            }
            else
            {
                Console.WriteLine("\nCaretaker: Here's the list of mementos  (Undo stack): ");
                foreach (Memento memento in undoStack)
                {
                    Console.WriteLine(memento.Text);
                }
            }

            if (redoStack.Count == 0)
            {
                Console.WriteLine("Redo stack is empty.");
            }
            else
            {
                Console.WriteLine("\nCaretaker: Here's the list of mementos (Redo stack): ");
                foreach (Memento memento in redoStack)
                {
                    Console.WriteLine(memento.Text);
                }
            }
        }

        public void SaveMemento(IMemento memento)
        {
            undoStack.Push(memento);
           // redoStack.Clear(); // Clear redo stack when a new state is saved
        }

        public IMemento Undo()
        {
            if (undoStack.Count > 0)
            {
                IMemento memento =  undoStack.Pop();
                redoStack.Push(memento);
                return memento;
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
                return null;
            }
        }

        public IMemento Redo()
        {
            if(redoStack.Count > 0)
            {
                IMemento memento = redoStack.Pop();
                undoStack.Push(memento);
                return memento;

            }
            else
            {
                Console.WriteLine("Nothing to redo.");
                return null;
            }
        }
    }
}

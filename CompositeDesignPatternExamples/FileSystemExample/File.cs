using System;

namespace FileSystemExample
{
    internal class File : IFileSystemComponent
    {
        private readonly string m_name;
        private readonly double m_size;

        public File(string name, double size)
        {
          m_name = name;
          m_size = size;
        }

        public string GetName()
        {
            return m_name;
        }

        public double GetSize()
        {
            return m_size;
        }

        public void ShowDetails()
        {
          Console.WriteLine($"File name - {m_name}");
          Console.WriteLine($"File name - {m_size}");
          Console.WriteLine("");
        }
    }
}

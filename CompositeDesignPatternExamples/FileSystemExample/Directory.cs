using System.Collections.Generic;

namespace FileSystemExample
{
    public class Directory : IFileSystemComponent
    {
        private readonly string m_name;
        private List<IFileSystemComponent> m_directories = new List<IFileSystemComponent>();

        public Directory(string name)
        {
            m_name = name;
        }
        public void AddDirectory(IFileSystemComponent component)
        {
            m_directories.Add(component);
        }

        public string GetName()
        {
           return m_name;
        }

        public double GetSize()
        {
            double totalSize = 0;
            foreach (var directory in m_directories)
            {
                totalSize += directory.GetSize();
            }
            return totalSize;
        }

        public void ShowDetails()
        {
            foreach (var directory in m_directories)
            {
                //Console.WriteLine($"{directory.GetName()} contents - ");
                directory.ShowDetails();
            }
        }
    }
}

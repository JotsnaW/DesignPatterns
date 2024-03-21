using System;

namespace FileSystemExample
{
    public class Program
    {
        static void Main()
        {
            File file1 = new File("File1", 100);
            File file2 = new File("File2", 200);
            File file3 = new File("File3", 300);
            File file4 = new File("File4", 400);

            Directory subDirectory1 = new Directory("Sub-Directory1");
            subDirectory1.AddDirectory(file1);
            subDirectory1.AddDirectory(file2);
            Console.WriteLine("subDirectory1 Details - ");
            subDirectory1.ShowDetails();

            Directory subDirectory2 = new Directory("Sub-Directory2");
            subDirectory2.AddDirectory(subDirectory1);
            subDirectory2.AddDirectory(file3);
            subDirectory2.AddDirectory(file4);
            Console.WriteLine("subDirectory2 Details - ");
            subDirectory2.GetName();
            subDirectory2.GetSize();
            subDirectory2.ShowDetails();

            Directory rootDirectory = new Directory("Root Directory");
            rootDirectory.AddDirectory(subDirectory1);
            rootDirectory.AddDirectory(subDirectory2);
            rootDirectory.GetName();
            rootDirectory.GetSize();
            Console.WriteLine("rootDirectory Details - ");
            rootDirectory.ShowDetails();
        }
    }
}

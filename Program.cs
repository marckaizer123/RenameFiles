using System;
using System.IO;
using System.Linq;

namespace RenameFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Marc\Downloads\Unsorted Documents\Rename");
            FileInfo[] files = directory.GetFiles().OrderBy(f => f.LastWriteTime).ToArray();
            Console.WriteLine("Enter the shared name of your files: ");
            string input = Console.ReadLine();
            int count = 1;
            string fileExtension = "";
            DirectoryInfo directory2 =  System.IO.Directory.CreateDirectory(directory.FullName + "\\Module 1 - " + input);


            foreach (FileInfo file in files)
            {
                fileExtension = file.Extension;

                if (count < 10)
                    File.Move(file.FullName, directory2.FullName + "\\" + input + " 0" + count.ToString() + fileExtension, true);
                else
                    File.Move(file.FullName, directory2.FullName + "\\" + input + " " + count.ToString() + fileExtension, true);

                count++;
            }
            


        }
    }
}

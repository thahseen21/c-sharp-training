// 3.  I hope all of you have learnt the File system in c# as a part of self learning a few weeks ago. If not, kindly refresh and learn it today. 

// Preparation: Create folder structures of upto 3 level hierarchy, create several text files with random content

// a)  some of the files can contain text phrase - ""Gislen software"
// b) Create several image files (jpg,  png,  svg) 

// Program 
// a ) Implement a program to traverse through inner folder structure and access all the text files. If the text file contains data like "Gislen software" , copy those files to a new location 
// b) Implement a program to traverse through all folders and if the file format is  ,jpg  and the size is less than 3 mb, cut and move the files to a new directory. 

using System;
using System.IO;

namespace FilesOperation
{
    class Program
    {
        public static void FileMover(FileInfo source)
        {
            source.MoveTo($"/Users/thahseen/Documents/gislen/c-sharp/Day_27/FilesOperation/Level_1_Dir/Level_2_Dir/{source.Name}", true);
        }
        public static void FilesFinder(string path)
        {
            string[] myFiles = Directory.GetFiles(path);
            foreach (var files in myFiles)
            {
                var fileInfo = new FileInfo(files);
                // Console.WriteLine($"{Path.GetExtension(files)}:{files.Length}");
                // Console.WriteLine($"{fileInfo.Name}:{fileInfo.Length},{fileInfo}");
                if (Path.GetExtension(files) == ".txt")
                {
                    var file = fileInfo.OpenText();
                    var s = "";
                    while ((s = file.ReadLine()) != null)
                    {
                        if (s == "Gislen software")
                        {
                            Console.WriteLine($"Found a file having same text as \"Gislen software\" and moving...");
                            FileMover(fileInfo);
                            Console.WriteLine($"Moved sucessfully");

                        }
                    }
                }
                if (fileInfo.Length > 2097152)
                {
                    Console.WriteLine($"Found a large file so moving......");
                    FileMover(fileInfo);
                    Console.WriteLine($"Moved Successfully");
                }
            }
        }
        public static void SubDirectoryFinder(string[] subdir, string currentPath)
        {
            foreach (var dir in subdir)
            {
                // Console.WriteLine($"{dir}");
                FilesFinder(dir);
                SubDirectoryFinder(Directory.GetDirectories(dir), dir);
            }
        }
        static void Main(string[] args)
        {
            string currentDir = Directory.GetCurrentDirectory();

            string[] subDir = Directory.GetDirectories(currentDir);

            foreach (var mdir in subDir)
            {
                // Console.WriteLine($"{mdir}");
            }

            SubDirectoryFinder(Directory.GetDirectories(subDir[2]), subDir[2]);
        }
    }
}

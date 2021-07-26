using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FilesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "FirstTextFile.txt";
            DriveInfo[] di = DriveInfo.GetDrives();

            foreach (var item in di)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Available frespace :{di[0].AvailableFreeSpace}");
            Console.WriteLine($"Drive Format :{di[2].DriveFormat}");
            Console.WriteLine($"Name :{di[2].Name}");

            DriveInfo driveInfo = new DriveInfo("/dev");

            Console.WriteLine($"Name :{driveInfo.Name}");


            var subPath = "/Users/thahseen/Documents/gislen/training/";
            DirectoryInfo directoryInfo = new DirectoryInfo(subPath);

            Console.WriteLine($" directory info name :{directoryInfo.Name}");
            Console.WriteLine($" directory info creation time :{directoryInfo.CreationTime}");


            Console.WriteLine($"/Users/thahseen/Documents/gislen/training/ does this path exits : {directoryInfo.Exists}");

            if (directoryInfo.Exists)
            {
                directoryInfo.CreateSubdirectory("FolderCreatedUsingC#Files");
            }

            string text = "Hello potato";
            string text2 = "Hello another potato";
            File.WriteAllText("FirstTextFile.txt", text);

            File.WriteAllText("FirstTextFile.txt", text2);

            IEnumerable<String> list = new List<String> { "potato", "another potato", " Beautiful potato" };

            File.AppendAllLines("FirstTextFile.txt", list);


            var readText = File.ReadAllText("FirstTextFile.txt");
            Console.WriteLine($"read from the text :{readText}");


            //---------------______-------______----_____----_____---_____--______----______----_____----________----------________

            FileStream fs = new FileStream("fileName", FileMode.Append);

            string text3 = "Text that is going to be written using FileStream";
            byte[] byteArray = Encoding.ASCII.GetBytes(text3);
            foreach (var item in byteArray)
            {
                Console.Write($"{item.ToString()}");
            }
            fs.Write(byteArray);

        }
    }
}

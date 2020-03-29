using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_CSharp_Design_Patterns_Composite.FileSystem
{
    public static class FileSystemExample
    {
        public static void Run()
        {
            var root = new DirectoryItem("Development");
            var proj1 = new DirectoryItem("Porject1");
            var proj2 = new DirectoryItem("Porject2");
            root.Add(proj1);
            root.Add(proj2);

            proj1.Add(new FileItem("p1f1.txt", 2100));
            proj1.Add(new FileItem("p1f2.txt", 3100));

            var subDir1 = new DirectoryItem("sub-Dir1");
            subDir1.Add(new FileItem("p1f3.txt", 4100));
            subDir1.Add(new FileItem("p1f4.txt", 5100));
            proj1.Add(subDir1);

            proj2.Add(new FileItem("p2f1.txt", 6100));
            proj2.Add(new FileItem("p2f2.txt", 7100));

            Console.WriteLine($"Total size (proj2): {proj2.GetSizeInKb()}");
            Console.WriteLine($"Total size (proj1): {proj1.GetSizeInKb()}");
            Console.WriteLine($"Total size (root): {root.GetSizeInKb()}");
        }
    }
}

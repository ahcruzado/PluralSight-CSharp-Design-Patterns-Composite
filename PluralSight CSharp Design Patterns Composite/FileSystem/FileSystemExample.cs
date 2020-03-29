using Newtonsoft.Json;
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
            var builder = new FileSystemBuilder("development");
            builder.AddDirectory("project1");
            builder.AddFile("p1f3.txt", 4100);
            builder.AddFile("p1f2.txt", 3100);
            builder.AddDirectory("sub-dir1");
            builder.AddFile("p1f3.txt", 4100);
            builder.AddFile("p1f4.txt", 5100);

            builder.SetCurrentDirectory("development");
            builder.AddDirectory("projec2");
            builder.AddFile("p2f1.text", 6100);
            builder.AddFile("p2f2.text", 7100);

            Console.WriteLine($"Total size (root) : {builder.Root.GetSizeInKb()}");
            Console.WriteLine(JsonConvert.SerializeObject(builder.Root, Formatting.Indented));
        }
    }
}

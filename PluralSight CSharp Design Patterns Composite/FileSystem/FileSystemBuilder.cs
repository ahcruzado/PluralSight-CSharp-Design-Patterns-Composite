using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_CSharp_Design_Patterns_Composite.FileSystem
{
    public class FileSystemBuilder
    {
        private DirectoryItem currentDirectory;

        public FileSystemBuilder(string rootDiectoryName)
        {
            this.Root = new DirectoryItem(rootDiectoryName);
            this.currentDirectory = this.Root;
        }

        internal DirectoryItem AddDirectory(string name)
        {
            var dir= new DirectoryItem(name);
            this.currentDirectory.Add(dir);
            this.currentDirectory = dir;
            return dir;
        }

        internal DirectoryItem SetCurrentDirectory(string directoryName)
        {
            var dirStack = new Stack<DirectoryItem>();
            dirStack.Push(this.Root);

            while (dirStack.Any())
            {
                var current = dirStack.Pop();
                if (current.Name==directoryName)
                {
                    this.currentDirectory = current;
                    return current;
                }
                foreach (var item in current.Items.OfType<DirectoryItem>())
                {
                    dirStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Directory name '{directoryName}' not found!");
        }

        internal FileItem AddFile(string name, long fileBytes)
        {
            var file = new FileItem(name, fileBytes);
            this.currentDirectory.Add(file);
            return file;
        }

        internal DirectoryItem Root { get; }

    }
}

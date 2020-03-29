using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_CSharp_Design_Patterns_Composite.FileSystem
{
    internal class DirectoryItem : FileSystemItem
    {
        public DirectoryItem(string name): base(name)
        {

        }

        public void Add(FileSystemItem component)
        {
            this.Items.Add(component);
        }

        public void Remove(FileSystemItem component)
        {
            this.Items.Remove(component);
        }
        public List<FileSystemItem> Items { get; } = new List<FileSystemItem>();

        public override decimal GetSizeInKb()
        {
            return this.Items.Sum(x=> x.GetSizeInKb());
        }
    }
}

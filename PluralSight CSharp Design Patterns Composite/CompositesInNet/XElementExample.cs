using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PluralSight_CSharp_Design_Patterns_Composite.CompositesInNet
{
    public static class XElementExample
    {
        public static void Run()
        {
            var xml = XElement.Load("file-system.xml");

            foreach (var leaf in xml.FindElements(x=> !x.HasElements))
            {
                Console.WriteLine($"***** LEAF: {leaf.Attribute("name")}, {leaf.Attribute("fileBytes")}");
            }
        }
    }
}

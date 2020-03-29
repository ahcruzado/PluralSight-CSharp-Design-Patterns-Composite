using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PluralSight_CSharp_Design_Patterns_Composite.CompositesInNet
{
    public static class Extensions
    {
        public static IEnumerable<XElement> FindElements(this XElement root, Predicate<XElement> predicate)
        {
            var stack = new Stack<XElement>();
            stack.Push(root);
            
            while (stack.Any())
            {
                var current = stack.Pop();
                foreach (var element in current.Elements())
                {
                    stack.Push(element);
                }
                if (predicate(current))
                {
                    yield return current;
                }
            }            
        }
    }
}

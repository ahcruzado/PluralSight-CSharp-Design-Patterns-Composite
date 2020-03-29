using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_CSharp_Design_Patterns_Composite.Structural
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name):base(name)
        {

        }
        public override void Add(Component c)
        {
            this.children.Add(c);
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine(new string('-',depth) + this.Name);
            foreach( var component in this.children)
            {
                component.PrimaryOperation(depth + 1);
            }
        }

        public override void Remove(Component c)
        {
            this.children.Remove(c);
        }
    }
}

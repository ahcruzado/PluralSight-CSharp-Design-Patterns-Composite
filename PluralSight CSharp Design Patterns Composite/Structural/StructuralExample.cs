using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_CSharp_Design_Patterns_Composite.Structural
{
    public static class StructuralExample
    {

        public static void Run()
        {
            var root = CreateInitialStructure();

            //Add and remove leaf       }
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            //Recursively display tree
            root.PrimaryOperation(1);

            
        }

        static Composite CreateInitialStructure()
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var composite01 = new Composite("Composite C1");
            composite01.Add(new Leaf("Leaf C1-A"));
            composite01.Add(new Leaf("Leaf C1-B"));

            var composite02 = new Composite("Composite C2");
            composite02.Add(new Leaf("Leaf C2-A"));

            composite01.Add(composite02);

            root.Add(composite01);
            root.Add(new Leaf("Leaf C"));

            return root;
        }

    }
}

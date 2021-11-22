using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Composite
{
    public class Descendant : FamilyMember
    {
        public Descendant(string name) : base (name) { }

        public override void Add(FamilyMember member)
        {
            //Operation not permitted.
        }

        public override string DescendantToString()
        {
            return "Name:" + name;
        }
    }
}

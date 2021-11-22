using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Composite
{
    public abstract class FamilyMember
    {
        protected string name;

        public FamilyMember(string name)
        {
            this.name = name;
        }

        public abstract void Add(FamilyMember member);

        public abstract string DescendantToString();
    }
}

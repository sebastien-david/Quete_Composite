using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Composite
{
    public class Person : FamilyMember
    {
        List<FamilyMember> listMember = new List<FamilyMember>();

        public Person(string name) : base(name) { }

        public override void Add(FamilyMember member)
        {
            listMember.Add(member);
        }

        public override string DescendantToString()
        {
            StringBuilder sbFamilymember = new StringBuilder();

            foreach(FamilyMember member in listMember)
            {
                sbFamilymember.Append(member.DescendantToString() + "\n");
            }

            return sbFamilymember.ToString();
        }
    }
}

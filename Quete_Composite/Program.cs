using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMember pere = new Person("Sebastien");
            FamilyMember fille = new Descendant("Ellia");
            FamilyMember fils = new Descendant("Ezio");

            pere.Add(fille);
            pere.Add(fils);

            Console.WriteLine(pere.DescendantToString());
            Console.ReadLine();
        }
    }
}

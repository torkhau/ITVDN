using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom class1 = new ClassRoom(new Pupil("Anna Chernaivan", 10, 10, 10, 10), new BadPupil("Aliaksandr Torkhau"));
            ClassRoom class2 = new ClassRoom(new Pupil("Ihar Rezanovish", 10, 10, 10, 10), new ExcelentPupil("Some name1"), new GoodPupil("Some name2"), new BadPupil("Some name3"));

            foreach(Pupil puple in class1.pupils)
            {
                if(puple != null)
                {
                    puple.Study();
                    puple.Read();
                    puple.Write();
                    puple.Relax();
                    Console.WriteLine();
                };
            };
            foreach(Pupil puple in class2.pupils)
            {
                if (puple != null)
                {
                    puple.Study();
                    puple.Read();
                    puple.Write();
                    puple.Relax();
                    Console.WriteLine();
                };
            };
            Console.ReadKey();
        }
    }
}

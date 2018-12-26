using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        protected string name;
        protected byte scoreStudy;
        protected byte scoreRead;
        protected byte scoreWrite;
        protected byte scoreRelax;

        public Pupil(string name, byte scoreStudy, byte scoreRead, byte scoreWrite, byte scoreRelax)
        {
            this.name = name;
            this.scoreStudy = scoreStudy;
            this.scoreRead = scoreRead;
            this.scoreWrite = scoreWrite;
            this.scoreRelax = scoreRelax;
        }
        public virtual void Study()
        {
            Console.WriteLine($"{name} is study on {scoreStudy}");
        }
        public virtual void Read()
        {
            Console.WriteLine($"{name} is read on {scoreRead}");
        }
        public virtual void Write()
        {
            Console.WriteLine($"{name} is write on {scoreWrite}");
        }
        public virtual void Relax()
        {
            Console.WriteLine($"{name} is relax on {scoreRelax}");
        }
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name):
            base(name, 10, 10, 10, 10)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{base.name} is excellent study");
        }

        public override void Read()
        {
            Console.WriteLine($"{base.name} is excellent read");
        }

        public override void Write()
        {
            Console.WriteLine($"{base.name} is excellent write");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} is excellent relax");
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name):
            base(name, 7, 7, 7, 7)
        {
        }
        public override void Study()
        {
            Console.WriteLine($"{name} is good study");
        }

        public override void Read()
        {
            Console.WriteLine($"{name} is good read");
        }

        public override void Write()
        {
            Console.WriteLine($"{name} is good write");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} is good relax");
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name):
            base(name, 3, 3, 3, 3)
        {
        }
        public override void Study()
        {
            Console.WriteLine($"{name} is bad study");
        }

        public override void Read()
        {
            Console.WriteLine($"{name} is bad read");
        }

        public override void Write()
        {
            Console.WriteLine($"{name} is bad write");
        }

        public override void Relax()
        {
            Console.WriteLine($"{name} is bad relax");
        }
    }
}

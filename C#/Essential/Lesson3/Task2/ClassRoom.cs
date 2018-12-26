using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        public Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupil1)
        {
            pupils[0] = pupil1;
        }

        public ClassRoom(Pupil pupil1, Pupil puple2): 
            this(pupil1)
        {
            pupils[1] = puple2;
        }

        public ClassRoom(Pupil pupil1, Pupil puple2, Pupil puple3) :
            this(pupil1, puple2)
        {
            pupils[2] = puple3;
        }
        public ClassRoom(Pupil pupil1, Pupil puple2, Pupil puple3, Pupil puple4) :
            this(pupil1, puple2, puple3)
        {
            pupils[3] = puple4;
        }
    }
}

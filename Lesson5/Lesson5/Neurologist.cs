using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Neurologist : Doctor
    {
        const int DEVIDER = 4;
        public override void Cure(Patient patient)
        {
            patient.IsSick = false;
        }

        public override void Inspect(Patient patient)
        {
            var random = new Random();
            var chance = random.Next(0,10);
            if (chance > DEVIDER) 
            {
                patient.IsSick = true;
            }
            else
            {
                patient.IsSick = false;
            }
        }
        public Neurologist(string name, long id)
        {
            Name = name;
            DoctorID = id;
        }
    }
}

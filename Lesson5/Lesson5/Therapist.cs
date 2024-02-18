namespace Lesson5
{
    internal class Therapist : Doctor
    {
        public override void Cure(Patient patient)
        {
            patient.CureHimself();
        }

        public override void Inspect(Patient patient)
        {
            if (!patient.IsAlive)
            {
                Console.WriteLine("Holy shit u r a zombie");
            }
            Console.WriteLine("I am busy come next time");
        }
        public Therapist(string name, long id)
        {
            Name = name;
            DoctorID = id;
        }
    }
}

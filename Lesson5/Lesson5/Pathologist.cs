namespace Lesson5
{
    internal class Pathologist : Doctor
    {
        public override void Cure(Patient patient)
        {
            Console.WriteLine("I am not a saint");
        }

        public override void Inspect(Patient patient)
        {
            if (patient.IsAlive)
            {
                Console.WriteLine($"{patient.Name} Get out now!");
            }

        }
        public Pathologist(string name, long id) 
        {
            Name = name;
            DoctorID = id;
        }
    }
}

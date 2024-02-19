namespace Lesson5
{
    internal abstract class Doctor
    {
        public long DoctorID { get; init; }
        public  string Name { get; set; }
        public abstract void Inspect(Patient patient);
        public abstract void Cure(Patient patient);
    }
}

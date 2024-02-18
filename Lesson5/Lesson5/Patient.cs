namespace Lesson5
{
    internal class Patient
    {
        private const int DEVIDER = 5;
        public long PatientId { get; init; }
        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        public bool IsSick { get; set; } = false;

        public void GetSick()
        {
            IsSick=true;
            Console.WriteLine("I AM SICK");
        }
        public void CureHimself()
        {
            if (!IsAlive)
            {
                return;
            }
            var random = new Random();
            var chance = random.Next(0, 10);
            if (chance<DEVIDER)
            {
                IsAlive = false;
            }
            else
            {
                IsSick=false;
            }
        }
        public Patient(long patientId, string name)
        {
            PatientId = patientId;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name} IsAlive {IsAlive} IsSick {IsSick}";
        }
    }
}

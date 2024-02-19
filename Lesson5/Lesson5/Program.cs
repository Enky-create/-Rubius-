using Lesson5;

Console.WriteLine("30 people came to check their health at a public hospital \n " +
    "Thats how it was before they go to hospital");

List<Patient> patients = new List<Patient>();
List<Doctor> doctors = new List<Doctor>();
doctors.Add(new Pathologist("Irina",0));
doctors.Add(new Therapist("Anna", 1));
doctors.Add(new Neurologist("Anton",2));

for (int i = 0; i < 30; i++)
{
    patients.Add(item: new Patient (i, $"Patient {i}"));
}
foreach(Patient patient in patients)
{
    Console.WriteLine(patient);
}
foreach(Patient patient in patients)
{
    foreach(Doctor doctor in doctors)
    {
        doctor.Inspect(patient);
    }
}

foreach(Patient patient in patients)
{
    var isAlive = patient.IsAlive ? "alive" : "dead";
    var isSick = patient.IsSick ? "sick" : "healthy";
    Console.WriteLine($"{patient.Name} {isAlive} {isSick} ");
}

Console.WriteLine("Draw your own conclusions");
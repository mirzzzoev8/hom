using Task3;
Doctor doctor = new Doctor();
doctor.FullName = Console.ReadLine();
doctor.Speciality = Console.ReadLine();
doctor.Experience = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(doctor.TreatPatient("Ali"));
System.Console.WriteLine(doctor.PerformMedicalExamination("Ali"));
System.Console.WriteLine(doctor.PrescribeMedication("Ali","parasetamol"));




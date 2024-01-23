namespace Task3;

public class Doctor
{
   public string FullName;
   public string Speciality;
   public int Experience;
   public Doctor() {}
   public Doctor(string name, string spes) {
    FullName = name;
    Speciality = spes;
   }
   public Doctor(string name, string spes, int exp) {
    FullName = name;
    Speciality = spes;
    Experience = exp;
   }
   public string TreatPatient(string patientName){
    return $"{FullName} {Speciality} is treating a patient named {patientName} ";
   } 
   public string PerformMedicalExamination(string patientName){
    return $"{FullName} is performing a medical examination for the patient named {patientName}";
   }
   public string PrescribeMedication(string patientName, string medication){
        return $"{FullName} prescribes {medication} for the  patient named {patientName} ";

   }
   public int SetExperience(int years){
    return Experience = years;
   }
   public int GetExperience(){
    return Experience;
   }


}

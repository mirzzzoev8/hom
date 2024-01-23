namespace Task1;

public class Teacher
{
   public string FullName;
   public string Subject;
   public int Experience;
   public string Teach(){
    return $"{FullName} is teaching {Subject}";
   }
   public int SetExperience(int years){
    return Experience = years;
   }
   public int GetExperience(){
    return Experience;
   }
   public Teacher(){}
   public Teacher(string _name, string _subject){
    FullName = _name;
    Subject = _subject;
   }
    public Teacher(string _name, string _subject, int _expirience){
    FullName = _name;
    Subject = _subject;
    Experience = _expirience;

   }
}

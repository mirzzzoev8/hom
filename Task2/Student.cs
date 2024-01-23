namespace Task2;

public class Student
{
   public string FullName;
   public int Age;
   public int Grade;
   public Student(){}
   public Student(string _name, int _age){
    FullName = _name;
    Age = _age;
   }
    public Student(string _name, int _age, int _grade){
    FullName = _name;
    Age = _age;
    Grade = _grade;

   }
   public void Study(){
     System.Console.WriteLine(FullName + "is studing");
   }
   public void SetGrade(int newGrade){
     Grade = newGrade;
   }
   public int GetGrade(){
    return Grade;
   }
   
}

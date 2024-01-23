namespace Task4;

public class Actor {
    string fullName;
    string gender;
    int age;
    List<string> moviesPlayed;
     

    public Actor(){}
    public Actor(string name, int sub, string gender){
        fullName = name;
        age = sub ;
        this.gender = gender;
    }

    
    public void AddMovie(string movieTitle){
        moviesPlayed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed(){
       return moviesPlayed;
    }
   
     public void SetAge(int years){
        age = years;
    }
    public int GetAge(){
        return age;
    }
     public void SetGender(string gender1){
        gender = gender1;
    }
    public string GetGender(){
        return gender;
    }
    
}

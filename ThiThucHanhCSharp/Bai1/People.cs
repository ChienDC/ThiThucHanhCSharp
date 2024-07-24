namespace ThiThucHanhCSharp.Bai1;

class People
{
    // public string Name { get; set; }
    // public bool Gender { get; set; }
    // public int Age { get; set; }
    //
    // public People(string name, bool gender, int age)
    // {
    //     Name = name;
    //     Gender = gender;
    //     Age = age;
    // }
    //
    // public void DisplayDetails()
    // {
    //     string genderString = Gender ? "Male" : "Female";
    //     Console.WriteLine($"Person details: Name = {Name}, Gender = {genderString}, Age = {Age}");
    // }
    //
    // public void IncrementAge()
    // {
    //     Age += 10;
    // }
    public string Name { get; set; }
    public bool Gender { get; set; } 
    public int Age { get; set; }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Person details: Name = {Name}, Gender = {(Gender ? "Male" : "Female")}, Age = {Age}");
    }
    
    public void IncrementAge(int incrementValue)
    {
        Age += incrementValue;
    }
}
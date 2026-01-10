using System;
class Student{
    public string Name;
    public int Age;
    public string Grade;
    // default constructor
    public Student(){
        Name="Hellen Doe";
        Age=21;
        Grade="A";
    }
    // parameterized constructor
    public Student(string Name,int Age, string Grade){
        this.Name=Name;
        this.Age=Age;
        this.Grade=Grade;
    }
    public void DisplayDfault(){
        Console.WriteLine("Default Students: ");
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Age: "+Age);
        Console.WriteLine("Grade: "+Grade);
    }
    public void DisplayDetails(){
        Console.WriteLine("New Students: ");
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Age: "+Age);
        Console.WriteLine("Grade: "+Grade);
    }
}
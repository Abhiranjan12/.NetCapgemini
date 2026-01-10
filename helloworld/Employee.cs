using System;

class Employee{
    int id;
    string name;
    string dept;
    float salry;
    char gend;
    public void acceptDetails(){
        Console.Write("Enter ID: ");
        id=int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        name=Console.ReadLine();
        Console.Write("Enter Department: ");
        dept=Console.ReadLine();
        Console.Write("Enter Salary: ");
        salry=float.Parse(Console.ReadLine());
        Console.Write("Enter Gender: ");
        gend=char.Parse(Console.ReadLine());
    }
    public void displayDetails(){
        Console.WriteLine("Id of employee is: "+id);
        Console.WriteLine("Name of employee is: "+name);
        Console.WriteLine("Dept of employee is: "+dept);
        Console.WriteLine("salary of employee is: "+salry);
        Console.WriteLine("Gend of employee is: "+gend);

    }
    
}
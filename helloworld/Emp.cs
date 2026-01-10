using System;

public class Emp {
    // Private fields
    private int empId;
    private string name;
    private string dept;
    private float salry;
    private bool status;

    // Property (Getter/Setter)
    public int EmpProperty { // Maine iska naam badal diya taaki confusion na ho
        get {
            return empId;
        }
        set {
            empId = value;
        }
    }

    public void acceptDetails() {
        Console.WriteLine("Enter the emp detail: ");
        Console.Write("Enter empId: ");
        empId = int.Parse(Console.ReadLine());
        
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        
        Console.Write("Enter dept: ");
        dept = Console.ReadLine();
        
        Console.Write("Enter salry: ");
        salry = float.Parse(Console.ReadLine());
        
        Console.Write("Enter status (true/false): ");
        status = bool.Parse(Console.ReadLine());
    }

    public void displayDetails() {
        Console.WriteLine("\nEmployee details are: ");
        Console.WriteLine("Employee id is: " + empId);
        Console.WriteLine("Employee name is: " + name);
        Console.WriteLine("Employee dept is: " + dept);
        Console.WriteLine("Employee salry is: " + salry);
        Console.WriteLine("Employee status is: " + status);
    }

    
}
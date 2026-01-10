// using System.Dynamic;

// class Student{
//     public String Name{get;set;}
//     public int Age{get;set;}

//     public void GetInfo()
//     {
//         Console.Write("Enter the name: ");
//         Name=Console.WriteLine();
//         Console.WriteLine("Enter the age: ");
//         Age=int.Parse(Console.WriteLine());
//     }
//     public void DisplayInfo()
//     {
//         Console.WriteLine("The details are: ");
//         Console.WriteLine("Name is: "+Name);
//         Console.WriteLine("Age is: "+Age);
//     }
//     public static void Main(String[] args)
//     {
//         Student s=new Student();
//         s.GetInfo();
//         s.DisplayInfo();
//     }

// }

// Create a base class Animal and a derived class Dog that overrides a method.

// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.Write("sound of animal");
//     }
// }
// class Dog: Animal
// {
//     public override void Speak()
//     {
//         Console.Write("Dog barks");
//     }
// }
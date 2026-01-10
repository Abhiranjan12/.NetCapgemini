// using System;
// class Employee{
//     protected int Eid,Eage;
//     protected string Ename,EAdress;
//     protected float Salary;
//     public virtual void GetEmployeeDetails(){
//         Console.WriteLine("Enter the Employee Details");
//         Console.WriteLine("Enter the iD: ");
//         Eid=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the Age: ");
//         Eage=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the Ename: ");
//         Ename=Console.ReadLine();
//         Console.WriteLine("Enter the Eaddress: ");
//         EAdress=Console.ReadLine();
//         Console.WriteLine("Enter the Salary: ");
//         Salary=float.Parse(Console.ReadLine());
//     }
//     public virtual void EmployeeDetails(){
//         Console.WriteLine("The ID of Employee is: "+Eid);
//         Console.WriteLine("The Age of Employee is: "+Eage);
//         Console.WriteLine("The Name of Employee is: "+Ename);
//         Console.WriteLine("The Address of Employee is: "+EAdress);
//     }
//     public virtual void CalculateSalry(){
//         Console.WriteLine("The Salary of Employee is: "+Salary);
//     }
// }
// sealed class Manager:Employee{
//     double bonus,CA;
//     public sealed override void GetEmployeeDetails(){
//         Console.WriteLine("Enter the Employee Details");
//         Console.WriteLine("Enter the iD: ");
//         Eid=int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the Ename: ");
//         Ename=Console.ReadLine();
//         Console.WriteLine("Enter the bonus:");
//         bonus=float.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the CA: ");
//         CA=float.Parse(Console.ReadLine());
//     }
//     public sealed override void EmployeeDetails(){
//         Console.WriteLine("The ID of Employee is: "+Eid);
//         Console.WriteLine("The Age of Employee is: "+Eage);
//         Console.WriteLine("The Name of Employee is: "+Ename);
//         Console.WriteLine("The bonus of Employee is: "+bonus);
//         Console.WriteLine("The CA of Employee is: "+CA);
//     }
//     public sealed override void CalculateSalry(){
//         double totalSal=Salary+bonus+CA;
//         Console.WriteLine("The Salary of Employee is: "+totalSal);
//     }

//     public static void Main(string[] args){
//         int n=Console.ReadLine();
        
//     }
// }

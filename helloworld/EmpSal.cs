using System;

class EmpSal{
    int eno;
    string eName;
    float bSalary;
    public void acceptDetails(){
        Console.WriteLine("Enter the emp detail");
        Console.Write("Enter Emp No: ");
        eno = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        eName = Console.ReadLine();
        Console.Write("Enter Basic Salary: ");
        bSalary = float.Parse(Console.ReadLine());
    }
    public float getPf(){
        return 0.12f*bSalary;
    }
    public float getHra(){
        return 0.20f*bSalary;
    }
    public float getDa(){
        return 0.15f*bSalary;
    }
    public float grossSalary(){
        return getPf()+getHra()+getDa()+bSalary;
    }
    public float netSlary(){
        return grossSalary()-getPf();
    }
}
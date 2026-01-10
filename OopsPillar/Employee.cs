using System;
class Employee{
    public int Empid{get;set;}
    public string Name{get;set;}
    public float Salary{get;set;}
    public Employee(){
        Empid=0;
        Name=string.Empty;
        Salary=0.0f;
    }
    //parametrized
    public Employee(int Empid,string Name,float Salary){
        this.Empid=Empid;
        this.Name=Name;
        this.Salary=Salary;
    }
    public override string ToString(){
    return "Employee details are\n"+
           "Empid is: " +Empid+"\n"+
           "Name is: " +Name+"\n"+
           "salary is: " +Salary;
    }
}
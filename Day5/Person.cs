using System;
class Person{
    public string name{get;set;}
    public int age{set;get;}
    string address{get;set;}
    public Person(string name,int age,string address){
        this.name=name;
        this.age=age;
        this.address=address;
    }
    public void DisplayDetails(){
        Console.WriteLine("Persons's Information: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Address: "+address);
    }
}
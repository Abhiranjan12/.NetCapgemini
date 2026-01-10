using System;
class CarInfo{
    public string Make;
    public string Model;
    public int Year;

    public CarInfo(string Make,string Model,int Year){
        this.Make=Make;
        this.Model=Model;
        this.Year=Year;
    }

    public void DisplayDetails(){
        Console.WriteLine("Car Details: ");
        Console.WriteLine("Make: "+Make);
        Console.WriteLine("Model: "+Model);
        Console.WriteLine("Year: "+Year);
    }

    public void DisplayAge(){
        int age=2025-Year;
        Console.WriteLine("car Age: "+age+" Years");
    }
}
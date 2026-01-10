using System;
class Program{
    public static void Main(string[] args){
        // Employee emp=new Employee{
        //     Empid=123,
        //     Name="Abhiranjan..",
        //     Salary=1200000
        // };
        // Console.WriteLine("Employee id is: "+emp.Empid);
        // Console.WriteLine("Employee name is: "+emp.Name);
        // Console.WriteLine("Employee salary is: "+emp.Salary);
        // //Console.WriteLine(emp);
        // Console.WriteLine(emp.ToString());

        // params array in csharp
        // Program p=new Program();
        //p.Add(10,20,30,40,50,60);
        // Calculator c=new Calculator();
        // Console.WriteLine(c.Add(2));
        // Console.WriteLine(c.Add(2,4));
        // Console.WriteLine(c.Add("abhiranjan","kumar"));

        // Vehicle v=new Vehicle(50.07,5.0,10.0);
        // v.Average();
        // v.Speed();

        // Car c=new Car(500.07,1500.0,100.0);
        // c.Average();
        // c.Speed();

        // Furniture b=new Bookselve();  // refrence variable of furniture
        // b.Accept();
        // b.Display();
        // b.MyMethod();
        // Furniture c=new Chair();
        // c.Accept();
        // c.Display();
        // double value;
        // string ch,fromUnit,toUnit;
        // Console.WriteLine("Enter the case: ");
        // ch=Console.ReadLine();
        // UnitConvertor u=new UnitConvertor();
        // switch(ch){
        //     case "Length":
        //     Console.Write("Enter the Value: ");
        //     value=double.Parse(Console.ReadLine());
        //     Console.Write("Enter fromUnit: ");
        //     fromUnit=Console.ReadLine();
        //     Console.Write("Enter toUnit: ");
        //     toUnit=Console.ReadLine();
        //     Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
        //     Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
        //     break;
        //     case "Width":
        //     Console.Write("Enter the Value: ");
        //     value=double.Parse(Console.ReadLine());
        //     Console.Write("Enter fromUnit: ");
        //     fromUnit=Console.ReadLine();
        //     Console.Write("Enter toUnit: ");
        //     toUnit=Console.ReadLine();
        //     Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
        //     Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
        //     break;
        //     case "Temp":
        //     Console.Write("Enter the Value: ");
        //     value=double.Parse(Console.ReadLine());
        //     Console.Write("Enter fromUnit: ");
        //     fromUnit=Console.ReadLine();
        //     Console.Write("Enter toUnit: ");
        //     toUnit=Console.ReadLine();
        //     Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
        //     Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
        //     break;
        //     default:
        //     Console.WriteLine("Error from unit");
        //     break;
        // }
        int mId = int.Parse(Console.ReadLine());
        string mSize = Console.ReadLine();
        int wId = int.Parse(Console.ReadLine());
        string wSize = Console.ReadLine();
        string wMat = Console.ReadLine();
        int kId = int.Parse(Console.ReadLine());
        string kSize = Console.ReadLine();
        Men m = new Men(mId, mSize);
        Women w = new Women(wId, wSize, wMat);
        Kids k = new Kids(kId, kSize);
        m.DisplayInfo();
        w.DisplayInfo();
        k.DisplayInfo();
    
    }
    public void Add(params int []arr){
        int sum=0;
        for(int i=0;i<arr.Length;i++) sum+=arr[i];
        Console.WriteLine("the sum is: "+sum);
    }
}
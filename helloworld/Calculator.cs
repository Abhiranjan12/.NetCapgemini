using System;
class Calculator{
    int num1;
    int num2;
    int res;
    public void getdata(){
        Console.WriteLine("Enter the 1st no: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2nd no: ");
        num2=int.Parse(Console.ReadLine());
    }
    public void doAddition(){
        res=num1+num2;
        Console.WriteLine("Sum of no is "+res);
    }
    public void doSubtraction(){
        res=num1-num2;
        Console.WriteLine("Diff of no is "+res);
    }
    public void doMultiplication(){
        res=num1*num2;
        Console.WriteLine("Mul of no is "+res);
    }
    public void doDivision(){
        res=num1/num2;
        Console.WriteLine("Div of no is "+res);
    }
     public void swap(int num1,int num2){
        int temp=0;
        
        Console.WriteLine($"Before swapping {num1} and {num2}");
        temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine($"After swapping {num1} and {num2}");
    }
    //inout parameter pass by reference  
    public void swap1(ref int num1,ref int num2){
        int temp=0;
        
        Console.WriteLine($"Before swapping {num1} and {num2}");
        temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine($"After swapping {num1} and {num2}");
    }
    public void Addition(int n1,int n2, out int result,out int n3,out int n4){
        n3=n1;
        n4=n2;
        result=n1+n2;
    }
}
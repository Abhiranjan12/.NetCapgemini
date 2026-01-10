using System;
class Calculator{
    // function overloading
    public int Add(int n){
        return n;
    }
    public int Add(int no1,int no2){
        Console.WriteLine("The sum is: "+(no1+no2));
        return no1+no2;
    }
    public string Add(string s1,string s2){
        Console.WriteLine("the name is: "+s1+" "+s2);
        return s1+" "+s2;
    }
}
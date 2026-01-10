using System;

class Day4{
   // --- 1. Properties (Auto-implemented) ---
    public int Number1 {get; set;}
    public int Number2 {get; set;}
    public int Result {get; set;}
    // --- 2. Constructors ---
    // Default Constructor
    public Day4(){
        Number1 = 0;
        Number2 = 0;
        Result = 0;
    }
    // Parameterized Constructor
    public Day4(int number1, int number2){
        this.Number1 = number1;
        this.Number2 = number2;
    }
    // --- 3. Methods ---
    // A. Method with parameter and return type
    public int Add(int n1, int n2) {
        return n1 + n2;
    }
    // B. Method without parameter with return type
    public int Sub(){
        int num1 = 90;
        int num2 = 80;
        return num1 - num2;
    }
    // C. Method with parameter without return type (void)
    public void Add1(int n1, int n2){
        Console.WriteLine("The sum is : " + (n1 + n2));
    }
    // D. Method without parameter without return type (void)
    public void Sub1(){
        int num1 = 90;
        int num2 = 110;
        Console.WriteLine("The diff is: " + (num2 - num1));
    }

    // public void Square(ref int n) {
    //     n = n * n;
    // }
    // public void SquareNormal(int n) {
    //     n = n * n;
    // }

    //inparameter passbyvalue
}

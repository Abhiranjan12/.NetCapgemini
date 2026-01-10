using System;
class Program
{
    int number1;
    int number2;
    int result;
    public void Add()
    {
        Console.WriteLine("Enter first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        result = number1 + number2;
        Console.WriteLine("Sum of the Number is: " + result);
    }
    public void Subtract()
    {
        Console.WriteLine("Enter first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        result = number1 - number2;
        Console.WriteLine($"Substraction of the Number {number1} and {number2} is: " + result);
    }
    public void Multiply()
    {
        Console.WriteLine("Enter first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        result = number1 * number2;
        Console.WriteLine($"Product of the Number {number1} and {number2} is: {result}");
    }
    public void Divide()
    {
        Console.WriteLine("Enter first number:");
        number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2=Convert.ToInt32(Console.ReadLine());
        result = number1 / number2;
        Console.WriteLine($"Division of the Number {number1} and {number2} is: {result}");
    }
    public void Reminder()
    {
        Console.WriteLine("Enter first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        result = number1 % number2;
        Console.WriteLine($"Reminder of the Number {number1} and {number2} is: {result}");
    }
}
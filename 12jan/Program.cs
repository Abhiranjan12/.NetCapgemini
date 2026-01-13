// using System;
// class Program
// {
//     public static void Mymethod(dynamic dy)
//     {
//         Console.WriteLine("Details of employee using dynamic keyword:");
//         Console.WriteLine("Name of employee is: " + dy.name);
//         Console.WriteLine("Id of employee is: " + dy.Id);
//         Console.WriteLine("City of employee is: " + dy.city);
//     }
//     public delegate void Print(int num1, int num2);
//     public static void takedelegateparameter(Print p, int val1, int val2)
//     {
//         p(val1, val2);
//     }
//     public static void Main(string[] args)
//     {
//         // Anonymous method passed as parameter
//         takedelegateparameter(delegate (int num1, int num2)
//         {
//             Console.WriteLine("sum of two numbers using delegate as parameter: " + (num1 + num2));
//         }, 10, 20);
//         // Anonymous method assigned to delegate
//         Print p = delegate (int num1, int num2)
//         {
//             Console.WriteLine("sum of two numbers is: " + (num1 + num2));
//         };
//         p(10, 20);
//         // Anonymous type
//         var anonyms = new
//         {
//             name = "Abhi",
//             Id = 101,
//             city = "hyderabad",
//         };
//         Console.WriteLine("Name of employee is: " + anonyms.name);
//         Console.WriteLine("Id of employee is: " + anonyms.Id);
//         Console.WriteLine("City of employee is: " + anonyms.city);
//         Mymethod(anonyms);
//     }
// }

using System;
class Calculator
{
    public int add(int a,int b)
    {
        return a+b;
    }
}
static class calculatorExtension
{
        public static int Subtract(this Calculator calc, int a, int b)
        {
            return a - b;
        }

        public static int Multiply(this Calculator calc, int a, int b)
        {
            return a * b;
        }

        public static int Divide(this Calculator calc, int a, int b)
        {
            return a / b;
        }
}
class Program
{
    public static void Main(string[] args)
    {
        Calculator c=new Calculator();
        Console.WriteLine(c.add(10,20));
        Console.WriteLine(c.Subtract(300,40));
        Console.WriteLine(c.Multiply(10,20));
        Console.WriteLine(c.Divide(400,40));
    }
}
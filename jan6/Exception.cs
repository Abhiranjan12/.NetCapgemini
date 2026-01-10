//=============================Exception Handling==================================
//         // int num1=0;
//         // int num2=0;
//         // int result=0;
//         // Console.WriteLine("Enter num1: ");
//         // num1=int.Parse(Console.ReadLine());
//         // Console.WriteLine("Enter num2: ");
//         // num2=int.Parse(Console.ReadLine());
//         // try{
//         // result=num1/num2;
//         // }
//         // catch
//         // {
//         //     Console.WriteLine("cannot divide by zero");
//         // }
//         // finally{
//         // Console.WriteLine("division of num1 and num2 is: "+result);
//         // }


//         int num1=0;
//         int num2=0;
//         int result=0;
//         int[] arr={3,4,2,3,4,5};
//         try{
//             Console.WriteLine("Enter num1: ");
//             num1=int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter num2: ");
//             num2=int.Parse(Console.ReadLine());
//             result=num1/num2;
//             for(int i=0;i<7;i++) Console.WriteLine(arr[i]);
//         }
//         catch(IndexOutOfRangeException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(DivideByZeroException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(FormatException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         finally{
//             Console.WriteLine("division of num1 and num2 is: "+result);
//         }
// using System;
// class MyException:Exception
// {
//     public MyException(string str)
//     {
//         Console.WriteLine("User defined exception");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             throw new MyException("Abhi");
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine("Exception caught here:b"+e.Message);
//         }
//     }
// }

// using System;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
// public class TypeException : Exception
// {
//     public TypeException(string message) : base(message)
//     {
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         double temp=0;
//         double ans=0;
//         try
//         {
//             Console.WriteLine("Enter the temp: ");
//             temp=double.Parse(Console.ReadLine());
//             Console.WriteLine("Enter the degree name: ");
//             char conv=char.ToUpper(char.Parse(Console.ReadLine()));
//             if (conv == 'F')
//             {
//                 ans=(temp - 32) * 5 / 9;
//                 Console.WriteLine("Temperature in Celcius: "+ans);
//             }
//             else if (conv == 'C')
//             {
//                 ans=(temp * 9 / 5) + 32;
//                 Console.WriteLine("Temperature in Fahrenheit: "+ans);
//             }
//             else
//             {
//                  throw new TypeException("Please enter 'C' or 'F'.");
//             }
//         }catch(FormatException e)
//         {
//             Console.WriteLine("Error: Invalid input provided.");
//             Console.WriteLine("Exception Message: "+e.Message);
//         }
//     }
// }


// class CricketMatch
// {
//     public int[] playerScores;
//     public int Currentindex;
//     public CricketMatch()
//     {
//         playerScores=new int[5];
//         Currentindex=0;
//     }
//     public void AddCricketScore(int score)
//     {
//         if(score<0 || score > 50)
//         {
//             throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
//         }
//         else if (Currentindex >= 5)
//         {
//             throw new InvalidOperationException("Cannot add more than 5 player scores.");
//         }
//         playerScores[Currentindex++]=score;
//     }
//     public int TotalScore()
//     {
//         int sum=0;
//         for(int i = 0; i < 5; i++)
//         {
//             sum+=playerScores[i];
//         }
//         return sum;
//     }

//     public static void Main(string[] args)
//     {
//         CricketMatch c=new CricketMatch();
//         try{
//             Console.WriteLine("Enter input: ");
//             string input=Console.ReadLine();
//             string[] str=input.Split(" ");
//             foreach(var i in str)
//             {
//                 int run=int.Parse(i);
//                 c.AddCricketScore(run);
//             }
//             Console.WriteLine("The total Score is: "+c.TotalScore());
//             }
//         catch (ArgumentException e)
//         {
//             Console.WriteLine("Error: "+e.Message);
//         }
//         catch (InvalidOperationException e)
//         {
//             Console.WriteLine("Error: "+e.Message);
//         }
//     }
// }

using System;

class ArraySum
{
    public int Sum(int idx, int[] arr1, int[] arr2)
    {
        return arr1[idx] + arr2[idx];
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = int.Parse(Console.ReadLine());
            }
        Console.WriteLine("Enter the idx: ");
        int idx=int.Parse(Console.ReadLine());
        ArraySum a = new ArraySum();
        try
        {

            if (idx >= n)
            {
                throw new IndexOutOfRangeException();
            }
            Console.WriteLine("Element at index 2 in the sum array: " +a.Sum(idx, arr1, arr2));
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please enter valid integers only.");
            Console.WriteLine("Error: "+e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index is out of range.");
            Console.WriteLine("Error: "+e.Message);
        }
    }
}

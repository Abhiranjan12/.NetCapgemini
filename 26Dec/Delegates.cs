using System;

// ================== Delegate Example ==================
public delegate int Calculatedelegate(int num1, int num2);

class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Sub(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Mul(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Div(int num1, int num2)
    {
        return num1 / num2;
    }
}

// ================== Event, Func, Action, Predicate ==================
public class AddTwoNumber
{
    // Declare delegate
    public delegate void dg_OddNumber();

    // Declare event
    public event dg_OddNumber ev_OddNumber;

    public void Add()
    {
        int result = 9 + 4;
        Console.WriteLine("Result: " + result);

        if (result % 2 != 0 && ev_OddNumber != null)
        {
            ev_OddNumber();
        }
    }

    private static int AddNumber(int param1, int param2)
    {
        return param1 + param2;
    }

    private static void AddNumber1(int param1, int param2)
    {
        int result = param1 + param2;
        Console.WriteLine("The sum is: " + result);
    }

    private static bool IsApple1(string modelName)
    {
        return modelName == "Iphone X";
    }

    static void EventMessage()
    {
        Console.WriteLine("Event occurred");
    }

    // ================== Main ==================
    public static void Main(string[] args)
    {
        // ----- Event Example -----
        AddTwoNumber aa = new AddTwoNumber();
        aa.ev_OddNumber += EventMessage;
        aa.Add();

        // ----- Func -----
        Func<int, int, int> add = AddNumber;
        Console.WriteLine("Func sum: " + add(10, 20));

        // ----- Action -----
        Action<int, int> addition = AddNumber1;
        addition(39, 438);

        // ----- Predicate -----
        Predicate<string> st = IsApple1;
        Console.WriteLine("Predicate result: " + st("Iphone X"));

        // ----- Delegate & Multicast Delegate -----
        Calculator c = new Calculator();

        Calculatedelegate cadd = c.Add;
        Calculatedelegate csub = c.Sub;
        Calculatedelegate cmul = c.Mul;
        Calculatedelegate cdiv = c.Div;

        Console.WriteLine("Add: " + cadd(10, 30));
        Console.WriteLine("Sub: " + csub(10, 30));
        Console.WriteLine("Mul: " + cmul(10, 30));
        Console.WriteLine("Div: " + cdiv(30, 10));

        Calculatedelegate multidelegate = cadd;
        multidelegate += csub;
        multidelegate += cmul;
        multidelegate += cdiv;

        // Multicast delegate returns LAST method result
        Console.WriteLine("Multicast result: " + multidelegate(300, 60));
    }
}

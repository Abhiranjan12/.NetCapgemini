// using System;
// using System.Collections;
// class Collection
// {
//     public static void Main(string[] args)
//     {
//         Hashtable hs=new Hashtable();
//         hs.Add(1,"Mohan");
//         hs.Add(2,"Sohan");
//         hs.Add(3,"Gita");
//         hs.Add(4,"Ramu");
//         hs.Add(5,"Meher");
//         hs.Add(6,"Mayank");
//         //===========PRINT METHOD====================
//         // ICollection key=hs.Keys;
//         // Console.WriteLine("The key are: ");
//         // foreach(var k in key)
//         // {
//         //     Console.WriteLine(k);
//         // }
//         // ICollection val=hs.Values;
//         // Console.WriteLine("The values are: ");
//         // foreach(var v in val)
//         // {
//         //     Console.WriteLine(v);
//         // }
//         // foreach(DictionaryEntry d in hs)
//         // {
//         //     Console.WriteLine("Key is: "+d.Key+" value is: "+d.Value);
//         // }

//         //==========SOME EXTRA METHOD=================

//         // if(hs.ContainsKey(3) && hs.ContainsValue("Meher")) Console.WriteLine("Key and value found");
//         // else Console.WriteLine("Key and value not found");
//         // Console.WriteLine("The size of hashtable is: "+hs.Count);
//         // hs.Remove(1);
//         // Console.WriteLine("After rempving the element");
//         // foreach(DictionaryEntry d in hs)
//         // {
//         //     Console.WriteLine("Key is: "+d.Key+" value is: "+d.Value);
//         // }        

//         //===========SORTED LIST==========
//         // SortedList st = new SortedList();
//         // st.Add(1, "CSE");
//         // st.Add(2, "MECHANICAL");
//         // st.Add(3, "CIVIL");
//         // st.Add(4, "COMMUNICATION");
//         // st.Add(5, "BBA");
//         // foreach(DictionaryEntry d in st)
//         // {
//         //     Console.WriteLine("The key: "+d.Key+" value is: "+d.Value);
//         // }
//         // if(st.ContainsKey(1) && st.ContainsValue("CSE")) Console.WriteLine("Element found");
//         // Console.WriteLine("Not found");
//         // Console.WriteLine("The size of sortedlist is: "+st.Count);
//         // st.Remove(4);
//         // Console.WriteLine("Element after deleting");
//         // foreach(DictionaryEntry d in st)
//         // {
//         //     Console.WriteLine("The key: "+d.Key+" value is: "+d.Value);
//         // }

//         //=============STACK=================
//         // Stack st=new Stack();
//         // st.Push(10);
//         // st.Push(25);
//         // st.Push(39);
//         // st.Push(23);
//         // st.Push(48);
//         // Console.WriteLine("the element of stack is: ");
//         // foreach(var i in st) Console.WriteLine(i);
//         // Console.WriteLine("The top element of stack is: "+st.Peek());
//         // st.Pop();
//         // Console.WriteLine("the element of stack after delete is: ");
//         // foreach(var i in st) Console.WriteLine(i);

//         //============QUEUE====================
//         Queue q=new Queue();
//         q.Enqueue(10);
//         q.Enqueue(83);
//         q.Enqueue(48);
//         q.Enqueue(44);
//         q.Enqueue(39);
//         Console.WriteLine("the element of queue is: ");
//         foreach(var i in q) Console.WriteLine(i);
//         Console.WriteLine("The top element of Queue is: "+q.Peek());
//         q.Dequeue();
//         Console.WriteLine("the element of Queeu after delete is: ");
//         foreach(var i in st) Console.WriteLine(i);
//     }
// }

// using System;

// namespace GenericAdditionApp
// {
//     // Generic Class definition
//     class AddGenericClass<T>
//     {
//         private T n1;
//         private T n2;
//         private T result;

//         public T MyProperty { get; set; }

//         // Generic default constructor
//         public AddGenericClass() { }

//         // Generic parameterized constructor
//         public AddGenericClass(T m, T n)
//         {
//             this.n1 = m;
//             this.n2 = n;
//         }

//         // Generic method using dynamic to allow the '+' operator
//         public T AddAllType(T num1, T num2)
//         {
//             dynamic x = num1;
//             dynamic y = num2;
//             result = x + y;
//             return result;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // 1. Handling Integers
//             AddGenericClass<int> addInteger = new AddGenericClass<int>();
//             int sumint = addInteger.AddAllType(30, 20);
//             Console.WriteLine("Integer Sum: " + sumint);

//             // 2. Handling Floats
//             AddGenericClass<float> addFloat = new AddGenericClass<float>();
//             float sumfloat = addFloat.AddAllType(30.56f, 20.77f);
//             Console.WriteLine("Float Sum: " + sumfloat);

//             // 3. Handling Strings (Concatenation)
//             AddGenericClass<string> addString = new AddGenericClass<string>();
//             string sumstring = addString.AddAllType("Abhiranjan ", "Kumar");
//             Console.WriteLine("String Result: " + sumstring);
            
//             // Wait for user input before closing
//             Console.ReadKey();
//         }
//     }
// }
// using System;
// using System.Collections;
// using System.Collections.Generic;

    // public class Employee
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }

    //     // Constructor to initialize values
    //     public Employee(int id, string name)
    //     {
    //         Id = id;
    //         Name = name;
    //     }
    // }

// public class Program
// {
//     public static void Main()
//     {
        // object o;
        // int i = 10;
        // o = i; // Boxing

        // string str;

        // int j = (int)o; // Unboxing

        // ArrayList arrayList = new ArrayList();
        // arrayList.Add(1); // Boxing
        // arrayList.Add(false); // Boxing
        // arrayList.Add(3.14f); // Boxing

        // int k = (int)arrayList[0]; // Unboxing

        // var v = arrayList[1]; // No unboxing here, v is of type object
        // bool t = (bool)v; // Unboxing

        // // var x = 0;
        // // x= "hello"; //showing error;

        // dynamic d = 10;
        // d = "hello"; //no error



        // AddClass addClass = new AddClass();
        // int sumInt = addClass.AddInt(10, 20);
        // Console.WriteLine("Sum of Integers: " + sumInt);

        // float sumFloat = addClass.AddFloat(10.5f, 20.3f);
        // Console.WriteLine("Sum of Floats: " + sumFloat);

        // string sumString = addClass.AddString("Hello, ", "World!");
        // Console.WriteLine("Concatenated String: " + sumString);

        // AddGenericClass<int> addInteger = new AddGenericClass<int>(10, 20);
        // int genericSumInt = addInteger.AddAllType(10, 20);
        // Console.WriteLine("Generic Sum of Integers: " + genericSumInt);

        // AddGenericClass<float> addFloat = new AddGenericClass<float>(10.5f, 20.3f);
        // float genericSumFloat = addFloat.AddAllType(10.5f, 20.3f);
        // Console.WriteLine("Generic Sum of Floats: " + genericSumFloat);

        // AddGenericClass<string> addString = new AddGenericClass<string>("Hello, ", "World!");
        // string genericSumString = addString.AddAllType("Hello, ", "World!");
        // Console.WriteLine("Generic Concatenated String: " + genericSumString);


        // List<Employee> employees = new List<Employee>();
        // employees.Add(new Employee { Id = 1, Name = "Gaurav" });
        // employees.Add(new Employee { Id = 2, Name = "Kundan" });
        // employees.Add(new Employee { Id = 3, Name = "Krishna" });
        // foreach (Employee emp in employees)
        // {
        //     Console.WriteLine(emp);
        // }
        // Dictionary<int, string> dict = new Dictionary<int, string>();
        // dict.Add(101, "Gaurav");
        // dict.Add(102, "Kundan");
        // dict.Add(103, "Krishna");
        // foreach(var kvp in dict)
        // {
        //     Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        // }
        // SortedList<string, string> sortedList = new SortedList<string, string>();
        // sortedList.Add("101", "Gaurav");
        // sortedList.Add("102", "Kundan");
        // sortedList.Add("103", "Krishna");
        // foreach(var kvp in sortedList)
        // {
        //     Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        // }

        // Stack<char> stack = new Stack<char>();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        // foreach(var item in stack)
        // {
        //     Console.WriteLine("Stack item: " + item);
        // }
        // stack.Pop();
        // Console.WriteLine("After Pop:");
        // foreach(var item in stack)
        // {
        //     Console.WriteLine("Stack item: " + item);
        // }
        // Queue<char> queue = new Queue<char>();
        // queue.Enqueue('X');
        // queue.Enqueue('Y');
        // queue.Enqueue('Z');
        // foreach(var item in queue)
        // {
        //     Console.WriteLine("Queue item: " + item);
        // }
        // queue.Dequeue();
        // Console.WriteLine("After Dequeue:");
        // foreach(var item in queue)
        // {
        //     Console.WriteLine("Queue item: " + item);
        // }
//     }
// }
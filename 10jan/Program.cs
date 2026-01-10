// using System;
// class InvalidPriceException : SystemException
// {
//     public InvalidPriceException()
//         : base("Error: Price must be greater than zero.")
//     {
//     }    public InvalidPriceException(string message)
//         : base(message)
//     {
//     }
// }
// class InvalidQuantityException : SystemException
// {
//     public InvalidQuantityException()
//         : base("Error: Quantity must be greater than zero.")
//     {
//     }
//     public InvalidQuantityException(string message)
//         : base(message)
//     {
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             double price = double.Parse(Console.ReadLine());
//             int quantity = int.Parse(Console.ReadLine());
//             if (price <= 0)
//             {
//                 throw new InvalidPriceException();
//             }
//             if (quantity <= 0)
//             {
//                 throw new InvalidQuantityException();
//             }
//             double totalCost = price * quantity;
//             Console.WriteLine($"Total cost is {totalCost:F1}");
//         }
//         catch (InvalidPriceException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch (InvalidQuantityException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Error: Please enter a valid number.");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Error: An unexpected error occurred.");
//         }
//     }
// }

// // using System;
// // public class Program
// // {
// //     public static void Main(string[] args)
// //     {
// //         try
// //         {
// //             int numberOfTickets = int.Parse(Console.ReadLine());
// //             decimal pricePerTicket = decimal.Parse(Console.ReadLine());
// //             if (numberOfTickets <= 0)
// //             {
// //                 throw new ArgumentException("Error: Number of tickets must be greater than 0.");
// //             }
// //             if (pricePerTicket <= 0)
// //             {
// //                 throw new ArgumentException("Error: Price per ticket must be greater than 0.");
// //             }
// //             decimal totalCost = numberOfTickets * pricePerTicket;
// //             Console.WriteLine($"Total ticket cost: {totalCost}");
// //         }
// //         catch (ArgumentException ex)
// //         {
// //             Console.WriteLine(ex.Message);
// //         }
// //         catch (FormatException)
// //         {
// //             Console.WriteLine("Error: Please enter a valid number.");
// //         }
// //         catch (Exception)
// //         {
// //             Console.WriteLine("Error: An unexpected error occurred.");
// //         }
// //     }
// // }

// using System.Collections;
// class Program
// {
//     private static bool IsValidName(string name)
//     {
//         if(string.IsNullOrWhiteSpace(name)) return false;
//         else return true;
//     }
//     private static bool IsNameInCollection(ArrayList studentNames, string name)
//     {
//         foreach(string presentname in studentNames)
//         {
//             if (presentname.Equals(name, StringComparison.OrdinalIgnoreCase))
//             {
//                 return true;
//             }
//         }
//         return false;
//     }
//     private static void DisplayStudentNames(ArrayList studentNames)
//     {
//         foreach(string name in studentNames)
//         {
//             Console.WriteLine(name);
//         }
//     }
//     public static void Main(string[] args)
//     {
//         ArrayList arr = new ArrayList();
//         while (true)
//         {
//             string name = Console.ReadLine();

//             if (name.Equals("stop", StringComparison.OrdinalIgnoreCase))
//             {
//                 break;
//             }

//             if (!IsValidName(name))
//             {
//                 continue;
//             }

//             if (IsNameInCollection(arr, name))
//             {
//                 Console.WriteLine(name + " is already in the collection.");
//             }
//             else
//             {
//                 arr.Add(name);
//                 Console.WriteLine(name + " added to the collection.");
//             }
//         }
//         Console.WriteLine("Unique student names entered:");
//         DisplayStudentNames(arr);
//     }
// }
// using System;
// using System.Collections;

// class Program
// {
//     private static void AddNumber(ArrayList list)
//     {
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out int num))
//         {
//             list.Add(num);
//             Console.WriteLine(num + " added to the number list.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void RemoveNumber(ArrayList list)
//     {
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out int num))
//         {
//             if (list.Contains(num))
//             {
//                 list.Remove(num);
//                 Console.WriteLine(num + " removed from the number list.");
//             }
//             else
//             {
//                 Console.WriteLine(num + " not found in the number list.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void DisplayNumbers(ArrayList list)
//     {
//         Console.WriteLine("Current numbers in the list:");
//         foreach (var item in list)
//         {
//             Console.WriteLine(item);
//         }
//     }

//     public static void Main(string[] args)
//     {
//         ArrayList numbers = new ArrayList();

//         while (true)
//         {
//             string command = Console.ReadLine();
//             switch (command)
//             {
//                 case "add":
//                     AddNumber(numbers);
//                     break;
//                 case "remove":
//                     RemoveNumber(numbers);
//                     break;
//                 case "display":
//                     DisplayNumbers(numbers);
//                     break;
//                 case "exit":
//                     return;
//                 default:
//                     Console.WriteLine("Invalid command.");
//                     break;
//             }
//         }
//     }
// }

// using System.Collections;
// public class Album
// {
//     public string Title { get; set; }
//     public string Artist { get; set; }
//     public Album(string title, string artist)
//     {
//         Title = title;
//         Artist = artist;
//     }
// }
// public class Program
// {
//     private static bool IsValidInput(string input)
//     {
//         if(string.IsNullOrWhiteSpace(input))return false;
//         return true;
//     }
//     private static void DisplayAlbums(ArrayList albums)
//     {
//         foreach (Album album in albums)
//         {
//             Console.WriteLine($"Title: {album.Title}, Artist: {album.Artist}");
//         }
//     }
//     public static void Main(string[] args)
//     {
//         ArrayList albums = new ArrayList();

//         while (true)
//         {
//             string title = Console.ReadLine();

//             if (title == "quit")
//                 break;

//             string artist = Console.ReadLine();

//             if (artist == "quit")
//                 break;

//             if (IsValidInput(title) && IsValidInput(artist))
//             {
//                 albums.Add(new Album(title, artist));
//             }
//         }

//         DisplayAlbums(albums);
//     }
// }

// using System.Text.Json.Serialization;

// class Student
// {
//     public int id{get;set;}
//     public string name{get;set;}
//     public string grade{get;set;}
//     public Student(int id,string name,string grade)
//     {
//        this.id=id;
//        this.name=name;
//        this.grade=grade; 
//     }
// }

// class StudentManager
// {
//     public Dictionary<int,Student> student=new Dictionary<int, Student>();
//     public void addStudents(Student student)
//     {
//         student[]
//     }
//     public void displayStudent()
//     {

//     }
//     public static void Main(string[] args)
//     {
//         StudentManager sm=new StudentManager();
//         int noofstudent;
//         noofstudent=int.Parse(Console.ReadLine());
//         for(int i = 0; i < noofstudent; i++)
//         {

//         }
//     }

// }
// using System;
// using System.Collections.Generic;

// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Grade { get; set; }
// }
// public class StudentManager
// {
//     public Dictionary<int, Student> Students { get; set; }
//     public StudentManager()
//     {
//         Students = new Dictionary<int, Student>();
//     }
//     public void AddStudent(Student student)
//     {
//         Students[student.Id] = student;
//     }

//     public void DisplayStudents()
//     {
//         Console.WriteLine("Student Information:");
//         foreach (var student in Students.Values)
//         {
//             Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
//         }
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         StudentManager manager = new StudentManager();

//         int numberOfStudents = int.Parse(Console.ReadLine());

//         for (int i = 0; i < numberOfStudents; i++)
//         {
//             int id = int.Parse(Console.ReadLine());
//             string name = Console.ReadLine();
//             string grade = Console.ReadLine();

//             Student student = new Student
//             {
//                 Id = id,
//                 Name = name,
//                 Grade = grade
//             };

//             manager.AddStudent(student);
//         }

//         manager.DisplayStudents();
//     }
// }
// using System;
// using System.Collections.Generic;

// class Program
// {
//     private static void Create(HashSet<string> hs)
//     {
//         Console.Write("Enter the string to add: ");
//         string name = Console.ReadLine();
//         if (hs.Contains(name))
//         {
//             Console.WriteLine(name + " is already present in the HashSet.");
//         }
//         else
//         {
//             hs.Add(name);
//             Console.WriteLine(name + " added successfully.");
//         }
//     }
//     private static void Read(HashSet<string> hs)
//     {
//         Console.WriteLine("Current items in the HashSet:");
//         foreach (var item in hs)
//         {
//             Console.WriteLine(item);
//         }
//     }
//     private static void Update(HashSet<string> hs)
//     {
//         Console.Write("Enter the string to update: ");
//         string oldValue = Console.ReadLine();
//         if (hs.Contains(oldValue))
//         {
//             Console.Write("Enter the new string: ");
//             string newValue = Console.ReadLine();
//             hs.Remove(oldValue);
//             hs.Add(newValue);
//             Console.WriteLine(oldValue + " has been updated to " + newValue);
//         }
//         else
//         {
//             Console.WriteLine(oldValue + " not found in the HashSet.");
//         }
//     }
//     private static void Delete(HashSet<string> hs)
//     {
//         Console.Write("Enter the string to delete: ");
//         string del = Console.ReadLine();
//         if (hs.Contains(del))
//         {
//             hs.Remove(del);
//             Console.WriteLine(del + " has been removed.");
//         }
//         else
//         {
//             Console.WriteLine(del + " not found in the HashSet.");
//         }
//     }
//     public static void Main(string[] args)
//     {
//         HashSet<string> hs = new HashSet<string>();
//         int ch;

//         while (true)
//         {
//             Console.WriteLine("\nChoose an operation: ");
//             Console.WriteLine("1: Create (Add a new string)");
//             Console.WriteLine("2: Read (Display all strings)");
//             Console.WriteLine("3: Update (Update an existing string)");
//             Console.WriteLine("4: Delete (Remove a string)");
//             Console.WriteLine("5: Exit");
//             Console.Write("Enter your choice: ");
//             if (!int.TryParse(Console.ReadLine(), out ch))
//             {
//                 Console.WriteLine("Invalid input. Please enter a number 1-5.");
//                 continue;
//             }

//             switch (ch)
//             {
//                 case 1:
//                     Create(hs);
//                     break;
//                 case 2:
//                     Read(hs);
//                     break;
//                 case 3:
//                     Update(hs);
//                     break;
//                 case 4:
//                     Delete(hs);
//                     break;
//                 case 5:
//                     Console.WriteLine("Exiting...");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice, please try again.");
//                     break;
//             }
//         }
//     }
// }
// using System;
// using System.Collections.Generic;

// class Program
// {
//     private static List<int> ParseIntegers(string input)
//     {
//         List<int> li = new List<int>();
//         string[] arr = input.Split(' ');
//         foreach (var st in arr)
//         {
//             li.Add(int.Parse(st));
//         }
//         return li;   
//     }

//     private static List<int> GetOddNumbers(List<int> numbers)
//     {
//         List<int> li = new List<int>();
//         foreach (var i in numbers)
//         {
//             if (i % 2 != 0)
//                 li.Add(i);
//         }
//         return li;
//     }

//     public static void Main(string[] args)
//     {
//         Console.Write("Enter the string in form of array: ");
//         string input = Console.ReadLine();
//         List<int> li = ParseIntegers(input);
//         List<int> li2 = GetOddNumbers(li);
//         Console.WriteLine("Odd numbers are:");
//         foreach (var i in li2)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }


// class Program
// {
//     public static void Main(string[] args)
//     {
//         string input=Console.ReadLine();
//         string[] arr=input.Split(' ');
//         List<int> li=new List<int>();
//         foreach(var i in arr)
//         {
//             int num=int.Parse(i);
//             li.Add(num*num);
//         } 
//         li.Sort();
//         foreach(var i in li) Console.WriteLine(i);
//     }
// }
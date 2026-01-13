// // using System;
// // class Program
// // {
// //     public delegate double ArithmeticOperation(double a, double b);

// //     public static double Addition(double a, double b)
// //     {
// //         return a + b;
// //     }
// //     public static double Subtract(double a, double b)
// //     {
// //         return a - b;
// //     }
// //     public static double Multiply(double a, double b)
// //     {
// //         return a * b;
// //     }
// //     public static double Divide(double a, double b)
// //     {
// //         if (b == 0)
// //         {
// //             throw new DivideByZeroException("Division by zero is not allowed.");
// //         }
// //         return a / b;
// //     }
// //     public static double PerformOperation(ArithmeticOperation operation, double a, double b)
// //     {
// //         return operation(a, b);
// //     }
// //     public static void Main(string[] args)
// //     {
// //         try
// //         {
// //             double num1 = double.Parse(Console.ReadLine());
// //             double num2 = double.Parse(Console.ReadLine());
// //             string op = Console.ReadLine().ToLower();

// //             ArithmeticOperation ope;

// //             switch (op)
// //             {
// //                 case "add":
// //                     ope = Addition;
// //                     break;
// //                 case "subtract":
// //                     ope = Subtract;
// //                     break;
// //                 case "multiply":
// //                     ope = Multiply;
// //                     break;
// //                 case "divide":
// //                     ope = Divide;
// //                     break;
// //                 default:
// //                     Console.WriteLine("Invalid operation.");
// //                     return;
// //             }

// //             double result = PerformOperation(ope, num1, num2);
// //             Console.WriteLine("The result is: " + result.ToString());
// //         }
// //         catch (DivideByZeroException ex)
// //         {
// //             Console.WriteLine("Error: " + ex.Message);
// //         }
// //     }
// // }

// using System;
// class Program
// {
//     public static void ReverseString(string str)
//     {
//         char[] arr = str.ToCharArray();
//         Array.Reverse(arr);
//         Console.WriteLine("Reversed string: " + new string(arr));
//     }
//     public static bool IsPalindrome(string str)
//     {
//         string lower = str.ToLower();
//         char[] arr = lower.ToCharArray();
//         Array.Reverse(arr);
//         return lower == new string(arr);
//     }
//     public static void Main(string[] args)
//     {
//         string oper = Console.ReadLine().ToLower();
//         string str = Console.ReadLine();
//         Action<string> printReversedString = ReverseString;
//         Func<string, bool> isPalindrome = IsPalindrome;
//         if (oper == "reverse")
//         {
//             printReversedString(str);
//         }
//         else if (oper == "palindrome")
//         {
//             bool result = isPalindrome(str);
//             Console.WriteLine("Is palindrome: " + result);
//         }
//         else
//         {
//             Console.WriteLine("Invalid operation.");
//         }
//     }
// }

// using System;

// class Account
// {
//     public string AccountNumber { get; set; }
//     public decimal Balance { get; set; }

//     public Account()
//     {
//         Balance = 1000; // initial balance
//     }

//     public decimal Deposit(decimal amount)
//     {
//         try
//         {
//             if (amount <= 0)
//             {
//                 throw new ArgumentException("Deposit amount must be positive");
//             }

//             Balance += amount;
//             return Balance;
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//             return Balance;
//         }
//     }

//     public decimal Withdraw(decimal amount)
//     {
//         try
//         {
//             if (amount <= 0)
//             {
//                 throw new ArgumentException("Withdrawal amount must be positive");
//             }
//             else if (amount > Balance)
//             {
//                 throw new InvalidOperationException("Insufficient funds");
//             }

//             Balance -= amount;
//             return Balance;
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }

//         return Balance;
//     }

//     public static void Main(string[] args)
//     {
//         Account acc = new Account();

//         Console.Write("Enter the Account number: ");
//         acc.AccountNumber = Console.ReadLine();

//         Console.WriteLine("Enter the choice:");
//         Console.WriteLine("1. Deposit");
//         Console.WriteLine("2. Withdraw");

//         int choice = int.Parse(Console.ReadLine());

//         if (choice == 1)
//         {
//             Console.Write("Enter the amount: ");
//             decimal amount = decimal.Parse(Console.ReadLine());
//             decimal balance = acc.Deposit(amount);
//             Console.WriteLine("The balance is: " + balance);
//         }
//         else if (choice == 2)
//         {
//             Console.Write("Enter the amount: ");
//             decimal amount = decimal.Parse(Console.ReadLine());
//             decimal balance = acc.Withdraw(amount);
//             Console.WriteLine("The balance is: " + balance);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Operation");
//         }
//     }
// }

// class InvalidTierException : SystemException
// {
//     public InvalidTierException(string msg):base(msg)
//     {

//     }
// }
// class Membership
// {
//     public string Tier{set;get;}
//     public int DurationinMonth{set;get;}
//     public double BasePricePerMonth{set;get;}

//     public bool ValidateEnrollment()
//     {
//         if(Tier!="Basic" || Tier!="Premium" || Tier != "Elite")
//         {
//             throw new InvalidTierException("Tier not recognized");
//         }
//         if (DurationinMonth <= 0)
//         {
//             throw new Exception("Duration must be at least one month.");
//         }
//         return true;
//     }
//     public double CalculateTotalBill()
//     {
//         double total=(DurationinMonth*BasePricePerMonth);
//         double discountRate = 0;
//         if (Tier== "Basic")
//         {
//             discountRate = 0.02;
//         }
//         else if (Tier == "Premium")
//         {
//             discountRate = 0.07;
//         }
//         else if (Tier == "Elite")
//         {
//             discountRate = 0.12;
//         }
//         double finaltotal=total-(total*discountRate);
//         return finaltotal;
//     }
//     public static void Main(string[] args)
//     {
//         Membership mi=new Membership();
//         Console.Write("Enter the Tier: ");
//         mi.Tier=Console.ReadLine();
//         Console.Write("Enter the duration: ");
//         mi.DurationinMonth=int.Parse(Console.ReadLine());
//         Console.Write("Enter the base Price Per month: ");
//         mi.BasePricePerMonth=double.Parse(Console.ReadLine());
//         try
//         {
//             if (mi.ValidateEnrollment())
//             {
//                 double bill=mi.CalculateTotalBill();
//                 Console.WriteLine("Final bill is: "+bill);
//             }
//         }catch(InvalidTierException ex)
//         {
//             Console.WriteLine("Erroor: "+ex.Message);
//         }
//         catch(Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// class Shipment
// {
//     public string ShipmentCode{get;set;}
//     public string transportMode{get;set;}
//     public double weight{get;set;}
//     public int StorageDays{get;set;}
//     public Shipment(string ShipmentCode,string transportMode,double weight,int StorageDays)
//     {
//         this.ShipmentCode=ShipmentCode;
//         this.transportMode=transportMode;
//         this.weight=weight;
//         this.StorageDays=StorageDays;
//     }
// }
// class ShipmentDetails : Shipment
// {
//     public bool ValidateShipmentCode()
//     {
//         if(ShipmentCode.Length==7 && ShipmentCode.StartsWith("GC#")) return true;
//     }

//     public double CalcuateTotalCost()
//     {
//         double cost=weight*StorageDays;
//         int subcost=Math.Sqrt(StorageDays);
//         double totalcost=cost+subcost;
//         return totalcost;
//     }
// }


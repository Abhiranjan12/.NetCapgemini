// using System;
// // //=========================TASK 1============================
// // class ProductApp
// // {
// //     public static void Main(string[] args)
// //     {
// //         int n;
// //         Console.Write("Enter the no product: ");
// //         n = int.Parse(Console.ReadLine());
// //         int[] arr = new int[n];
// //         for (int i = 0; i < n; i++)
// //         {
// //             int ele;
// //             do
// //             {
// //                 Console.Write($"Enter price for product {i + 1}: ");
// //                 ele = int.Parse(Console.ReadLine());
// //                 if (ele <= 0) Console.WriteLine("Price must be positive!");
// //             } while (ele <= 0); 
// //             arr[i] = ele;
// //         }
// //         int sum = 0;
// //         foreach (int i in arr) sum += i;     
// //         int avg = sum / arr.Length;
// //         Console.WriteLine("The Average Price of product is: " + avg);
// //         System.Array.Sort(arr);
// //         Console.WriteLine("Array after sorting: ");
// //         foreach (int i in arr) Console.WriteLine(i);
// //         for (int i = 0; i < arr.Length; i++)
// //         {
// //             if (arr[i] < avg) arr[i] = 0;
// //         }
// //         int len = arr.Length;
// //         System.Array.Resize(ref arr, len + 5);
// //         Console.WriteLine("After resizing the array the length is: " + arr.Length);
// //         for (int i = len; i < arr.Length; i++)
// //         {
// //             arr[i] = avg;
// //         }
// //         for (int i = 0; i < arr.Length; i++)
// //         {
// //             Console.WriteLine("Index " + i + " has element: " + arr[i]);
// //         }
// //     }
// // }

// // class BranchSales
// // {
// //     public static void Main(string[] args)
// //     {
// //         int branch,month;
// //         Console.Write("Enter the branch: ");
// //         branch=int.Parse(Console.ReadLine());
// //         Console.Write("Enter the month: ");
// //         month=int.Parse(Console.ReadLine());

// //         int[,] arr=new int[branch,month];
// //         Console.WriteLine("store sales in arr");
// //         for(int i = 0; i < branch; i++)
// //         {
// //             for(int j = 0; j < month; j++)
// //             {
// //                 int sales;
// //                 sales=int.Parse(Console.ReadLine());
// //                 arr[i,j]=sales;
// //             }
// //         }
// //         int highest=arr[0,0];
// //         for(int i = 0; i < branch; i++)
// //         {
// //             int sum=0;
// //             for(int j = 0; j < month; j++)
// //             {
// //                 sum+=arr[i,j];
// //                 highest=Math.Max(arr[i,j],highest);
// //             }
// //             Console.WriteLine("The sales in this brnch is: "+sum);
// //         }
// //         Console.WriteLine("The global largest sales is: "+highest);

// //     }
// // }


// class CustomerTransaction
// {
//     public static void Main(string[] args)
//     {
//         int n;
//         Console.Write("No of customer transaction: ");
//         n=int.Parse(Console.ReadLine());
//         List<int> li=new List<int>();
//         for(int i = 0; i < n; i++)
//         {
//             int trans=int.Parse(Console.ReadLine());
//             li.Add(trans);
//         }
//         HashSet<int> hs=new HashSet<int>();
//         foreach(var i in li) hs.Add(i);
//         li.Clear();
//         foreach(var i in hs) li.Add(i);
//         Console.WriteLine("After removing duplicate");
//         foreach(var i in li) Console.WriteLine(i);
//     }
// }
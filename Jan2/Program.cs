// using System;
// using System.Collections;
// using System.Globalization;
// using System.Runtime.CompilerServices;
// using System.Runtime.Serialization.Formatters;
// using System.Text;
// // // class Progam
// // // {
// // //     public static void Main(string[] args)
// // //     {
// // //         // StringBuilder st=new StringBuilder("Hello world");
// // //         // for(int i = 0; i < st.Length; i++)
// // //         // {
// // //         //     Console.Write(st[i]);
// // //         // }
// // //         // StringBuilder sb2=new StringBuilder();
// // //         // sb2.Append("Hello ");
// // //         // sb2.AppendLine("C#");
// // //         // sb2.AppendLine("Language");
// // //         // Console.WriteLine(sb2);  // append means sath appendline means line m

// // //         // StringBuilder amount =new StringBuilder("your total amount: ");
// // //         // amount.AppendFormat("{0:c}",25);
// // //         // Console.WriteLine(amount);
// // //         // CultureInfo ca=new CultureInfo("en-IN");
// // //         // amount.AppendFormat(ca,"{0:c}",122344);
// // //         // Console.WriteLine(amount);

// // //         // StringBuilder st=new StringBuilder("hello world...",90);
// // //         // st.Remove(5,6); //{index,length};
// // //         // Console.WriteLine(st);
// // }
// // }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList list=new ArrayList();
//         Employee emp1=new Employee(){Id=123,name="Abhi"};
//         Employee emp2=new Employee(){Id=124,name="Mohan"};
//         Employee emp3=new Employee(){Id=125,name="Sohan"};
//         list.Add(10);
//         list.Add(20);
//         list.Add(30);
//         list.Add(40);
//         list.Add(12.35);
//         list.Add(emp1);
//         list.Add(emp2);
//         list.Add(emp3);
//         //list.Sort();
//         for(int i=0;i<list.Count;i++) Console.WriteLine(list[i]);
//         foreach(var i in list)Console.WriteLine(i);
//         list.Clear();
//         Console.WriteLine(list.Count);
//         if(list.Contains(30)) Console.WriteLine("found");
//         else Console.WriteLine("Not found");
//         list.Add(100); 
//         list.Add(200);
//         list.Add(600);  
//         ArrayList arr=new ArrayList();
//         arr.Add(10);
//         arr.Add(20);
//         arr.Add(30);
//         arr.Add(40);
//         arr.AddRange(list); //{merge two list}
//         Console.WriteLine("after merging the arraylist");
//         foreach(var i in arr) Console.WriteLine(i+" ");

//         //=======remove
//         arr.Remove(10); //{element}
//         Console.WriteLine("after removing the ellement");
//         foreach(var i in arr) Console.WriteLine(i+" ");
//         arr.RemoveAt(2);  // {from index}
//         Console.WriteLine("after removing the ellement");
//         foreach(var i in arr) Console.WriteLine(i+" ");
//         arr.RemoveRange(0,2); //{Index,count}
//         Console.WriteLine("after removing the ellement");
//         foreach(var i in arr) Console.WriteLine(i+" ");

//         //=====SORT THE LIST======
//         arr.Sort();
//         Console.WriteLine("After sorting the list");
//         foreach(var i in arr) Console.WriteLine(i);


//         //=====reverse the list=============
//         arr.Reverse();
//         Console.WriteLine("After reversing the list");
//         foreach(var i in arr) Console.WriteLine(i);

//         //=======insert in list=============
//         arr.Insert(2,2849);
//         arr.Insert(1,384);
//         arr.Insert(4,239); //{Index,element}
//         Console.WriteLine("After insert the elelemnt list");
//         foreach(var i in arr) Console.WriteLine(i);

//         ArrayList arr1=new ArrayList();
//         arr1.Add(192);
//         arr1.Add(839);
//         arr1.Add(338);
//         arr.InsertRange(3,arr1);
        
//     }
// }
// using System;
// class SaleTransaction{
//     public string InvoiceNo;
//     public string CustomerName;
//     public string ItemName;
//     public int Quantity;
//     public double PurchaseAmount;
//     public double SellingAmount;
//     public string ProfitOrLossStatus;
//     public double ProfitOrLossAmount;
//     public double ProfitMarginPercent;
//     public static SaleTransaction LastTransaction=null;
//     public static bool HasLastTransaction=false;
//     public void CreateTransaction(){
//         Console.Write("Enter Invoice No: ");
//         InvoiceNo = Console.ReadLine();
//         if(string.IsNullOrWhiteSpace(InvoiceNo))
//         {
//             Console.WriteLine("Invoice No cannot be empty.");
//             return;
//         }
//         Console.Write("Enter Customer Name: ");
//         CustomerName = Console.ReadLine();
//         Console.Write("Enter Item Name: ");
//         ItemName = Console.ReadLine();
//         Console.Write("Enter Quantity: ");
//         Quantity = int.Parse(Console.ReadLine());
//         if(Quantity<=0){
//             Console.WriteLine("Quantity must be greater than 0.");
//             return;
//         }
//         Console.Write("Enter Purchase Amount (total): ");
//         PurchaseAmount=double.Parse(Console.ReadLine());
//         if(PurchaseAmount<=0){
//             Console.WriteLine("Purchase Amount must be greater than 0.");
//             return;
//         }
//         Console.Write("Enter Selling Amount (total): ");
//         SellingAmount=double.Parse(Console.ReadLine());
//         if(SellingAmount<0){
//             Console.WriteLine("Selling Amount cannot be negative.");
//             return;
//         }
//         if(SellingAmount>PurchaseAmount){
//             ProfitOrLossStatus="PROFIT";
//             ProfitOrLossAmount=SellingAmount-PurchaseAmount;
//         }
//         else if(SellingAmount<PurchaseAmount){
//             ProfitOrLossStatus="LOSS";
//             ProfitOrLossAmount=PurchaseAmount-SellingAmount;
//         }
//         else{
//             ProfitOrLossStatus="BREAK-EVEN";
//             ProfitOrLossAmount=0;
//         }
//         ProfitMarginPercent=(ProfitOrLossAmount/PurchaseAmount)*100;
//         LastTransaction = this; 
//         HasLastTransaction = true;
//         Console.WriteLine("Transaction saved successfully.");
//         Console.WriteLine("Status: " + ProfitOrLossStatus);
//         Console.WriteLine("Profit/Loss Amount: " + ProfitOrLossAmount);
//         Console.WriteLine("Profit Margin (%): " + ProfitMarginPercent);
//     }
//     public static void ViewLastTransaction(){
//         if (!HasLastTransaction){
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }
//         Console.WriteLine("-------------- Last Transaction --------------");
//         Console.WriteLine("InvoiceNo: "+LastTransaction.InvoiceNo);
//         Console.WriteLine("Customer: "+LastTransaction.CustomerName);
//         Console.WriteLine("Item: "+LastTransaction.ItemName);
//         Console.WriteLine("Quantity: "+LastTransaction.Quantity);
//         Console.WriteLine("Purchase Amount: "+LastTransaction.PurchaseAmount);
//         Console.WriteLine("Selling Amount: "+LastTransaction.SellingAmount);
//         Console.WriteLine("Status: "+LastTransaction.ProfitOrLossStatus);
//         Console.WriteLine("Profit/Loss Amount: "+LastTransaction.ProfitOrLossAmount);
//         Console.WriteLine("Profit Margin (%): "+LastTransaction.ProfitMarginPercent);
//     }
//     public static void RecalculateProfitLoss(){
//         if(!HasLastTransaction){
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }
//         if(LastTransaction.SellingAmount>LastTransaction.PurchaseAmount){
//             LastTransaction.ProfitOrLossStatus="PROFIT";
//             LastTransaction.ProfitOrLossAmount=LastTransaction.SellingAmount-LastTransaction.PurchaseAmount;
//         }
//         else if(LastTransaction.SellingAmount<LastTransaction.PurchaseAmount){
//             LastTransaction.ProfitOrLossStatus="LOSS";
//             LastTransaction.ProfitOrLossAmount=LastTransaction.PurchaseAmount-LastTransaction.SellingAmount;
//         }
//         else{
//             LastTransaction.ProfitOrLossStatus="BREAK-EVEN";
//             LastTransaction.ProfitOrLossAmount = 0;
//         }
//         LastTransaction.ProfitMarginPercent=(LastTransaction.ProfitOrLossAmount/LastTransaction.PurchaseAmount)*100;
//         Console.WriteLine("----------- Recalculated Result -----------");
//         Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
//         Console.WriteLine("Profit/Loss Amount: " +
//             LastTransaction.ProfitOrLossAmount);
//         Console.WriteLine("Profit Margin (%): " +
//             LastTransaction.ProfitMarginPercent);
//     }

//     public static void Main(string[] args){
//         SaleTransaction st=new SaleTransaction();
//         while (true){
//             Console.WriteLine("\n================== QuickMart Traders ==================");
//             Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
//             Console.WriteLine("2. View Last Transaction");
//             Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");
//             int opt=int.Parse(Console.ReadLine());
//             switch(opt){
//                 case 1:
//                     st.CreateTransaction();
//                     break;
//                 case 2:
//                     ViewLastTransaction();
//                     break;
//                 case 3:
//                     RecalculateProfitLoss();
//                     break;
//                 case 4:
//                     Console.WriteLine("Thank you. Application closed normally.");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid option. Please try again.");
//                     break;
//             }
//         }
//     }
// }
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
class Student
{
    int StudentId;      
    string StudentName;
    public string CourseName;
    public Student(int id, string name, string course)
    {
        StudentId = id;
        StudentName = name;
        CourseName = course;
    }
    public void DisplayData()
    {
        Console.WriteLine("id is: "+StudentId);
        Console.WriteLine("Name is: "+StudentName);
        Console.WriteLine("course name is: "+CourseName);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        // List<Student> students = new List<Student>();
        // students.Add(new Student(1, "Abhi", "C#"));
        // Console.WriteLine("detail of student");
        // foreach(var st in students)
        // {
        //     st.DisplayData();
        // }

        Dictionary<int,string> di=new Dictionary<int,string>();
        di.Add(1,"Rohan");
        di.Add(2,"Mohan");
        di.Add(3,"Sohan");
        di.Add(4,"Gita");
        Console.WriteLine("Enter roll: ");
        int roll=int.Parse(Console.ReadLine());
        if(di.ContainsKey(roll)) Console.WriteLine("The name of student is: "+di[roll]);
        else Console.WriteLine("student not found");
    }
}

// using System;
// using System.Linq.Expressions;
// class Indexer
// {
//     private string[] str=new string[5];
//     public string this[int index]
//     {
//         get{ return str[index];}
//         set{str[index]=value;}
//     }
//     public int this[string st]
//     {
//         get
//         {
//             int index=0;
//             while (index < 5)
//             {
//                 if(str[index]==st) return index;
//                 index++;
//             }
//             return index;
//         }
//     }
//     public static void Main(string[] args)
//     {
//         Indexer id=new Indexer();
//         id[0]="Niharika";
//         id[1]="Rohan";
//         id[2]="Ritik";
//         id[3]="Sohan";
//         id[4]="Raj";
//         Console.WriteLine("The element of indexer are: ");
//         Console.WriteLine(id[0]);
//         Console.WriteLine(id[1]);
//         Console.WriteLine(id[2]);
//         Console.WriteLine(id[3]);
//         Console.WriteLine(id[4]);
//         Console.WriteLine("The idx of raj is: "+id["Raj"]);
//     }
// }
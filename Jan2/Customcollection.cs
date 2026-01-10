// using System;
// using System.Collections;
// class MyCollection : IEnumerable
// {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     public IEnumerator GetEnumerator()
//     {
//         return arr.GetEnumerator();
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         MyCollection obj = new MyCollection();
//         foreach (int i in obj)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }
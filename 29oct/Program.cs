// using System;
// class Program{
// //     // public int PassArray(int[] arr){
// // //     //     int sum=0;
// // //     //     foreach(int  i in arr) sum+=i;
// // //     //     return sum;
// // //     // }
// // //     // public int[] createarray(int n){
// // //     //     int[] arr=new int[n];
// // //     //     for(int i=0;i<n;i++){
// // //     //         arr[i]=int.Parse(Console.ReadLine());
// // //     //     }
// // //     //     return arr;
// // //     // }


//     public static void Main(string[] args){
// // //         // array declartion and initilazation
// // //         //int[] arr=new int[6];
// // //         // arr[0]=1;
// // //         // arr[1]=2;   //assign value to array
// // //         // arr[2]=3;
// // //         // arr[3]=4;
// // //         // arr[4]=5;
// // //         // arr[5]=6;
// // //         // Console.WriteLine("The element of array is: ");
// // //         // for(int i=0;i<arr.Length;i++){
// // //         //     Console.Write(arr[i]+" ");
// // //         // }

// // //         // int n;
// // //         // Console.Write("Enter the size of array: ");
// // //         // n=int.Parse(Console.ReadLine());
// // //         // int[] arr=new int[n];
// // //         // Console.WriteLine("Enter the element of array: ");
// // //         // for(int i=0;i<n;i++){
// // //         //     arr[i]=int.Parse(Console.ReadLine());
// // //         // }
// // //         // Console.WriteLine("The element of array is: ");
// // //         // for(int i=0;i<arr.Length;i++){
// // //         //     Console.Write(arr[i]+" ");
// // //         // }

// // //         // char[] ch=new char[5]{'A','B','C','D','E'};
// // //         // foreach(char i in ch){
// // //         //     Console.Write(i+" ");
// // //         // }

// // //         // char[] ch=new char[5];
// // //         // for(int i=0;i<5;i++){
// // //         //     ch[i]=char.Parse(Console.ReadLine());
// // //         // }
// // //         // foreach(char i in ch) Console.Write(i+" ");
        
// // //         // Program p=new Program();
// // //         // int[] arr=p.createarray(5);
// // //         // int sum=p.PassArray(arr);
// // //         // Console.WriteLine("the sum is: "+sum);
// // //         // int n, m;
// // //         // Console.Write("Enter the row size: ");
// // //         // n = int.Parse(Console.ReadLine());
// // //         // Console.Write("Enter the col size: ");
// // //         // m = int.Parse(Console.ReadLine());
// // //         // int[,] arr = new int[n, m]; 
// // //         // Console.WriteLine("Enter the elements of array: ");
// // //         // for(int i = 0; i < n; i++) {
// // //         //     for(int j = 0; j < m; j++) {
// // //         //         arr[i, j] = int.Parse(Console.ReadLine());
// // //         //     }
// // //         // }
// // //         // Console.WriteLine("Elements of array are: ");
// // //         // for(int i = 0; i < n; i++) {
// // //         //     for(int j = 0; j < m; j++) {
// // //         //         Console.Write(arr[i, j] + " ");
// // //         //     }
// // //         //     Console.WriteLine();
// // //         // }
//         int[] arr=new int[6]{2,6,5,3,1,9};
//         Console.WriteLine(arr.IsReadOnly);
//         Console.WriteLine("Rank of array is: "+arr.Rank);
//         Console.WriteLine(arr.IsFixedSize);
//         Console.WriteLine("Value of array is: "+arr.GetValue(5));
//         Console.WriteLine("index of elelement is: "+Array.IndexOf(arr,5));
//         Array.Sort(arr);
//         Console.WriteLine("Array after sorting: ");
//         for(int i=0;i<arr.Length;i++) Console.Write(arr[i]+" ");
//         Console.WriteLine();
//         Console.WriteLine("Array after reversing: ");
//         Array.Reverse(arr);
//         for(int i=0;i<arr.Length;i++) Console.Write(arr[i]+" ");

//     }
// }
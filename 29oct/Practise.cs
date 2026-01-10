// using System;
// using System.Transactions;
// class Practise{
//     public void Ques1(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine("Elements in array are: ");
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]+" ");
//         }
//     }
//     public void Ques2(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//         }
//         Console.Write("Elements in array are: ");
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]+" ");
//         }
//         Console.WriteLine();
//         Console.Write("The element in reverse order: ");
//         for(int i=n-1;i>=0;i--){
//             Console.Write(arr[i]+" ");
//         }
//     }
//     public void Ques3(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//         }
//         Console.Write("Elements in array are: ");
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]+" ");
//         }
//         Console.WriteLine();
//         int sum=0;
//         for(int i=0;i<n;i++){
//             sum+=arr[i];
//         }
//         Console.Write("The sum of element of array is: "+sum);
//     }
//     public void Ques4(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         int[] cp=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//             cp[i]=arr[i];
//         }
//         Console.Write("Elements in array are: ");
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]+" ");
//         }
//         Console.WriteLine();
//         Console.Write("copy Elements in array are: ");
//         for(int i=0;i<n;i++){
//             Console.Write(cp[i]+" ");
//         }
//     }
//     public void Ques5(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//         }
//         int count=0;
//         for(int i=0;i<n;i++){
//             int cnt=0;
//             for(int j=i+1;j<n;j++){
//                 if(arr[i]==arr[j]) cnt++;
//             }
//             if(cnt!=0) count++;
//         }
//         Console.WriteLine("Total number of duplicate elements found in the array is : "+count);
//     }
//     public void Ques6(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n=int.Parse(Console.ReadLine());
//         int[] arr=new int[n];
//         Console.WriteLine("The input of element is: ");
//         for(int i=0;i<n;i++){
//             Console.Write("element - "+i+" : ");
//             arr[i]=int.Parse(Console.ReadLine());
//         }
//         int count=0;
//         for(int i=0;i<n;i++){
//             int cnt=0;
//             for(int j=i+1;j<n;j++){
//                 if(arr[i]==arr[j]) cnt++;
//             }
//             if(cnt==0) count++;
//         }
//         Console.WriteLine("Total number of unique elements found in the array is : "+count);
//     }
//     public void Ques7() {
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr1 = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr1[i] = int.Parse(Console.ReadLine());
//         }
//         int m;
//         Console.Write("Enter the value of m: ");
//         m = int.Parse(Console.ReadLine());
//         int[] arr2 = new int[m];
//         Console.WriteLine("The input of element of 2nd array: ");
//         for (int i = 0; i < m; i++) { 
//             Console.Write("element - " + i + " : ");
//             arr2[i] = int.Parse(Console.ReadLine());
//         }

//         int[] arr = new int[n + m];
//         int x = 0, j = 0, k = 0; 
//         while (x < n && j < m) {
//             if (arr1[x] <= arr2[j]) {
//                 arr[k++] = arr1[x++];
//             } else {
//                 arr[k++] = arr2[j++];
//             }
//         }
//         while (x < n) {
//             arr[k++] = arr1[x++];
//         }
//         while (j < m) {
//             arr[k++] = arr2[j++];
//         }
//         Console.WriteLine("The element of mixed array are: ");
//         for (int i = 0; i < n + m; i++) Console.Write(arr[i] + " ");
//     }
//     public void Ques8(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         int[] freq=new int[n];
//         for(int i=0;i<n;i++){
//             int cnt=0;
//             for(int j=0;j<n;j++){
//                 if(arr[i]==arr[j]) cnt++;
//             }
//             freq[i]=cnt;
//         }
//         for(int i=0;i<n;i++){
//             Console.WriteLine("The "+arr[i]+" element occurs "+freq[i]+" times");
//         }
//     }
//     public void Ques9(){
//          int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         int maxi=0,mini;
//         for(int i=0;i<n;i++){
//             if(arr[i]>maxi) maxi=arr[i];
//         }
//         mini=maxi;
//         for(int i=0;i<n;i++){
//             if(arr[i]<mini) mini=arr[i];
//         }
//         Console.WriteLine("The maxi element of array is: "+maxi);
//         Console.WriteLine("The mini element of array is: "+mini);
//     }
//     public void Ques10(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         Console.Write("The Even elements are:");
//         for(int i=0;i<n;i++){
//             if(arr[i]%2==0) Console.Write(arr[i]+" ");
//         }
//         Console.WriteLine();
//         Console.Write("The odd elements are:");
//         for(int i=0;i<n;i++){
//             if(arr[i]%2!=0) Console.Write(arr[i]+" ");
//         }
//     }
//     public void Ques11(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         for(int i=0;i<n;i++){
//             for(int j=0;j<n-i-1;j++){
//                 if(arr[j]>=arr[j+1]){
//                     int temp=arr[j];
//                     arr[j]=arr[j+1];
//                     arr[j+1]=temp;
//                 }
//             }
//         }
//         Console.WriteLine("Elements of the array in sorted ascending order: ");
//         for(int i=0;i<n;i++) Console.Write(arr[i]+ " ");
//     }
//     public void Ques12(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         for(int i=0;i<n;i++){
//             for(int j=0;j<n-i-1;j++){
//                 if(arr[j]<arr[j+1]){
//                     int temp=arr[j];
//                     arr[j]=arr[j+1];
//                     arr[j+1]=temp;
//                 }
//             }
//         }
//         Console.WriteLine("Elements of the array in sorted descending order: ");
//         for(int i=0;i<n;i++) Console.Write(arr[i]+ " ");
//     }
//     public void Ques13(){
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         int ele;
//         Console.Write("Enter the ele: ");
//         ele=int.Parse(Console.ReadLine());
//         n++;
//         arr[n-1]=ele;
//         for(int i=0;i<n;i++){
//             for(int j=0;j<n-i-1;j++){
//                 if(arr[j]<arr[j+1]){
//                     int temp=arr[j];
//                     arr[j]=arr[j+1];
//                     arr[j+1]=temp;
//                 }
//             }
//         }
//         for(int i=0;i<n;i++) Console.Write(arr[i]+ " ");

//     }
//     public void Ques14()
//     {
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         int ele;
//         Console.Write("Enter the ele: ");
//         ele=int.Parse(Console.ReadLine());
//         Array.Resize(ref arr,n+1);
//         arr[n-1]=ele;
//         Array.Sort(arr);
//         Console.WriteLine("Element of array is: ");
//         foreach(var i in arr) Console.WriteLine(i+" ");
//     }
//     public void Ques15()
//     {
//         int n;
//         Console.Write("Enter the value of n: ");
//         n = int.Parse(Console.ReadLine());
//         int[] arr = new int[n];
//         Console.WriteLine("The input of element of 1st array: ");
//         for (int i = 0; i < n; i++) {
//             Console.Write("element - " + i + " : ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         int pos;
//         Console.WriteLine("Enter the pos of ele: ");
//         pos=int.Parse(Console.ReadLine());
//         for (int i = pos; i < n-1 ; i++){
//             arr[i] = arr[i + 1];
//         }
//         Array.Resize(ref arr,n-1);
//         Console.WriteLine("Array element is: ");
//         for(int i = 0; i < n-1; i++)
//         {
//             Console.Write(arr[i]+" ");
//         }

//     }
//     public static void Main(string[] args){
//         Practise p=new Practise();
//         // p.Ques1();
//         // p.Ques2();
//         // p.Ques3();
//         // p.Ques4();
//         // p.Ques5();
//         // p.Ques6();
//         // p.Ques7();
//         // p.Ques8();
//         // p.Ques9();
//         // p.Ques10();
//         //p.Ques11();
//         //p.Ques12();
//         //p.Ques13();
//         //p.Ques14();
//         p.Ques15();


//     }
// }
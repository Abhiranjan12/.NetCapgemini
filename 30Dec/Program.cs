// class Program
// {
//     public static void Main(string[] args)
//     {
//     //    string fname,lname;
//     //    fname="Abhiranjan";
//     //    lname="Kumar...";
//     //    Console.WriteLine("Name is: "+fname+" "+lname);

//        // using constructor
//     //    char[] array={'A','B','H','I'};
//     //    string str=new string(array);
//     //    Console.WriteLine("hello : "+str);


//     //    string[] array1={"Hello","I","Am","Abhi"};
//     //    string mess=String.Join(" ",array1);
//     //    Console.WriteLine(mess);

//        // formating method
//         // DateTime dt=new DateTime(2025,10,10,17,58,1);
//         // string chat = string.Format("{0:dd-MMM-yyyy}", dt); 
//         // Console.WriteLine(chat);

//         // string str1="hello world";
//         // string str2="hello world";

//         // if(String.Compare(str1,str2)==0) Console.WriteLine("It is equal");
//         // else Console.WriteLine("Not equal");

//         // Console.WriteLine(str1==str2);

//         // Console.WriteLine(str1.Equals(str2));

//         // string st1=new  string("hello");
//         // string st2=new  string("hello");

//         // Console.WriteLine(st1==st2);
//         // Console.WriteLine(st1.Equals(st2));

//         // string str1="hello i am from bihar";
//         // if(str1.Contains("i")) Console.WriteLine("it contain");

//         // string str3="last night i visited delhi";
//         // string substr=str3.Substring(5,9);
//         // Console.WriteLine(substr);

//         //===escapse sequence======
//         // Console.WriteLine("hello\nworld");
//         // Console.WriteLine("\"hii how are you\"");
//         // Console.WriteLine(@"D:\project\csharp\program.cs"); //verbatim
//         // Console.WriteLine("D:\\project\\csharp\\program.cs");
//         // string mess=@"hello ahi
//         // hii hoow are you
//         // heloo where are you from";
//         //Console.WriteLine(mess);
// // ==========Function====
//         // string str1="hello world";
//         // Console.WriteLine(str1.ToUpper());
//         // string str2="HELLO WORLD";
//         // Console.WriteLine(str2.ToLower());
//         // string str3="  hello world";
//         // Console.WriteLine(str3.Trim());
//         // string str4="Hello abhi  in you are in delhi";
//         // Console.WriteLine(str4.IndexOf("you"));
//         // string str5="Hello abhi  in you are in delhi";
//         // Console.WriteLine(str5.LastIndexOf("in"));

//         // string str="hello,how,are,you";
//         // string[] spt=str.Split(",");
//         // foreach(var i in spt) Console.WriteLine(i+" ");

// //==============another function============
//         // var abc=12;
//         // Console.WriteLine($"The no {abc} and mul is {abc*abc}");

// //==============jagged array================
//         int [][] jagedarr=new int[4][];
//         jagedarr[0]=new int[]{2,4,1,6,7};
//         jagedarr[1]=new int[]{3,44,4,5,69,838,393};
//         jagedarr[2]=new int[]{38,92,94,39};
//         jagedarr[3]=new int[]{384,394};
//         for(int i = 0; i < jagedarr.Length; i++)
//         {
//             for (int j = 0; j < jagedarr[i].Length; j++)
//             {
//                 Console.Write(jagedarr[i][j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
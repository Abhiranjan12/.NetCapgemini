using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
class Practise
{
    public void Ques1()
    {
        Console.Write("Enter the string: ");
        string str1=Console.ReadLine();
        Console.WriteLine("The string is: "+str1);
    }

    public void Ques2()
    {
        string[] arr=new string[10];
        Console.WriteLine("Enter the string");
        for(int i=0;i<10;i++) arr[i]=Console.ReadLine();
        foreach(var i in arr) Console.Write(i+" ");
    }

    public void Ques3()
    {
        int [,] arr=new int[2,2];
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                arr[i,j]=int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("the element of matrix is: ");
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }

    public void Ques4()
    {
        int[,] arr1={{1,2,3},{2,4,6}};
        int[,] arr2={{12,22,31},{42,24,46}};
        int n=arr1.GetLength(0);
        int m=arr1.GetLength(1);
        int[,] res=new int[n,m];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                res[i,j]=arr1[i,j]+arr2[i,j];
            }
        }

        Console.WriteLine("the sum of element of matrix is: ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
    public void Ques5()
    {
        int[,] arr1 = { { 1, 2, 3 }, { 2, 4, 6 } };
        int[,] arr2 = { { 10, 20 }, { 30, 40 }, { 50, 60 } }; 
        int r1 = arr1.GetLength(0);
        int c1 = arr1.GetLength(1); 
        int r2 = arr2.GetLength(0); 
        int c2 = arr2.GetLength(1);
        int[,] res = new int[r1, c2];
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                int sum = 0;
                for (int k = 0; k < c1; k++) 
                {
                    sum += arr1[i, k] * arr2[k, j];
                }
                res[i, j] = sum;
            }
        }
        Console.WriteLine("The result of matrix multiplication is:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void Ques6()
    {
        int[,] arr={{2,3,4},{6,7,8},{9,3,4}};
        Console.WriteLine("Matrix before Transpose");
        for(int i = 0; i <arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = i+1; j < arr.GetLength(1); j++)
            {
                int temp=arr[i,j];
                arr[i,j]=arr[j,i];
                arr[j,i]=temp;
            }
        }
        Console.WriteLine("matrix after transpose");
        for(int i = 0; i <arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
    public void Ques7()
    {
        int[,] arr={{2,0,0},{0,7,0},{0,0,4}};
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(i!=j && arr[i,j]>0) Console.WriteLine("matrxi is not diagonal matrix");
            }
        }
        Console.WriteLine("Matrix is diagonal");
    }

    public void StringQues1()
    {
        string str="Hello Abhiranjan";
        char[] ans=str.ToCharArray();
        Array.Reverse(ans);
        Console.WriteLine("string is after string: "+new string(ans));
    }
    public void StringQues2()
    {
        string str="Hello Abhiranjan";
        Console.WriteLine("Before reverse String is: "+str);
        char[] str1=str.ToCharArray();
        int i=0,j=str1.Length-1;
        while (i < j)
        {
            char temp=str1[i];
            str1[i]=str1[j];
            str1[j]=temp;
            i++;
            j--;
        }
        string ans=new string(str1);
        Console.WriteLine("After reverse String is: "+ans);
    }
    public void StringQues3()
    {
        string up="HELLO HOW ARE YOU";
        string lo="hii how are you";

        Console.WriteLine("After uppercase: "+lo.ToUpper());
        Console.WriteLine("After lowercase: "+up.ToLower());
    }
    public void StringQues4()
    {
        string str1="Hello";
        string str2="World";
        char[] ch1=str1.ToCharArray();
        char[] ch2=str2.ToCharArray();
        int i=0,j=0;
        bool ans=true;
        while(i<ch1.Length && j < ch2.Length)
        {
            if(ch1[i]!=ch2[j]) ans=false;
            i++;
            j++;
        }
        if (ans)
        {
            Console.WriteLine("string is equal");
        }
        else
        {
            Console.WriteLine("string is not equal");
        }
    }
     public void StringQues5()
    {
        string str1="Hello";
        string str2="World";
        if(str1.CompareTo(str2)==0) Console.WriteLine("string is equal");
        else Console.WriteLine("not equal");
    }

    public void StringQues585960()
    {
        string str1="hello";
        string str2="Abhiranjan...";
        Console.WriteLine("concat string Without using function: "+str1+" "+str2);
        string ans=String.Concat(str1,str2);
        Console.WriteLine("concat string With using function: "+ans);

        string main="Hello how are you";
        string find="how";
        if(main.Contains(find)) Console.WriteLine("string found");
        else Console.WriteLine("not found");

    }
       public static void Main()
    {
        Practise p=new Practise();
        //p.Ques1();
        //p.Ques2();
        // p.Ques3();
        //p.Ques4();
        //p.Ques5();
        //p.Ques6();
        //p.Ques7();

        // p.StringQues1();
        // p.StringQues2();
        //p.StringQues3();
        //p.StringQues4();
        //p.StringQues5();
        p.StringQues585960();


    }
}
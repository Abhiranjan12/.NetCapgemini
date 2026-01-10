using System;
class main{
    public static void Main(string[] args){
        Console.WriteLine("Hello World");
    //     Employee emp= new Employee();
    //     emp.acceptDetails();
    //     emp.displayDetails();
    //     Calculator ca=new Calculator();
    //     ca.getdata();
    //     ca.doAddition();
    //     ca.doSubtraction();
    //     ca.doMultiplication();
    //     ca.doDivision();

    //    HelloWorld he=new HelloWorld();
    //     he.greeting();
    //     he.readNo();
    //     he.readString();
    //     he.areaOfCircle();
    //     he.arithOper();
    //     he.evenOdd();
    //     he.greatOfTwo();
    //     he.checkNo();
    //     he.nestedIf();

    //     checkVowel ch=new checkVowel();
    //     ch.cheVowel();
    //     ch.stringFunction();
    //     ch.swapNo();

    //     SwitchCalc sc=new SwitchCalc();
    //     sc.calc();
    //     Program program = new Program();
    //     int choice =0;
    //     Console.WriteLine("1 for Addition");
    //     Console.WriteLine("2 for Subtraction");
    //     Console.WriteLine("3 for Multiplication");
    //     Console.WriteLine("4 for Division");
    //     Console.WriteLine("5 for Reminder");
    //     Console.WriteLine("6 for Exit");
    //     Console.WriteLine("Select option from following list:");
    //     choice = Convert.ToInt32(Console.ReadLine());
    //     switch (choice)
    //     {
    //         case 1:
    //             program.Add();
    //             break;
    //         case 2:
    //             program.Subtract();
    //             break;
    //         case 3:
    //             program.Multiply();
    //             break;
    //         case 4:
    //             program.Divide();
    //             break;
    //         case 5:
    //             program.Reminder();
    //             break;
    //         case 6:
    //             return;
    //         default:
    //             Console.WriteLine("Invalid Option Enter Option Between 1 to 6");
    //             break;
    //     }

    //     int i=10;
    //     while(i>0){
    //         Console.WriteLine("the value of i is "+i);
    //         i--;
    //     }

    //     int i=1;
    //     do{
    //         Console.WriteLine("the value of i is "+i);
    //         i++;
    //     }while(i<=10);

    //     for(int i=0;i<10;i++){
    //         Console.WriteLine("The value of i is "+i);
    //     }
    //     int[] arr={1,2,3,4,5};
    //     foreach(int i in arr){
    //         Console.WriteLine("the element of array is: "+i);
    //     }
    //     for(int i=0;i<arr.Length;i++){
    //         Console.WriteLine(arr[i]);
    //     }

    //     int i=0;
    //     while(i<arr.Length){
    //         Console.WriteLine(arr[i]);
    //         i++;
    //     }

    //     ==============day2===============

    //     Write C#  program to print numbers from 1 to n(user input) using while loop

    //     int num;
    //     Console.WriteLine("Enter the no: ");
    //     num=int.Parse(Console.ReadLine());
    //     int i=0;
    //     while(i<=num){
    //         Console.WriteLine("The value of i is: "+i);
    //         i++;
    //     }

    //     Write C#  program to print even numbers from 1 to n(user input) 
    //     int num;
    //     Console.WriteLine("Enter the no: ");
    //     num=int.Parse(Console.ReadLine());
    //     int i=1;
    //     while(i<=num){
    //         if(i%2==0){
    //             Console.WriteLine("The given number "+i+" is even");
    //         }
    //         i++;
    //     }


    //     Write C#  program to find the sum  of numbers from 1 to n(user input) using while loop
    //     int num;
    //     Console.WriteLine("Enter the no: ");
    //     num=int.Parse(Console.ReadLine());
    //     int i=1;
    //     int sum=0;
    //     while(i<=num){
    //         sum+=i;
    //         i++;
    //     }
    //     Console.WriteLine("The sum is: "+sum);

    //     Write C#  program to print multiplication table of given number 
    //     int num;
    //     Console.Write("Enter the no: ");
    //     num=int.Parse(Console.ReadLine());
    //     for(int i=1;i<=10;i++){
    //         Console.WriteLine(num+" * "+i+" = "+num*i);
    //     }

    //     Write C#  program to calculate the power of a given number 
    //     int num;
    //     Console.Write("enter the number: ");
    //     num=int.Parse(Console.ReadLine());
    //     int pow;
    //     Console.Write("enter the power: ");
    //     pow=int.Parse(Console.ReadLine());
    //     int ans=1,i=1;
    //     while(i<=pow){
    //         ans*=num;
    //         i++;
    //     }
    //     Console.WriteLine("the pow of number is: "+ans);


    //     Write C#  program to generate fibbonacci series(0 1 1 2 3 5 8 13 21 34 55...)upto n(user input)
    //     int num;
    //     Console.Write("enter the number: ");
    //     num=int.Parse(Console.ReadLine());
    //     int f=0,s=1,n=0;
    //     for(int i=0;i<=num;i++){
    //         Console.Write(f+" ");
    //         n=f+s;
    //         f=s;
    //         s=n;
    //     }

    //     Write C#  program to find whether the given number is Armstrong or not
    //     int num;
    //     Console.Write("enter the number: ");
    //     num=int.Parse(Console.ReadLine());
    //     int pow=0;
    //     int temp=num;
    //     while(temp>0){
    //         pow++;
    //         temp/=10;
    //     }
    //     int sum=0;
    //     temp=num;
    //     while(temp>0){
    //         int n=temp%10;
    //         sum+=(int)Math.Pow(n,pow);
    //         temp=temp/10;
    //     }
    //     if(sum==num) Console.WriteLine("the given no is armstrong no");
    //     else Console.WriteLine("the given no is not armstrong no");


    //     program to print armstrong numbers from n1 to n2
    //     for(int i=100;i<160;i++){
    //         int pow=0;
    //         int temp=i;
    //         while(temp>0){
    //             pow++;
    //             temp/=10;
    //         }
    //         int sum=0;
    //         temp=i;
    //         while(temp>0){
    //             int n=temp%10;
    //             sum+=(int)Math.Pow(n,pow);
    //             temp=temp/10;
    //         }
    //         if(sum==i) Console.WriteLine("the given no "+i+" is armstrong no");
    //         else Console.WriteLine("the given no "+i+" is not armstrong no");
    //     }

    //     program to check whether the number is prime or not 
    //     int num;
    //     Console.Write("enter the no: ");
    //     num=int.Parse(Console.ReadLine());
    //     bool isPrime=true;
    //     for(int i=2;i<num;i++){
    //         if(num%i== 0){
    //             isPrime=false;
    //         }
    //         break;
    //     }
    //     if(isPrime) Console.WriteLine(num+" is prime no");
    //     else Console.WriteLine(num+" is not prime no");


    //     ques no 29

    //     for(int i=2;i<=100;i++){
    //         if(i%2==0) Console.WriteLine(i+"given no is odd");
    //     }

    //     ques no 30
    //     int sum=0;
    //     for(int i=1;i<100;i++){
    //         if(i%3==0 || i%5==0) sum+=i;
    //     }
    //     Console.WriteLine("The Sum of all the Multiples of 3 or 5 Below 100: "+sum);

    //     26)program to print numbers from 1 to 5(R to L)
    //     int rows = 5;
    //     for (int i = 1; i <= rows; i++){
    //         for (int j = 1; j <= rows - i; j++){
    //             Console.Write(" ");
    //         }
    //         for (int k = 1; k <= i; k++){
    //             Console.Write(k); 
    //         }
    //         Console.WriteLine();
    //     }

    //     ques 28
    //     do{
    //         char ch;
    //         Console.Write("enter char: ");
    //         ch=char.Parse(Console.ReadLine());
    //         if(ch!='y') break;
    //         int no,marks;
    //         string name;
    //         Console.Write("Enter roll no: ");
    //         no=int.Parse(Console.ReadLine());
    //         Console.Write("Enter name: ");
    //         name=Console.ReadLine();
    //         Console.Write("Enter marks: ");
    //         marks=int.Parse(Console.ReadLine());
    //         Console.WriteLine("rollno is: "+no+" name is: "+name+" marks is: "+marks);
    //     }while(true);
        


    //     ==================day 3==============
    //     Emp ee = new Emp();
    //     ee.acceptDetails();
    //     ee.EmpProperty = 1000; 
    //     ee.displayDetails();

    //         EmpSal ee=new EmpSal();
    //         ee.acceptDetails();
    //         Console.WriteLine("Gross Salary is: "+ee.grossSalary());
    //         Console.WriteLine("netSalary is: "+ee.netSlary());

    //     Student s=new Student();
    //     s.getDetails();
    //     s.total();
    //     s.average();
    //     s.gradedetails();


    //     ======leap year program ====

    //     int year;
    //     Console.Write("Enter the year: ");
    //     year=int.Parse(Console.ReadLine());
    //     if((year%4==0 && year %100!=0) || (year%400==0)){
    //         Console.WriteLine(year+" is leap year");
    //     }
    //     else{
    //         Console.WriteLine(year+" is not leap year");
    //     }

    //     ==========celcius to fahrenheit===========

    //     float cel;
    //     Console.Write("Temperature in celcius: ");
    //     cel=float.Parse(Console.ReadLine());
    //     float fah=cel*9/5+32;
    //     Console.WriteLine("Temperature in fahrenheit: "+fah);
        

    //     =====•	Score ≥ 90 : Grade A
    //         •	80 ≥ Score < 90 : Grade B
    //         •	70 ≥ Score < 80 : Grade C
    //         •	60 ≥ Score < 70 : Grade D
    //         •	Score < 60 : Grade F

    //         int mark;
    //         Console.Write("Enter the mark: ");
    //         mark=int.Parse(Console.ReadLine());
    //         if(mark>=90) Console.WriteLine("Grade A");
    //         else if(mark>=80 && mark<90) Console.WriteLine("Grade B");
    //         else if(mark>=70 && mark<80) Console.WriteLine("Grade C");
    //         else if(mark>=60 && mark<70) Console.WriteLine("Grade D");
    //         else Console.WriteLine("Grade F");

    //     =======factorial program======

    //     string no;
    //     while(true){
    //         Console.Write("Enter the no: ");
    //         no=Console.ReadLine();
    //         if(no.ToLower()=="q") break;
    //         int num=int.Parse(no);
    //         if(num>0){
    //             int fact=1;
    //             for(int i=1;i<=num;i++){
    //                 fact*=i;
    //             }
    //             Console.WriteLine("The factorial of "+num+" is: "+fact);
    //         }else{
    //             Console.WriteLine("Error message");
    //         }
    //     }


    //     ====sum of first n natural no=====

    //     int no;
    //     Console.Write("Enter the no: ");
    //     no=int.Parse(Console.ReadLine());
    //     int sum=0;
    //     for(int i=0;i<=no;i++){
    //         sum+=i;
    //     }
    //     Console.WriteLine("the sum is: "+sum);


    //     =======print first n even no==

    //     int n;
    //     Console.Write("Enter the value of n: ");
    //     n=int.Parse(Console.ReadLine());
    //     for(int i=1;i<=2*n;i++){
    //         if(i%2==0) Console.Write(i+" ");
    //     }

        // int n;
        // Console.Write("Enter the no: ");
        // no=int.Parse(Console.ReadLine());
        // if(n<=1) Console.WriteLine("no is not prime");
        // if(n==2||n==3) Console.WriteLine("no is prime");
        // if(n%2==0 || n%3==0) Console.WriteLine("no is not prime");
        // for(int i=2;i*i<=n;i=i+6){
        //     if(n%i==0 ||(n%(i+6)==0)) Console.WriteLine("no is not prime");
        //     else Console.WriteLine("no is prime");
        // }

        Day4 obj=new Day4(50,30);
        int r1=obj.Add(10,20);
        Console.WriteLine("The sum is: "+r1);
        int r2=obj.Sub();
        Console.WriteLine("The diff is: "+r2);
        obj.Add1(100,200);
        obj.Sub1();

        // int myNum = 5;
        // obj.SquareNormal(myNum);
        // Console.WriteLine("After Normal: " + myNum);
        // obj.Square(ref myNum);
        // Console.WriteLine("After Ref: " + myNum);   


        Calculator calculator2=new Calculator();
        calculator2.swap(30,20);

        //call by reference
        int n1=30;
        int n2=50;
        calculator2.swap1(ref n1,ref n2);


        Calculator calculator3=new Calculator();
        int num1=30;
        int num2=50;
        int result=0;
        int num3=0;
        int num4=0;
        calculator3.Addition(num1,num2,out result,out num3,out num4);
        Console.WriteLine($"First number is {num3} second number is {num4} and Additiion is {result}");


    }
}
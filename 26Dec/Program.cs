// using System;
// class Program{
//   //  public delegate int Calculatedelegate(int num1,int num2);
//     public static void Main(string[] args){
//         // Creditcard c=new Creditcard();
//         // c.Pay(156.37);
//         // c.Refund(345.90);
//         // UPIPayment ui=new UPIPayment();
//         // ui.Pay(102.47);
//         // ui.Refund(1239.76);

//         // Manager m=new Manager();
//         // m.GetEmployeeDetails();
//         // m.EmployeeDetails();
//         // m.CalculateSalry();

//         // PartialEmployee ee=new PartialEmployee();
//         // ee.FirstName="Abhiranjan";
//         // ee.LastName="Kumar";
//         // ee.Salary=100000;
//         // ee.Gender="M";
//         // ee.DisplayFullName();
//         // ee.DisplayInfo();
//         // ee.Partialmethod();

            //Calculator c=new Calculator();

            //initializing the delegates
            // Calculatedelegate cadd=new Calculatedelegate(c.Add);
            // Calculatedelegate csub=new Calculatedelegate(c.Sub);
            // Calculatedelegate cmul=new Calculatedelegate(c.Mul);
            // Calculatedelegate cdiv=new Calculatedelegate(c.Div);

            // Calculatedelegate multidelegate;

            // int add=cadd(10,30);
            // Console.WriteLine("the sum is: "+add);
            // int sub=csub(10,30);
            // Console.WriteLine("the sub is: "+sub);
            // int mul=cmul(10,30);
            // Console.WriteLine("the mul is: "+mul);
            // int div=cdiv(30,10);
            // Console.WriteLine("the div is: "+div);

            // multidelegate=cadd;
            // Console.WriteLine("Called multicast delegate  add: "+multidelegate(300,60));
            // multidelegate+=csub;
            // Console.WriteLine("Called multicast delegate sub: "+multidelegate(300,60));
            // multidelegate+=cmul;
            // Console.WriteLine("Called multicast delegate mul: "+multidelegate(300,60));
            // multidelegate+=cdiv;
            // Console.WriteLine("Called multicast delegate div: "+multidelegate(300,60));


//         int n;
//         Console.WriteLine("Enter the number:");
//         n=int.Parse(Console.ReadLine());
//         if(n<=0){
//             Console.WriteLine("Please enter the valid no");
//             return;
//         } 
//         string[] arr=new string[n];
//         for(int i=0;i<n;i++){
//             arr[i]=Console.ReadLine();
//         }
//         Animal an=new Animal();
//         Dog d= new Dog();
//         Cat c=new Cat();
//         Console.WriteLine("Sound of animal in array: ");
//         for(int i=0;i<n;i++){
//             if(arr[i]=="Animal") an.MakeSound();
//             else if(arr[i]=="Dog") d.MakeSound();
//             else c.MakeSound();
//         }
        
//     }
// }
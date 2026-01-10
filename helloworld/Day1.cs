using System;

class HelloWorld{
    public void greeting(){
        Console.WriteLine("Hello Abhi...");
    }
    public void readNo(){
        int no;
        Console.WriteLine("Enter the No: ");
        no=int.Parse(Console.ReadLine());
        Console.WriteLine("The No is: "+no);

    }
    public void readFloat(){
        float num;
        Console.WriteLine("Enter the No: ");
        num=float.Parse(Console.ReadLine());
        Console.WriteLine("The No is: "+num);
    }
    public void readString(){
        string s;
        Console.WriteLine("Enter the String: ");
        s=Console.ReadLine();
        Console.WriteLine("The string is: "+s);
    }
    public void areaOfCircle(){
        float radius;
        Console.WriteLine("Enter the radius: ");
        radius=int.Parse(Console.ReadLine());
        float res=3.14f*radius*radius;
        Console.WriteLine("The area of circle is: "+res);
    }
    public void arithOper(){
        int num1,num2,res;
        Console.WriteLine("Enter the 1st no: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2nd no: ");
        num2=int.Parse(Console.ReadLine());
        res=num1+num2;
        Console.WriteLine("The Sum is: "+res);
        res=num1-num2;
        Console.WriteLine("The Diff is: "+res);
        res=num1*num2;
        Console.WriteLine("The Mul is: "+res);
        res=num1/num2;
        Console.WriteLine("The Div is: "+res);
    }
    public void evenOdd(){
        int num;
        Console.WriteLine("Enter the no: ");
        num=int.Parse(Console.ReadLine());
        if(num%2==0) Console.WriteLine("No is even");
        else Console.WriteLine("No is odd");
    }

    public void greatOfTwo(){
        int num1,num2;
        Console.WriteLine("Enter the 1st no: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2nd no: ");
        num2=int.Parse(Console.ReadLine());
        if(num1>num2) Console.WriteLine("The greater no is: "+num1);
        else Console.WriteLine("The greater no is: "+num2);
    }
    public void checkNo(){
        int num;
        Console.WriteLine("Enter the no: ");
        num=int.Parse(Console.ReadLine());
        if(num==0) Console.WriteLine("the given no is zero");
        else if(num>0) Console.WriteLine("the given no is positive");
        else Console.WriteLine("The no is negative");

    }
    public void nestedIf(){
        int num1,num2,num3;
        Console.WriteLine("Enter the 1st no: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 2nd no: ");
        num2=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the 3rd no: ");
        num3=int.Parse(Console.ReadLine());
        int res;
        if(num1>=num2){
            if(num1>=num3) res=num1;
            else res=num3;
        }else {
            if (num2>=num3) res=num2;
            else  res=num3;
        }
        Console.WriteLine("the gretest no is: "+res);
    }
}
using System;
class Student{
    string name;
    private float sub1,sub2,sub3,sub4,sub5,sub6;
    public float Sub1{
        set{
            sub1=value;
        }
        get{
            return sub1;
        }
    }
    public float Sub2{
        set{
            sub2=value;
        }
        get{
            return sub2;
        }
    }
    public float Sub3{
        set{
            sub3=value;
        }
        get{
            return sub3;
        }
    }
    public float Sub4{
        set{
            sub4=value;
        }
        get{
            return sub4;
        }
    }
    public float Sub5{
        set{
            sub5=value;
        }
        get{
            return sub5;
        }
    }
    public float Sub6{
        set{
            sub6=value;
        }
        get{
            return sub6;
        }
    }
    public void getDetails(){
        Console.WriteLine("Enter the detail");
        Console.Write("Enter the name: ");
        name=Console.ReadLine();
        Console.Write("Enter the sub1 marks: ");
        sub1=int.Parse(Console.ReadLine());
        Console.Write("Enter the sub2 marks: ");
        sub2=int.Parse(Console.ReadLine());
        Console.Write("Enter the sub3 marks: ");
        sub3=int.Parse(Console.ReadLine());
        Console.Write("Enter the sub4 marks: ");
        sub4=int.Parse(Console.ReadLine());
        Console.Write("Enter the sub5 marks: ");
        sub5=int.Parse(Console.ReadLine());
        Console.Write("Enter the sub6 marks: ");
        sub6=int.Parse(Console.ReadLine());
    }
    public float total(){
        return sub1+sub2+sub3+sub4+sub5+sub6;
    }
    public float average(){
        float tot=total();
        return tot/6;
    }
    public void gradedetails(){
        float avg=average();
        Console.WriteLine("The total is : "+total());
        Console.WriteLine("The avg is : "+avg);
        if(avg>=90) Console.WriteLine("Student grade is GRADE A");
        else if(avg>=80 && avg<90) Console.WriteLine("Student grade is GRADE B");
        else if(avg>=70 && avg<80) Console.WriteLine("Student grade is GRADE c");
        else if(avg>=60 && avg<70) Console.WriteLine("Student grade is GRADE D");
        else Console.WriteLine("Student grade is GRADE E");
    }
}
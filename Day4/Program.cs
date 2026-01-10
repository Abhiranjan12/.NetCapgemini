class main{
    public static void Main(String[] args){
        //default
        // PracticeQues pq=new PracticeQues();
        // //parametrized
        // PracticeQues pq1=new PracticeQues(200,400);
        // Console.WriteLine("This Addition is: "+pq1.Addition(150,90));
        // pq1.Subtraction();
        // pq1.Division();
        // Console.WriteLine("This Multiplication is: "+pq1.Multiply(10,100));

        // EmployeePayroll ee=new EmployeePayroll();
        // int sal1=50000,sal2=60000;
        // ee.EmpSal(sal1,sal2);
        // Console.WriteLine("Actual Value of sal1:  "+sal1);
        // Console.WriteLine("Actual Value of sal2 is: "+sal2);


        // int id1=101,id2=102;
        // Console.WriteLine("The id of employee1 is: "+id1);
        // Console.WriteLine("The id of employee2 is: "+id2);
        // HrSystem hr=new HrSystem();
        // hr.ChangeId(ref id1,ref id2);


        // int mark1=90,mark2=95,res=0,m1=0,m2=0;
        // StudentMarks st=new StudentMarks();
        // st.StuMarks(mark1,mark2,out res,out m1,out m2);
        // Console.WriteLine("the marks1 is : "+m1);
        // Console.WriteLine("the marks2 is : "+m2);
        // Console.WriteLine("the res is : "+res);


        // int num1=40,num2=45,res=0,n1=0,n2=0;
        // Calculator c=new Calculator();
        // c.Calc(num1,num2,out res,out n1,out n2);
        // Console.WriteLine("the no1 is : "+n1);
        // Console.WriteLine("the no2 is : "+22);
        // Console.WriteLine("the res is : "+res);

        StaticandInst st=new StaticandInst();
        st.demo1();
        st.demo1();
        st.demo1();
        Console.WriteLine(st.Demores());
        StaticandInst st1=new StaticandInst();
        Console.WriteLine("After: " +st1.Demores());
        
        // static belong to class itself
        StaticandInst.demo2();
        StaticandInst.demo2();
        StaticandInst.demo2();
        StaticandInst.demo2();
        Console.WriteLine(StaticandInst.DemoRes());

        StaticandInst.demo2();
        Console.WriteLine("After: "+StaticandInst.DemoRes());
    }
}

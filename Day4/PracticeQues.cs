// using System;

// class PracticeQues{
//     public int num1{get;set;}
//     public int num2{get;set;}
//     public int res{get;set;}
//     //default constructor
//     public PracticeQues(){
//         num1=0;
//         num2=0;
//     }
//     //parameterized comstructor
//     public PracticeQues(int num1,int num2){
//         this.num1=num1;
//         this.num2=num2;
//     }

//     public int Addition(int num1,int num2){
//         return num1+num2;
//     }

//     public void Subtraction(){
//         Console.WriteLine("the Diff is: "+(num2-num1));
//     }

//     public int Multiply(int num1,int num2){
//         return num1*num2;
//     }

//     public void Division(){
//         Console.WriteLine("the Div is: "+num2/num1);
//     }
// }

// ============================EMPLOYEE PAYROLL QUES 3===============

// class EmployeePayroll{
//     public void EmpSal(int salary1,int salary2){
//         Console.WriteLine("Before Swapping the value of salary1 is: "+salary1+" salary2 is: "+salary2);
//         int temp=salary2;
//         salary1=salary2;
//         salary2=temp;
//         Console.WriteLine("After Swapping the value of salary1 is: "+salary1+" salary2 is: "+salary2);
//         int sum=salary1+salary2;
//         Console.WriteLine("The Sum of Slary is: "+sum);
//     }
// }

// //=======================Ques 4====================

// class HrSystem{
//     public void ChangeId(ref int id1,ref int id2){
//         int temp=id1;
//         id1=id2;
//         id2=temp;
//         Console.WriteLine("The id of employee1 after swappping is: "+id1);
//         Console.WriteLine("The id of employee2 after swappping is: "+id1);
//     }
// }


// // ===================ques 5

// class StudentMarks{
//     // return vlue without return type

//     public void StuMarks(int mark1,int mark2,out int res,out int m1,out int m2){
//         res=mark1+mark2;
//         m1=mark1;
//         m2=mark2;
//     }
// }



// class Calculator{
//     // return vlue without return type

//     public void Calc(int num1,int num2,out int res,out int n1,out int n2){
//         res=num1+num2;
//         n1=num2;
//         n2=num2;
//     }
// }
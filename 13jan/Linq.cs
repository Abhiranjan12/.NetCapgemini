using System;
using System.Linq;
using System.Data;
using System.Security.Cryptography;

class Student
{
    public string name{set;get;}
    public int age{set;get;}
}
class Employee : DataTable
{
    public Employee()
    {
        this.Columns.Add("Id",typeof(int));
        this.Columns.Add("Name",typeof(string));
        this.Columns.Add("Age",typeof(int));
        this.Columns.Add("Department",typeof(string));
        this.Columns.Add("Salary",typeof(int));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //======================================================================
        // datasource
        // string[] name={"rohan","mohan","gill","john","steve","mariea"};
        // // write the query
        // var namewitha=from s in name
        //          where s.Contains('a')
        //          select s;
        // // lambda expression 
        //  var nam=name.Where(s=>s.Contains('a'));
        // // execute the query
        // foreach(var i in nam) Console.WriteLine(i);
        // =======================================================================
        // List<string> li=new List<string>();                                   
        // li.Add("C# tutorials");                                                        
        // li.Add(".net tutorials");
        // li.Add("c#");
        // li.Add("python");
        // var res=from s in li where s.Contains("tutorial") select s;
        // foreach(string s in res) Console.WriteLine(s);
        //========================================================================
        // Student si=new Student();
        // List<Student> st=new List<Student>();
        // st.Add(new Student { name = "John", age = 29 });
        // st.Add(new Student { name = "Rohn", age = 25 });
        // st.Add(new Student { name = "Daniel", age = 28 });
        // st.Add(new Student { name = "Maria", age = 22 });
        // st.Add(new Student { name = "Steve", age = 23 });
        // var stud = from s in st
        //         where s.age > 20 && s.age <= 25
        //         select s;
        // Console.WriteLine("The data of student is:");
        // foreach (Student stu in stud)
        // {
        //     Console.WriteLine("Name is: " + stu.name + "  Age is: " + stu.age);
        // }
        //========================================================================
        var emp = new Employee();
        emp.Rows.Add(1, "rohn", 30, "IT", 28839);
        emp.Rows.Add(2, "daniel", 30, "Finance", 27000);
        emp.Rows.Add(3, "steve", 30, "Production", 33000);
        emp.Rows.Add(4, "john", 30, "IT", 29000);
        emp.Rows.Add(5, "maria", 30, "IT", 28850);
        emp.Rows.Add(6, "nancy", 30, "sales", 32000);
        emp.Rows.Add(7, "jacob", 30, "HR", 31389);

        var query = from empe in emp.AsEnumerable()
                    where empe.Field<string>("Department") == "IT"
                    orderby empe.Field<int>("Salary") descending
                    select new
                    {
                        Id = empe.Field<int>("Id"),
                        Name = empe.Field<string>("Name"),
                        Salary = empe.Field<int>("Salary"),
                        Dept = empe.Field<string>("Department")
                    };
        foreach (var ep in query)
        {
            Console.WriteLine("Id is: "+ep.Id+" Name is: "+ep.Name+" Salary is: "+ep.Salary);
        }
    }
}
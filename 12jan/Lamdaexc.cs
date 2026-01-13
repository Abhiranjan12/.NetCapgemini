// using System;
// class Student
// {
//     public string name { get; set; }
//     public int age { get; set; }
// }
// class Program
// {
//     public delegate bool IsTeenager(Student stu);
//     static void Main(string[] args)
//     {
//         Student student = new Student
//         {
//             name = "Abhi",
//             age = 17
//         };
//         IsTeenager anon = delegate (Student s)
//         {
//             return s.age > 13 && s.age < 19;
//         };
//         Console.WriteLine(anon(student));
//         Console.WriteLine("Anonymous method result: " + anon(student));
//         IsTeenager lambda = s => s.age > 13 && s.age < 19;
//         Console.WriteLine("Lambda expression result: " + lambda(student));
//     }
// }

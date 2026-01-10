// using System;
// class Employee : IComparable<Employee> {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public Employee(int id, string name) {
//         Id = id;
//         Name = name;
//     }
//     public int CompareTo(Employee other) {
//         return this.Id.CompareTo(other.Id);
//     }
//     public override string ToString() {
//         return $"Employee ID: {Id}, Name: {Name}";
//     }
//     public static void Main(string[] args) {
//         Employee[] ep = new Employee[4];
//         ep[0] = new Employee(15, "Ravi");
//         ep[1] = new Employee(12, "Rohan");
//         ep[2] = new Employee(14, "Sohan");
//         ep[3] = new Employee(13, "Mohan");
//         Console.WriteLine("--- Before Sorting ---");
//         foreach (var e in ep) Console.WriteLine(e);
//         Array.Sort(ep);
//         Console.WriteLine("\n--- After Sorting (by ID) ---");
//         foreach (var e in ep) Console.WriteLine(e);
//     }
// }
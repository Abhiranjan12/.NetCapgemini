// using System;
// using System.Dynamic;
// using System.Runtime.CompilerServices;
// class Patient
// {
//     public int PatientId{get;}
//     public string Name{get;set;}
//     public int Age{set;get;}
//     public string medical_history;

//     public Patient()
//     {
//         PatientId=1;
//         Name="Mohan";
//         Age=55;
//         medical_history="Not";
//     }
//     public Patient(int PatientId,string Name,int Age,string medical_history)
//     {
//         this.PatientId=PatientId;
//         this.Name=Name;
//         this.Age=Age;
//         this.medical_history=medical_history;
//     }
//     public void SetMedicalHistory()
//     {
//         Console.Write("Enter the id os patient: ");
//         PatientId=int.Parse(Console.ReadLine());
//         Console.Write("Enter Name: ");
//         Name=Console.ReadLine();
//         Console.Write("Enter age: ");
//         Age=int.Parse(Console.ReadLine());
//         Console.WriteLine("Medical history is: ");
//         medical_history=Console.ReadLine();
//     }
//     public void RetriveMedicalHistory()
//     {
//         Console.WriteLine("Id of patient is: "+PatientId);
//         Console.WriteLine("Name is: "+Name);
//         Console.WriteLine("Age is: "+Age);
//         Console.WriteLine("medical history is: "+medical_history);
//     }
// }
// class Doctor
// {
//     public string Name{get;set;}
//     public string Specilazation{get;set;}
//     public string License_Number{get;}
//     static public int total_doctor;
//     static public Doctor()
//     {
//         total_doctor=0;
//     }
//     public Doctor(string Name,string Specilazation,string License_Number)
//     {
//         this.Name=Name;
//         this.Specilazation=Specilazation;
//         this.License_Number=License_Number;
//         total_doctor++;
//     }
// }

// class Appointment
// {
//     public void ScheduleAppointment(string patient)
//     {
//         Console.WriteLine("The doctor name is: "+patient);
//     }
//     public void ScheduleAppointment(string patient, DateTime date)
//     {
//         Console.WriteLine("The doctor name is: "+patient);
//         Console.WriteLine("Date is: "+date.ToShortDateString());
//     }
//      public void ScheduleAppointment(string patient, DateTime date,string mode)
//     {
//         Console.WriteLine("The doctor name is: "+patient);
//         Console.WriteLine("Date is: "+date.ToShortDateString());
//         Console.WriteLine("Mode is: "+mode);
//     }
// }
// class MedicalRecord
// {
//     public string diagnosis{get;set;}
//     public string history{get;set;}
//     MedicalRecord(string diagnosis,string history)
//     {
//         this.diagnosis=diagnosis;
//         this.history=history;
//     }
//     public void getSummary()
//     {
//         Console.WriteLine("Patient is diagonized or not: "+diagnosis);
//         Console.WriteLine("History of patient is: ");
//     }
// }

// class DiagnosisService
// {
//     public void Evaluate(in int age, ref string condition,out string riskLevel,params int[] testScores)
//     {
        
//     }
// }
// using System;
// class PatientBill{
//    public string BillId;
//    public string PatientName;
//    public bool HasInsurence;
//    public double  ConsultationFee;
//    public  double LabCharges;
//    public double MedicineCharges;
//    public double GrossAmount;
//    public double DiscountAmount;
//    public double FinalPayable;
//    public static PatientBill LastBill=null;
//    public static bool HasLastBill = false;
//    public void CreateNewBill(){
//         Console.WriteLine("Enter Bill ID: ");
//         BillId=Console.ReadLine();
//         if (string.IsNullOrWhiteSpace(BillId)){
//             Console.WriteLine("Bill Id cannot be empty.");
//             return;
//         }
//         Console.WriteLine("Enter Patient Name: ");
//         PatientName=Console.ReadLine();
//         Console.WriteLine("Is the Patient insured? (Y/N): ");
//         string Insurence=Console.ReadLine();
//         if(Insurence=="Y"||Insurence=="y")
//             HasInsurence=true;
//         else if(Insurence=="N"||Insurence=="n")
//             HasInsurence=false;
//         else{
//             Console.WriteLine("Invalid insurance option.");
//             return;
//         }
//         Console.WriteLine("Enter Consultation Fee: ");
//         ConsultationFee=double.Parse(Console.ReadLine());
//         Console.WriteLine("Enter Lab Charges: ");
//         LabCharges=double.Parse(Console.ReadLine());
//         Console.WriteLine("Enter Medicine Charges: ");
//         MedicineCharges=double.Parse(Console.ReadLine());
//         GrossAmount=ConsultationFee+LabCharges+MedicineCharges;
//         if(HasInsurence) DiscountAmount=GrossAmount*0.10;
//         else DiscountAmount=0;
//         FinalPayable = GrossAmount - DiscountAmount;
//         LastBill = this;
//         HasLastBill = true;
//         Console.WriteLine("Bill created successfully.");
//         Console.WriteLine("Gross Amount: "+GrossAmount);
//         Console.WriteLine("Discount Amount: "+DiscountAmount);
//         Console.WriteLine("Final Payable: "+FinalPayable);
//     }
//     public static void ViewLastBill(){
//         if(!HasLastBill){
//             Console.WriteLine("No bill available. Please create a new bill first.");
//             return;
//         }
//         Console.WriteLine("----------- Last Bill -----------");
//         Console.WriteLine("BillId: "+LastBill.BillId);
//         Console.WriteLine("Patient: "+LastBill.PatientName);
//         Console.WriteLine("Insured: "+ (LastBill.HasInsurence ? "Yes" : "No"));
//         Console.WriteLine("Consultation Fee: "+LastBill.ConsultationFee);
//         Console.WriteLine("Lab Charges: "+LastBill.LabCharges);
//         Console.WriteLine("Medicine Charges: "+LastBill.MedicineCharges);
//         Console.WriteLine("Gross Amount: "+LastBill.GrossAmount);
//         Console.WriteLine("Discount Amount: "+LastBill.DiscountAmount);
//         Console.WriteLine("Final Payable: "+LastBill.FinalPayable);
//     }
//     public static void ClearLastBill(){
//         LastBill=null;
//         HasLastBill=false;
//         Console.WriteLine("Last bill cleared.");
//     }
//     public static void Main(string[] args){
//         PatientBill pa=new PatientBill();
//         while(true){
//             Console.WriteLine("=========MediSure Clinic Billing=========");
//             Console.WriteLine("1. Create New Bill (Enter Patient Details)");
//             Console.WriteLine("2. View Last Bill");
//             Console.WriteLine("3. Clear Last Bill");
//             Console.WriteLine("4. Exit");
//             int opt;
//             Console.Write("Enter the option: ");
//             opt=int.Parse(Console.ReadLine());
//             switch(opt){
//                 case 1:
//                 pa.CreateNewBill();
//                 break;
//                 case 2:
//                 ViewLastBill();
//                 break;
//                 case 3:
//                 ClearLastBill();
//                 break;
//                 case 4:
//                 Console.WriteLine("Thank you. Application closed normally.");
//                 break;
//                 default:
//                 Console.WriteLine("Enter correct Value");
//                 break;
//             }
//         }
//     }
// }
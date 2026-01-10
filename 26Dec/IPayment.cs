using System;
internal interface IPayment{
    // by default abstract
    void Pay(double amount);
    void Refund(double amount);
}
class Creditcard:IPayment{
    public void Pay(double amount){
        Console.WriteLine("Paid "+amount+" using credit card");
    }
    public void Refund(double amount){
        Console.WriteLine("Refunded "+amount+" using credit card");
    }
}
class UPIPayment:IPayment{
    public void Pay(double amount){
        Console.WriteLine("Paid "+amount+" using UPI Payment");
    }
    public void Refund(double amount){
        Console.WriteLine("Refunded "+amount+" using UPI Payment");
    }
}
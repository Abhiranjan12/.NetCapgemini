using System;
using System.Collections.Generic;
using System.Linq;
interface IReportable
{
    void GetSummary();
}
abstract class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
}
class ExpenseTransaction : Transaction, IReportable
{
    public string Category { get; set; } 
    public void GetSummary()
    {
        Console.WriteLine("--- Expense Detail ---");
        Console.WriteLine("Id is: " + Id);
        Console.WriteLine("Date is: " + Date.ToShortDateString());
        Console.WriteLine("Amount is: " + Amount);
        Console.WriteLine("Category is: " + Category);
        Console.WriteLine("Description is: " + Description);
    }
}
class IncomeTransaction : Transaction, IReportable
{
    public string Source { get; set; }
    public void GetSummary()
    {
        Console.WriteLine("--- Income Detail ---");
        Console.WriteLine("Id is: " + Id);
        Console.WriteLine("Date is: " + Date.ToShortDateString());
        Console.WriteLine("Amount is: " + Amount);
        Console.WriteLine("Source is: " + Source);
        Console.WriteLine("Description is: " + Description);
    }
}
class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();
    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }
    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();
        foreach (T t in transactions)
        {
            if (t.Date.Date == date.Date)
            {
                result.Add(t);
            }
        }
        return result;
    }
   public double CalculateTotal()
    {
        double total = 0;
        foreach (T t in transactions)
        {
            total += t.Amount;
        }
        return total;
    }
    public List<T> GetAll()
    {
        return transactions;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeLedger;
        Ledger<ExpenseTransaction> expenseLedger;
        incomeLedger = new Ledger<IncomeTransaction>();
        expenseLedger = new Ledger<ExpenseTransaction>();
        IncomeTransaction incomeTransaction;
        ExpenseTransaction expenseTransaction;
        incomeTransaction = new IncomeTransaction();
        incomeTransaction.Id = 1;
        incomeTransaction.Date = DateTime.Now;
        incomeTransaction.Amount = 500;
        incomeTransaction.Source = "Main Cash";
        incomeTransaction.Description = "Petty cash replenishment";
        expenseTransaction = new ExpenseTransaction();
        expenseTransaction.Id = 1;
        expenseTransaction.Date = DateTime.Now;
        expenseTransaction.Amount = 20;
        expenseTransaction.Category = "Stationery";
        expenseTransaction.Description = "Office supplies";
        incomeLedger.AddEntry(incomeTransaction);
        expenseLedger.AddEntry(expenseTransaction);
        double totalIncome;
        double totalExpense;
        double netBalance;
        totalIncome = incomeLedger.CalculateTotal();
        totalExpense = expenseLedger.CalculateTotal();
        netBalance = totalIncome - totalExpense;
        Console.WriteLine("Total Income: " + totalIncome);
        Console.WriteLine("Total Expense: " + totalExpense);
        Console.WriteLine("Net Balance: " + netBalance);
        List<Transaction> allTransactions;
        allTransactions = new List<Transaction>();
        List<IncomeTransaction> incomeTransactionsList;
        List<ExpenseTransaction> expenseTransactionsList;
        incomeTransactionsList = incomeLedger.GetAll();
        expenseTransactionsList = expenseLedger.GetAll();
        allTransactions.AddRange(incomeTransactionsList);
        allTransactions.AddRange(expenseTransactionsList);
        IReportable reportableTransaction;
        foreach (Transaction t in allTransactions)
        {
            reportableTransaction = (IReportable)t;
            reportableTransaction.GetSummary();
        }

    }
}
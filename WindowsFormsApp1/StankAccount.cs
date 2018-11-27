using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public static class User
{
    public static string Name = "Joe";
    public static string AccountNumber = "999999999999999";
    public static int Pin = 7890;
    public static List<BankAccount> Accounts = new List<BankAccount>();
    public static List<XactLog> record = new List<XactLog>();

    public static void LoadAccounts()
    {
        BankAccount chequing = new BankAccount("Chequing", 999.87f);
        BankAccount savings = new BankAccount("Savings", 5520.34f);
        Accounts.Add(chequing);
        Accounts.Add(savings);
    }

    public static void LoadLog()
    {
        XactLog e3 = new XactLog("Chequing", "Deposit", "Deposit-Pay", 1099.87f);
        XactLog e2 = new XactLog("Chequing", "Purchase", "Purchase Tim Hortons", 100.00f);
        XactLog e1 = new XactLog("Savings", "Deposit", "Account Opening", 5760.34f);
        XactLog e4 = new XactLog("Savings", "Withdrawal", "Cash Withdrawal From ATM", 240.00f);
        record.Add(e1);
        record.Add(e2);
        record.Add(e3);
        record.Add(e4);
    }

}

public class BankAccount
{
   public BankAccount(string name, float amount)
    {
        Name = name;
        Balance = amount;
    }

    public string Name { get; }
    public float Balance { get; set;}
    public override string ToString()
    {
        return Name + ": $" + Balance;
    }
}

public class XactLog
{
    public XactLog(string name, string type, string msg, float amount)
    {
        Name = name;
        Type = type;
        amt = amount;
        message = msg;
    }

    public string Name { get; }
    public string message { get; }
    public float amt { get; set; }
    public string Type { get; set; }
    public override string ToString()
    {
        return "Account: " + Name + ", " + Type + "              $ " + amt;
    }

}
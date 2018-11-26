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

    public static void LoadAccounts()
    {
        BankAccount chequing = new BankAccount("Chequing", 999.87f);
        BankAccount savings = new BankAccount("Savings", 5520.34f);
        Accounts.Add(chequing);
        Accounts.Add(savings);
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

using System.Collections.Generic;
using BankAccount;

Console.WriteLine("Welcome to Simple Banking Application");
Console.WriteLine();

Account a1 = new Account(1,15000);
a1.Deposit(5000);
//float CurrentBalance = a1.GetBalance();

Account a2 = new Account(2,25000);
a2.Deposit(10000);

List<Account> accounts = new List<Account>();
accounts.Add(a1);
accounts.Add(a2);

foreach(Account theAccount in accounts){
    Console.WriteLine("Current Balance = {0}"+theAccount.ToString());
}

//Console.WriteLine("Balance : "+CurrentBalance);


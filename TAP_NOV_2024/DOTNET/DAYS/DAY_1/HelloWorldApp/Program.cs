using System.Collections.Generic;
using System.Reflection;
using Banking;
using Maths;

var p = new{FirstName = "Kaustubh", LastName = "Patil"};

Console.WriteLine(p.FirstName + " " + p.LastName);
int count = 12;
string company = "Transflower";

count++;
Console.WriteLine("Count = " +count);
Console.WriteLine(company);
Console.WriteLine("Hello, World!");

Account acc123 = new Account(60000);
acc123.Deposit(15000);
float currentBalance123= acc123.GetBalance();
Console.WriteLine(currentBalance123);

acc123.Withdraw(74000);
Console.WriteLine(acc123.GetBalance());

Account acc234 = new Account();
float currentBalance234 = acc234.GetBalance();
Console.WriteLine(currentBalance234);

List<Account> accounts = new List<Account>();
accounts.Add(acc123);
accounts.Add(acc234);

foreach( Account theAccount in accounts){
    float result = theAccount.GetBalance();
    Console.WriteLine("Current Balance={0}", result);
}



Complex  c1=new Complex(34,56);
Complex c2=new Complex(11,78);
Complex c3=c1 + c2;

Console.WriteLine(c3.Real);
Console.WriteLine(c3.Imag);
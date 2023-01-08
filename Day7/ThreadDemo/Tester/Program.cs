using System.Threading;
using Banking;
using EGovernance;

Thread primaryThread =Thread.CurrentThread;
Console.WriteLine("Thread in Program.cs = "+primaryThread.ManagedThreadId);

CentralGov bjpGovt=new CentralGov();
TaxOperation itOperation=new TaxOperation(bjpGovt.DeductIncomeTax);
TaxOperation proOperation=new TaxOperation(bjpGovt.DeductProfessionalTax);

// different methods to invoke threads
// 1st type
itOperation(5000);
proOperation(1000);

// 2nd type
itOperation.Invoke(3000);
itOperation.Invoke(4000);

// 3rd type ==>  not supported
// IAsyncResult iResult=itOperation.BeginInvoke(5000,null,null);
// if(iResult.IsCompleted)
// {
//     Console.WriteLine(" Task is completed....");
// }
// proOperation.BeginInvoke(1000,null, null);

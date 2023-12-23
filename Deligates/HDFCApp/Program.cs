using bankrecord;
using notify;
using tax;
using txtop;
using NotifyUser;
using System.Threading;
// Account ac=new Account();


//comment
/*Account.Balance=2000;
Console.WriteLine("Previous Balanced " + Account.Balance);
/*ac.Deposite(5000);
Console.WriteLine("After Deposite "+ac.Balance);
ac.withdraw(1000);
Console.WriteLine("After Withdraw "+ac.Balance);*/
//comment end

//Taxation tx=new Taxation();
//Synchronous Call------------Direct Call(Blocking Call)
//tx.SalesTax(5465);
// tx.GstTax();
// tx.IncomeTax();  
//--------------------------

//Notification.SendEmail("Chinmay12@gmail.com","Credited");
//Notification.SendSms("+91-124-123-7689","Credited");

//deligates objects ---------- asynchronous call (Non-Blocking call)
//comment
/*TaxOperation tx1=new TaxOperation(Account.withdraw);
//tx1(1000);

NotificationOperation se=new NotificationOperation(Notification.SendEmail);
NotificationOperation sm=new NotificationOperation(Notification.SendSms);

NotificationOperation proxy=null;
//chaining attachment so here it will call all the function associated with it
proxy+=se;
proxy+=sm;
proxy("Tusharcfo@gmail.com","Happy New Year!!!!");

proxy-=sm;
//deattachement so here only call that function which is attached to it
proxy("Sahilcfo@gmail.com","Happy New Year!!!!");


//skipping for now,unsertand it later
//Asynchronous calling
//IAsyncResult iResult=proxy.BeginInvoke("sarang","Thank you",null,null);
                   
// Obtain the result of the Add() method when ready.
//proxy.EndInvoke(iResult);


//Current thread Info :- Which is primary thread
Thread th=Thread.CurrentThread;
int threadId=th.ManagedThreadId;
Console.WriteLine("Thread Id : " + threadId);
Console.WriteLine("Thread Priority is : "+th.Priority);*/
//cooment end


Account.overBalance+=Taxation.SalesTax;
Account.underBalance+=Taxation.SalesTax;

Account.Balance=80756;
Console.WriteLine("Current balance is"+Account.Balance);
Account.withdraw(80000);

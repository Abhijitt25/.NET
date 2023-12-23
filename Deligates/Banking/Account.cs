namespace bankrecord;
using txtop;
using NotifyUser;

public  class Account{

    public static event TaxOperation underBalance;
    public static  event TaxOperation overBalance;

    public static float Balance{get;set;}

    public static void Deposite(int amount)
    {
        Balance+=amount;
        if(Balance>=50000)
            overBalance(20020);
        
        
        Console.WriteLine("Current Balance Is: "+Balance);
    }

    public static void withdraw(int amount)
    {
        if(Balance<=0 || amount>Balance)
        {
            Console.WriteLine("Balance is insuffienct");
            
           // return Balance;
        }else{
        float curr_bal=Balance;
        Console.WriteLine("Before withdrawl Balance is: "+Balance);
        Balance-=amount;
        Console.WriteLine("After Withdraw Balance is: "+Balance);
        if(Balance<=10000)
            underBalance(2000);
        }

        //return curr_bal;
    }

}
namespace bookrecord;
using ackDeligate;

public class Books{
    
    public event AckDeligates msg;
    public String Name{get;set;}
    public String Subject{get;set;}
    public int NoOfCopies{get;set;}


    public void borrow(String name,String subject,int noOfCopies)
    {
        if(noOfCopies>NoOfCopies)
        {
            msg();
            return;
        }

        Console.WriteLine("Borrowed : BookName "+name+" Subject "+subject+" NoofCopies "+noOfCopies);

    }
}
namespace tax;

public  class Taxation{
    
    public static void SalesTax(int amount)
    {
        Console.WriteLine("Sales Tax "+amount);
       // return 0.0f;
    }

    public static void IncomeTax()
    {
        Console.WriteLine("Income Tax");
    }
    public static void GstTax()
    {
        Console.WriteLine("GstTax");
    }

}
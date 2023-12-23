namespace notify;

public static class Notification{

    public static void SendEmail(String to,String content)
    {

        Console.WriteLine("Email sent to: "+ to);
    }
    public static void SendSms(String to,String content)
    {
        Console.WriteLine("Sms Sent to: " + to);    
    }
    



}
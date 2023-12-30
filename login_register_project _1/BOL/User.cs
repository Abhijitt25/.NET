namespace BOL;

public class User
{
    public string Uname{get;set;}
    public string Pass{get;set;}
    public string Email{get;set;}

    public User(string uname,string pass,string email)
    {
        this.Uname=uname;
        this.Pass=pass;
        this.Email=email;
    }
}

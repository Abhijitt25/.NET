namespace BLL;
using DAL;
using BOL;
public class UserManager{
    public List<User> getAll(){
        return DBManager.getAllUser();
    }
    public Boolean checkUser(string email, string pass){
        return DBManager.validate(email, pass);
    }
    public Boolean register(string email, string uname, string pass){
        return DBManager.insert(email, uname, pass);
    }
}

namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    private static string conString = "server=192.168.10.150;port=3306;user=dac17;password=welcome;database=dac17";
    private static MySqlConnection con = null;
    public static List<User> getAllUser(){
        List<User> u_list = new List<User>();
        con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from login";
        MySqlCommand cmd = new MySqlCommand(query, con);
        try{
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read()){
                string uname = rd["username"].ToString();
                string pass = rd["password"].ToString();
                string email = rd["email"].ToString();
                u_list.Add(new User(uname, pass, email));
            }
            rd.Close();
        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            con.Close();
        }
        return u_list;
    }
    public static Boolean validate(string email, string pass){
        List<User> u_list = getAllUser();
        foreach(User u in u_list){
            if(u.Email==email && u.Pass==pass)
                return true;
        }
        return false;
    }
    
    public static Boolean insert(string email, string uname, string pass){
        List<User> u_list = getAllUser();
        Boolean flag = true;
        foreach(User u in u_list){
            if(u.Email==email || u.Pass==pass)
                flag = false;
        }
        if(flag){
            string query = "insert into login values(@uname, @pass, @email)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname",uname);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            try{
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e){
                Console.WriteLine("Error: "+e.Message);
            }
            finally{
                con.Close();
            }
            return true;
        }
        else{
            return false;
        }
    }
}

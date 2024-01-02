namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
public class DBConnect {
    private static MySqlConnection con = null;
    private static string conString="server=192.168.10.150;port=3306;user=dac17; password=welcome;database=dac17";
    public DBConnect(){
        con = new MySqlConnection();
        con.ConnectionString = conString;
    }
    public List<Product> getAllProducts(){
        List<Product> p_arr = new List<Product>();
        string query = "select * from Product";
        MySqlCommand cmd = new MySqlCommand(query, con);
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            BOL.Product p;
            while(reader.Read()){
                p_arr.Add(new BOL.Product(int.Parse(reader["PRODID"].ToString()), reader["DESCRIP"].ToString()));
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            if(con == null)
            Console.WriteLine("Connection is already Closed !");
        else
            con.Close();
        }
        return p_arr;
    }
    public BOL.Product getProductById(int id){
        BOL.Product p = new BOL.Product();
        string query = "select * from Product where PRODID = @id";
        try{
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id",id);
            MySqlDataReader reader = cmd.ExecuteReader();
            p.P_ID = int.Parse(reader["PRODID"].ToString());
            p.P_Desc = reader["DESCRIP"].ToString();
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            if(con == null)
            Console.WriteLine("Connection is already Closed !");
        else
            con.Close();
        }
        return p; 
    }
    // public Boolean insertProduct(){

    // }
    // public Boolean updateProductById(int id){
        
    // }
    // public Boolean deleteProductById(int id){
        
    // }

}
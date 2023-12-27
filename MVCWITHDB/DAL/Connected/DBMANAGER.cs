using MySql.Data.MySqlClient;
//namespace dal.db;
using BOL.student;


public class DBManager
{
    static String conectsString="server=192.168.10.150;port=3306;user=dac39;password=welcome;database=dac39";

    public static List<Student> getAllStudent()
    {
            List<Student> slist=new List<Student>();
                //step1:-make connection
            MySqlConnection con=new MySqlConnection();

            //step2:-connecting string
            
            con.ConnectionString=conectsString;

            //step3:-writes queries
            String query="select * from student";


            MySqlCommand command=new MySqlCommand(query,con);


            try{
                con.Open();
            //step6:-read data object 
                MySqlDataReader reader=command.ExecuteReader();

                while(reader.Read())
                {
                    int id=int.Parse(reader["ID"].ToString());
                    String first_name=reader["namefirst"].ToString();
                    String last_name=reader["namelast"].ToString();

                    Student s=new Student{ID=id,First_name=first_name,Last_name=last_name};

                    slist.Add(s);
                }
            // reader.Close();
            }catch(Exception e){
                    Console.WriteLine(e.Message);
            }finally{
                //connection close
                con.Close();
            }
            return slist;
    }
}
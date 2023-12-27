using MySql.Data.MySqlClient;
namespace dal.db;
using BOL.student;
using System.Data;


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
            MySqlCommand cmd=new MySqlCommand();
            // MySqlCommand cmd=new MySqlCommand(query,con); also valid...!!!
            try{
                // Empty data set
                    DataSet ds=new DataSet();
                    cmd.Connection=con;

                //step3:-writes queries
                    String query="select * from student";
                    cmd.CommandText=query;

                //Disconnected Data Access Logic:-
                
                // MySqlDataAdapter serves as a bridge between
                // a DataSet and MySQL for retrieving and saving data.
                MySqlDataAdapter da=new MySqlDataAdapter();
                da.SelectCommand=cmd; //MySqlCommand that is a SQL SELECT statement or stored procedure and
                                      // is set as the SelectCommand property of the MySqlDataAdapter.
            
                da.Fill(ds);
                //Fill():-  1) this method would fetch data from backend mysql
                        //  2) work as a Read() method...
                        //  3) fill results into dataset collection
                        //  4) deal with data which has been fetched from back end
                    
                DataTable dt=ds.Tables[0]; // contains multiple tables indexwise...
                DataRowCollection rows=dt.Rows; //works as a pointer who travels on perticular row..

                foreach(DataRow row in rows)
                {
                    int id=int.Parse(row["ID"].ToString());
                    string namefirst= row["namefirst"].ToString();
                    string namelast=row["namelast"].ToString();
                    Student s= new Student{
                        ID=id,
                        First_name=namefirst,
                        Last_name=namelast
                    };
                    slist.Add(s);
                }
            }catch(Exception e){
                    Console.WriteLine(e.Message);
            }finally{
                //connection close
                con.Close();
            }
            return slist;
    }
}
using MySql.Data.MySqlClient;


    //step1:-make connection
    MySqlConnection con=new MySqlConnection();

    //step2:-connecting string
    con.ConnectionString="server=192.168.10.150;port=3306;user=dac39;password=welcome;database=dac39";


    //step3:-writes queries
    String query="select * from student";

    //insert query
    /*Console.WriteLine("Enter id,firstname,lastname");
    int id=int.Parse(Console.ReadLine());
    String namefirst=Console.ReadLine();
    String namelast=Console.ReadLine();
    String insertQuery="insert into student (ID,namefirst,namelast) values(@id,@namefirst,@namelast)";*/
    /*Console.WriteLine("Enter the id to remove");
    int id=int.Parse(Console.ReadLine());
    String deleteQuery="delete from student where id=@id";*/

    Console.WriteLine("Enter the id and updated names");
    int id=int.Parse(Console.ReadLine());
    String updatedName=Console.ReadLine();

    String updateQuery="update student set namefirst=@updatedName where ID=@id";
    MySqlCommand command=new MySqlCommand(updateQuery,con);

    //step4:-Declare command
    //1MySqlCommand command=new MySqlCommand(query,con);

    /*2MySqlCommand command=new MySqlCommand(insertQuery,con);
    command.Parameters.AddWithValue("@id",id);
    command.Parameters.AddWithValue("@namefirst",namefirst);
    command.Parameters.AddWithValue("@namelast",namelast);*/


    /*MySqlCommand command=new MySqlCommand(deleteQuery,con);
    command.Parameters.AddWithValue("@id",id);*/
    command.Parameters.AddWithValue("@id",id);
    command.Parameters.AddWithValue("@updatedName",updatedName);
    
    //step5:-open connection
    try{
        con.Open();
        //step6:-read data object 
        //3MySqlDataReader reader=command.ExecuteReader();

         command.ExecuteNonQuery();

        //read the data
       /*4while(reader.Read())
        {
            int id=int.Parse(reader["ID"].ToString());
            String first_name=reader["namefirst"].ToString();
            String last_name=reader["namelast"].ToString();

            Console.WriteLine(id+" "+first_name+" "+last_name);
        }*/

        //close reader
       // reader.Close();
    }catch(Exception e){
            Console.WriteLine(e.Message);
    }finally{
        //connection close
        con.Close();
    }


















































/*//dotnet add package Mysql.Data --- Command
//use Mysql library 
using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to the Database Connectivity.......");

//Making Connection object
MySqlConnection connection = new MySqlConnection();
//connection string
connection.ConnectionString ="server=192.168.10.150;port=3306;user=dac39;password=welcome;database=dac39";

//query :

//select query
string query=" select * from student";

//DML queries :-
 //query="update student set namefirst='Ayush' where id=1";
 Console.WriteLine("enter the id to be deleted : ");
 int id=int.Parse(Console.ReadLine());
 query="delete from student_copy where ID=@id";

 //Aggregate function query : 
 query="select count(namefirst) from student";

//parameterized Query

MySqlCommand command= new MySqlCommand(query,connection);

 command.Parameters.AddWithValue("@id",id);


//&Using exceptional handling(try-catch block) open and close the connection..
try{
    connection.Open();

    //to read data from mysql table..
   /* MySqlDataReader reader=command.ExecuteReader();
    while(reader.Read())
    {
        //to convert object to string...
        int id=int.Parse(reader["ID"].ToString());
        string First_name=reader ["namefirst"].ToString();
        string Last_name=reader["namelast"].ToString();

    //to display data on console...
        Console.WriteLine("ID : "+id+"  first name : "+First_name+"  last name : "+Last_name);

    }
    reader.Close();*/

    //command.ExecuteNonQuery();
   /*int Count= int.Parse(command.ExecuteScalar().ToString());
   Console.WriteLine(Count);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}

*/
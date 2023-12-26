//dotnet add package Mysql.Data --- Command
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
   int Count= int.Parse(command.ExecuteScalar().ToString());
   Console.WriteLine(Count);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}


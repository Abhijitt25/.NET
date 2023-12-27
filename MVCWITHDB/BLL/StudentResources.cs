using dal.db;
using BOL.student;
namespace BAL.resource;

public class StudentResource{

    public static List<Student> getAllStudent()
    {
        List<Student> slist=new List<Student>();

        slist=DBManager.getAllStudent();

        return slist;
    } 
}
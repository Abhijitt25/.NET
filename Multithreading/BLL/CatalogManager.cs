namespace BLL;
using DAL;
using BOL;

public class CatalogManager
{
    public List<Student> getStudentsData(){
        return DBManager.getAllStudents();
    }
}

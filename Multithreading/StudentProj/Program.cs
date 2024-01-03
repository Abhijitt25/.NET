using BOL;
using BLL;
using Util;

CatalogManager smgr = new CatalogManager();
List<Student> s_arr = new List<Student>();
s_arr = smgr.getStudentsData();

Print.putData(s_arr);
Print.PrintData();





namespace  Util;
using BOL;
using System.Threading;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public static class Print
{
    public static async Task PrintData(){
        await Task.Run(()=>{
            Console.WriteLine("Fatching Data from table... ");
            string getData = File.ReadAllText(@".\Student_Data.json");
            Console.WriteLine(getData);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        });
    }


    public static async Task putData(List<Student> s_arr){
        await Task.Run(()=>{
            Console.WriteLine("Storing Data into table.... ");
            string json = JsonSerializer.Serialize(s_arr); 
            File.WriteAllText(@".\Student_Data.json", json);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        });
    }
}
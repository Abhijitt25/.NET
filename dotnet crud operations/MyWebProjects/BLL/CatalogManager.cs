namespace BLL;
using DAL.Connected;
using BOL;
public class Catalog {
    static DAL.Connected.DBConnect db = new DAL.Connected.DBConnect();
    public List<Product> getall(){
        List<Product> all_Prod = new List<Product>();
        all_Prod = db.getAllProducts();
        return all_Prod;
    }
    public Product getById(int id){
        return db.getProductById(id);
    }
    // public Boolean insert(){
    //     return DAL.Connected.DBConnect.insertProduct();
    // }
    // public Boolean update(int id){
    //     return DAL.Connected.DBConnect.updateProductById(id);
    // }
    // public Boolean delete(int id){
    //     return DAL.Connected.DBConnect.deleteProductById(id);
    // }
}
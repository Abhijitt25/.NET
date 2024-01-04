namespace BOL;
public class Product {
    private int pId;
    private string desc;
    public Product(){
        this.pId = 0;
        this.desc = null;
    }
    public Product(int id, string desc){
        this.pId = id;
        this.desc = desc;
    }
    public int P_ID {
        get{return this.pId;}
        set{this.pId = value;}
    }
    public string P_Desc {
        get{return this.desc;}
        set{this.desc = value;}
    }
    public override string ToString(){
        return "P_ID : "+this.pId+", P_DESC : "+this.desc;
    }
}
namespace PLAYER;

public class Player{
    public int pID{get;set;}
    public string pName{get;set;}
    public string pImage{get;set;}
    public int plevel{get;set;}
    public Player()
    {
        this.pID = 0;
        this.pName = null;
        this.pImage = null;
        this.plevel = 0;
    }
    // public int Player_ID{
    //     get{return this.pID;}
    //     set{this.pID = value;}
    // }
    // public string Player_Name{
    //     get{return this.pName;}
    //     set{this.pName = value;}
    // }
    // public string ProfileImage{
    //     get{return this.pImage;}
    //     set{this.pImage = value;}
    // }
    // public int Player_Level{
    //     get{return this.plevel;}
    //     set{this.plevel = value;}
    // }
}
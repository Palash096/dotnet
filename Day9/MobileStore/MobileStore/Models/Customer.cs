namespace MobileStore.Models;

public class Customer{
    private string firstname;
    private string lastname;
    private int mobileNo;
    private string location;

    // public Customer(){

    // }

    public Customer(string fn, string ln, int mobNo, string loc){
        this.FirstName = fn;
        this.LastName = ln;
        this.MobileNo = mobNo;
        this.Location = loc;
    }

    public string FirstName{
        get{return firstname;}
        set{firstname = value;}
    }

    public string LastName{
        get{return lastname;}
        set{lastname = value;}
    }

    public int MobileNo{
        get{return mobileNo;}
        set{mobileNo = value;}
    }

    public string Location{
        get{return location;}
        set{location = value;}
    }
    
}
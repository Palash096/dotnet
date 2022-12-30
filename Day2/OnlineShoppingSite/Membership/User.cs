namespace Membership;

public class User{
    private string firstName;

    // Normal Property
    public string FirstName{
        get{return firstName;}
        set{firstName=value;}
    }

    // Auto Property
    public string LastName{get; set;}

    public string ContactNumber{get; set;}

    public string Location{get; set;}

    public string Email{get; set;}

    
}
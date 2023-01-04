namespace HR;

public sealed class Person{
    public int Id;
    public string FirstName{get; set;}
    public string LastName{get; set;}

    // Singleton Pattern ==> Step-1
    public static Person _ref = null;

    // Singleton Pattern ==> Step-2
    Person(){
        this.FirstName="Palash";
        this.LastName="Kardhekar";
        this.Id=9;
    }

    // Singleton Pattern ==> Step-3
    public static Person CreateInstance(){
        if(_ref == null){
            _ref = new Person();
            return _ref;
        }
        return null;
    }



}
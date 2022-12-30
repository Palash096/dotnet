namespace HR;

public abstract class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public string Location { get; set; }
    public DateTime BirthDate { get; set; }

    public float DA { get; set; }
    public float HRA { get; set; }
    public float BasicSalary { get; set; }

    // parameterless constructor ==> ctor chaining
    public Employee() : this(11, "Palash", "Kardhekar", "palashkardhekar5@gmail.com", "8956452135", "Chandrapur", new DateTime(2022, 12, 30), 1000, 20000, 25000)
    {

    }

    // parameterized constructor
    public Employee(int id, string firstName, string lastName, string email, string contactNumber, string location, DateTime bDate, float da, float hra, float bsal)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.ContactNumber = contactNumber;
        this.Location = location;
        this.BirthDate = bDate;
        this.DA = da;
        this.HRA = hra;
        this.BasicSalary = bsal;
    }

    // abstract method ==> conpulsary override
    public abstract void DoWork();

    // virtual method ==> may or may not override
    public virtual float ComputePay()
    {
        float pay = (DA * 25) + BasicSalary + HRA;
        return pay;
    }

    // override ToString()
    public override string ToString()
    {
        string str = string.Format("{0}, {1}, {2}, {3}, {4}, {5}", Id, FirstName, LastName, Email, ContactNumber, Location);
        return str;
    }


}
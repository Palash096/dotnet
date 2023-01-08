namespace TFLCollection;

// POCO Object
public class Employee{
    public int Id;
    public string Name;
    public float Salary;

    public Employee(int id, string nm, float sal){
        this.Id = id;
        this.Name = nm;
        this.Salary = sal;
    }
}
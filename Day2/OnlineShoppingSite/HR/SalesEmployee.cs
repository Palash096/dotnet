namespace HR;

public class SalesEmployee : Employee{

    public float Target{get; set;}
    public float Sales{get; set;}
    public float Incentive{get; set;}

    public SalesEmployee():base(){
        this.Target=0;
        this.Sales=0;
        this.Incentive=0;
    }

    // member initialization list ==> :base(id, firstName, lastName, email, contactNumber, location, bDate, da, hra, bsal) 
    // use member initialization list so that we dont have to declare it again and again
    // base will call to parent constructor direclty
    public SalesEmployee(int id, string firstName, string lastName, string email, string contactNumber, string location, DateTime bDate, float da, float hra, float bsal, float target, float sales):base(id, firstName, lastName, email, contactNumber, location, bDate, da, hra, bsal){
        this.Target=target;
        this.Sales=sales;
        this.Incentive=0;
    }

    // abstract method ==> conpulsary override
    public override void DoWork()
    {
        if(Sales >= Target){
            this.Incentive = 5000;
        }
        else
        {
            this.Incentive=0;
        }
    }

    // virtual method ==> may or may not override
    public override float ComputePay()
    {
        float salary = base.ComputePay()+Incentive;
        return salary;
    }

    public override string ToString()
    {
        return base.ToString()+", Incentive : "+Incentive+", Sales : "+Sales+", Target : "+Target;
    }

}

// base.ToString() will call to parent class ToString().
namespace HR;

public class SalesManager : SalesEmployee{
    public float Bonus{get; set;}

    public SalesManager():base(){
        this.Bonus=0;
    }

    public SalesManager(int id, string firstName, string lastName, string email, string contactNumber, string location, DateTime bDate, float da, float hra, float bsal, float target, float sales, float bonus):base(id, firstName, lastName, email, contactNumber, location, bDate, da, hra, bsal, target, sales){
        this.Bonus=bonus;
    }

    // abstract method ==> conpulsary override
    public override void DoWork()
    {
        base.DoWork();
    }

    // virtual method ==> optional to override
    public override float ComputePay()
    {
        return base.ComputePay()+Bonus;
    }

    public override string ToString()
    {
        return base.ToString()+", Bonus : "+Bonus;
    }

}
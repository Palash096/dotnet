namespace TaxRate;

// declare delegate
public delegate void TaxOperation(float amount);

public class TaxInfo{

    public void DeductIncomeTax(float amount){
        Console.WriteLine("35% money has been deduce from your balance.");
    }

    public void DeductServiceTax(float amount){
        Console.WriteLine("15% money has been deduce from your balance.");
    }

    public void DeductProfessionalTax(float amount){
        Console.WriteLine("10% money has been deduce from your balance.");
    }

}
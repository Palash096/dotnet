namespace TaxRate;

// declare delegate
public delegate void TaxOperation();

public class TaxInfo{

    public void DeductIncomeTax(){
        Console.WriteLine("35% money has been deduce from your balance.");
    }

    public void DeductServiceTax(){
        Console.WriteLine("15% money has been deduce from your balance.");
    }

    public void DeductProfessionalTax(){
        Console.WriteLine("10% money has been deduce from your balance.");
    }

}
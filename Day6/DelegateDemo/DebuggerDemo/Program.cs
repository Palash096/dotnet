using TaxRate;

TaxInfo tax = new TaxInfo();


tax.DeductIncomeTax();
tax.DeductServiceTax();
tax.DeductProfessionalTax();

//register address of DeductIncomeTax  inside 
//instance of TaxOperation Delegate object

TaxOperation IncomeTax = new TaxOperation(tax.DeductIncomeTax);
TaxOperation ServiceTax = new TaxOperation(tax.DeductServiceTax);
TaxOperation ProfTax = new TaxOperation(tax.DeductProfessionalTax);

IncomeTax();
ServiceTax();
ProfTax();

// unicast delegate
Console.WriteLine("Unicast delegate");
TaxOperation? UniDelegate = IncomeTax;
UniDelegate();
TaxOperation IncomeTax1 = UniDelegate;
IncomeTax1();

// Chaining delegate by reference
Console.WriteLine("Chaining delegate");
UniDelegate += ServiceTax;
UniDelegate();
UniDelegate += ProfTax;
UniDelegate();

//Dereference delegate
Console.WriteLine("Dereference delegate");
UniDelegate -= IncomeTax;
UniDelegate();




using TaxRate;
using Banking;

TaxInfo tax = new TaxInfo();

Console.WriteLine("Bank Application");

//register address of DeductIncomeTax  inside 
//instance of TaxOperation Delegate object
TaxOperation tax1 = new TaxOperation(tax.DeductIncomeTax);
TaxOperation tax2 = new TaxOperation(tax.DeductServiceTax);
TaxOperation tax3 = new TaxOperation(tax.DeductProfessionalTax);


Account FirstAccount = new Account(6000);
// event registration
FirstAccount.overBalance += tax1;
FirstAccount.overBalance += tax2;

// FirstAccount.underBalance += tax1;
// FirstAccount.underBalance += tax2;

Console.WriteLine("Enter amount to be deposited : ");
float amount =float.Parse(Console.ReadLine());
FirstAccount.DepositeAmt(amount);
Console.WriteLine(FirstAccount);

Console.WriteLine("Enter Amount to withdraw : ");
amount = float.Parse(Console.ReadLine());
FirstAccount.WithdrawAmt(amount);
Console.WriteLine(FirstAccount);

// after processing
FirstAccount.ProcessTax();
Console.WriteLine("After Processing tax");
tax.DeductIncomeTax(amount);
Console.WriteLine(FirstAccount);




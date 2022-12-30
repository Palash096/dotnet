using Membership;
using HR;

Console.WriteLine("Welcome to Online Shopping Platform");
Console.WriteLine("---------------------------------------------------------------------------------");

// read email
Console.WriteLine("Enter your Email Id : ");
string email = Console.ReadLine();

// read password
Console.WriteLine("Enter your Password : ");
string password = Console.ReadLine();

// calling Validation ==> validation email and password
if (AuthManager.Validate(email, password))
{
    Console.WriteLine("Login Successfull...!!!");
    Employee emp = new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary = emp.ComputePay();
    Console.WriteLine("Salary : "+salary);
}
else
{
    Console.WriteLine("Invalid User...!!!");
}

Console.WriteLine("Thank you for visiting...!!!");


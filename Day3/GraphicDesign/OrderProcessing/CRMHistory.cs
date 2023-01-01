namespace OrderProcessing;
public class CRMHistory : ICustomerDetails, IOrderDetails
{
    public CRMHistory(){
        
    }

    public void ShowCustomerDetails(){
        Console.WriteLine("Inside method of ICustomerDetails interface");
    }

    public void ShowOrderDetails(){
        Console.WriteLine("Inside method of IOrderDetails interface");
    }

    public void ChangeProfile(){
        Console.WriteLine("Please Change Your profile");
    }

    // Explicit Interface Inheritance ==> same function name in two different interfaces
    // Sol. ==> use InterfaceName.FunctionName
    void ICustomerDetails.ShowDetails(){
        Console.WriteLine("Customer Information");
    }

    void IOrderDetails.ShowDetails(){
        Console.WriteLine("Placed Order Information");
    }
    
}

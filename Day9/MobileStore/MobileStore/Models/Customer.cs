namespace MobileStore.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int MobileNo { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Customer()
    {

    }

    public Customer(string fn, string ln, int mobNo, string email, string pass)
    {
        this.FirstName = fn;
        this.LastName = ln;
        this.MobileNo = mobNo;
        this.Email = email;
        this.Password = pass;
    }

    public static void Serial(List<Customer> cust)
    {
        cust.ForEach(c => Console.WriteLine(c));
        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };
            var custJson = JsonSerializer.Serialize<List<Customer>>(cust, options);
            string fileName = @"C:\.NET\dotnet\Day9\Customer.json";
            File.WriteAllText(fileName, custJson);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error => " + e);
        }
    }

    public static List<Customer> Dser()
    {
        List<Customer> li = new List<Customer>();
        string fileName = @"C:\.NET\dotnet\Day9\Customer.json";
        string jsonString = File.ReadAllText(fileName);
        if (jsonString == "")
            return null;

        li = JsonSerializer.Deserialize<List<Customer>>(jsonString);
        return li;
    }

}
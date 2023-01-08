namespace MobileStore.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class CustomerManagement{

    public static List<Customer> GetAllCustomer(){
        List<Customer> allCustomer = new List<Customer>();

        allCustomer.Add(new Customer("Palash", "Kardhekar", 465544, "Chandrapur"));
        allCustomer.Add(new Customer("Anvesh", "Modak", 434544, "Chandrapur"));
        allCustomer.Add(new Customer("Mayur", "Pakhale", 345544, "Gondia"));
        allCustomer.Add(new Customer("Bhavesh", "Verma", 988543, "Raipur"));
        allCustomer.Add(new Customer("VIjay", "Chauhrary", 735324, "Bihar"));

        return allCustomer;
    }
    

}
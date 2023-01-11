namespace ProductCatalog;
using System.ComponentModel.DataAnnotations;

// [POCO] => Plain Old CLR Object
[Serializable] // attribute : Metadata
public class Product
{
    public int ProductId{get; set;}
    public string ProductName{get; set;}
    public double ProductPrice{get; set;}
    
    public Product(){
        this.ProductId = 0;
        this.ProductName = "default";
        this.ProductPrice = 0.0;
    }

    public Product(int pid, string pname, double pprice){
        this.ProductId = pid;
        this.ProductName = pname;
        this.ProductPrice = pprice;
    }

}

namespace Banking;
using TaxRate;

public class Account{

    // calling event on delegate
    // event is always based on delegate
    public event TaxOperation overBalance;
    public float balance{get; set;}
    public Account(float balance){
        this.balance = balance;
    }

    public void DepositeAmt(float amount){
        this.balance = this.balance + amount;
    }

    public void WithdrawAmt(float amount){
        this.balance = this.balance - amount;
    }

    public override string ToString()
    {
        return "Balance : "+this.balance;
    }

    public void ProcessTax(){
        if(this.balance >= 10000){
            // raise an event
            this.balance = (float)0.65 * this.balance;
            overBalance(this.balance);
        }
    }

}
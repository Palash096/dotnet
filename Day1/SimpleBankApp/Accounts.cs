namespace BankAccount;

public class Account{
    // data members
    private int AccNo;
    private float Balance;

    // parameterless constructor
    public Account(){
        this.AccNo=1;
        this.Balance=1000;
    }

    //parameterized constructor
    public Account(int accno, float amount){
        this.AccNo = accno;
        this.Balance = amount;
    }

    // getter setter
    public void SetAccNo(int accno){
        this.AccNo = accno;
    }

    public int GetAccNo(){
        return this.AccNo;
    }

    public void SetAccNo(float balance){
        this.Balance = balance;
    }

    public float GetBalance(){
        return this.Balance;
    }

    public void Withdraw(float amount){
        if(amount == 0){
            throw new Exception("You cannot enter zero value");
        }
        else{
            this.Balance = this.Balance = amount;
        }
    }

    public void Deposit(float amount){
        this.Balance = this.Balance + amount;
    }

    public override string ToString()
    {
        return "AccNo"+this.AccNo+", Balance : "+this.Balance;
    }


}
namespace Banking;

public class Account{

    //data members
    private float balance = 5000;

    //setter method
    public void SetBalance(float amount){
        this.balance = amount;
    }

    //getter method
    public float GetBalance(){
        return this.balance;
    }

    //Constructor Overloading
    public Account(){
        this.balance = 10000;
    }

    public Account(float amount){
        this.balance = amount;
    }

    public void Withdraw(float amount){
        if(amount == 0){
            throw new Exception("Amount can not be zero");
        }
        this.balance -= amount;
    }

    public void Deposit(float amount){
        this.balance += amount;
    }
    ~Account()
    {

            //Deinitialization
    }
}

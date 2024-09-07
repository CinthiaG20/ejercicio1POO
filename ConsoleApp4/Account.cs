using ConsoleApp3;

namespace ConsoleApp5;

public class Account
{
    private int number;

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    private double balance;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value > 0)
            {
                balance = value;
            }
        }
    }

    private Person titular;

    public Person Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public Account(int numero,double Balance,Person Titular)
    {
        number = numero;
        balance = Balance;
        titular = Titular;
    }
    public double AddToBalance(double amount)
    {
       return this.balance += amount;
    }

    public double RemoveFromBalance(double amount)
    {
        if (amount < this.balance)
        {
            return this.balance - amount;
        }
        return 0;

    }

    public void TransferTo(Account account, double amount)
    {
        if (this.balance>amount){
        account.balance += amount;}
    }
}
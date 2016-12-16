using System;

public class BankAccount
{
    private bool isOpen;
    private int balance;
    private readonly object locker = new object();

    public void Open()
    {
        isOpen = true;
    }

    public void UpdateBalance(int amount)
    {
        lock(locker)
        {
            balance += amount;
        }
    }

    public int GetBalance()
    {
        if (!isOpen)
        {
            throw new InvalidOperationException();
        }
        return balance;
    }

    public void Close()
    {
        isOpen = false;
    }
}
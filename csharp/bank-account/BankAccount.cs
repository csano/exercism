using System;

public class BankAccount
{
    private bool isOpen;
    private int balance;
    private readonly object locker = new object();

    public void Open()
    {
        lock(locker)
        {
            isOpen = true;
        }
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
        lock (locker)
        {
            if (!isOpen)
            {
                throw new InvalidOperationException();
            }
            return balance;
        }
    }

    public void Close()
    {
        lock(locker)
        {
            isOpen = false;
        }
    }
}
using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<IPayment> payments = new List<IPayment>
        {
            new CreditCardPayment("TNX3456789"),
            new PayPalPayment("TNX45678989"),
            new BankTransferPayment(),
        };
        foreach (var payment in payments)
        {
            payment.ValidatePayment();
            payment.ProcessPayment(7000);
        }

    }
}

public interface IPayment
{
    void ProcessPayment(decimal amount);
    void ValidatePayment();
}
public abstract class BasePayment : IPayment
{
    public string TransactionId { get;  private set;}

    //constructor
    public BasePayment(string transactionId)
    {
        this.TransactionId = string.IsNullOrEmpty(transactionId)?GenerateTranscationID(): transactionId;
    }


    //behaviours 
    protected string GenerateTranscationID()
    {
        return $"TNX{new Random().Next(1000000, 9999999)}";
    }
    public abstract void ProcessPayment(decimal amount);
    public abstract void ValidatePayment();
    public void LogPayment()
    {
        Console.WriteLine($"Payment logged with transaction id: {TransactionId}");
    }


}

public class CreditCardPayment : BasePayment
{
    public CreditCardPayment(string transactionId) : base(transactionId)
    {

    }
    public override void ValidatePayment()
    {
        Console.WriteLine("Credit Card has been validated");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processed  {amount}  using Credit Card");
        LogPayment();
    }
    
}
public class PayPalPayment : BasePayment
{
    public PayPalPayment(string transactionId) : base(transactionId)
    {

    }
    public override void ValidatePayment()
    {
        Console.WriteLine("PayPal Payment has been validated");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Amount {amount} is processing using Paypal");
        LogPayment();
    }
    
}
public class BankTransferPayment : BasePayment
{
    public BankTransferPayment() : base(null)
    {

    }

    public BankTransferPayment(string transactionId) : base(transactionId)
    {
    }
    public override void ValidatePayment()
    {
        Console.WriteLine("Bank Transfer Payment has been validated");
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Amount {amount} is processing using Bank Transfer ");
        LogPayment();
    }
    
}
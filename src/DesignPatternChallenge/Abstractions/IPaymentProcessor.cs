namespace DefaultNamespace;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amout, string cardNUmber);
}
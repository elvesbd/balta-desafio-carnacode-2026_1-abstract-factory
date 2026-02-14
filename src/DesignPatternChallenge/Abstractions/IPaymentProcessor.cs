namespace DesignPatternChallenge.Abstractions;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNUmber);
}
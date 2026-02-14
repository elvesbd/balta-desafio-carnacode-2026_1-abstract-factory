namespace DesignPatternChallenge.Abstractions;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
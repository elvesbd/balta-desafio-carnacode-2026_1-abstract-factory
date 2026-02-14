namespace DesignPatternChallenge.Abstractions;

public interface IPaymentValidator
{
    bool ValidateCardd(string cardNumber);
}
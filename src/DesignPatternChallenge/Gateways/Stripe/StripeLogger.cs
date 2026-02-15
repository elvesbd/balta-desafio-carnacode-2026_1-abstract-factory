using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.Stripe;

public class StripeLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}
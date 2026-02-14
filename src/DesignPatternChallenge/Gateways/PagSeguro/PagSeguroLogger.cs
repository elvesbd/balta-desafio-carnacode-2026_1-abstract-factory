using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.PagSeguro;

public class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}
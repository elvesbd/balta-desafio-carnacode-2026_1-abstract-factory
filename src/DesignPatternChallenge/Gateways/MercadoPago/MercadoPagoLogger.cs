using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.MercadoPago;

public class MercadoPagoLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.PagSeguro;

public class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString()[..8]}";
    }
}
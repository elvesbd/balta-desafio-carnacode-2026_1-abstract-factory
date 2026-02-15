using DesignPatternChallenge.Gateways.Stripe;
using DesignPatternChallenge.Gateways.PagSeguro;
using DesignPatternChallenge.Gateways.MercadoPago;

namespace DesignPatternChallenge.Factories;

public class PaymentGatewayProvider
{
    private static readonly Dictionary<string, Func<IPaymentGatewayFactory>> Factories =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["stripe"] = () => new StripeGatewayFactory(),
            ["pagseguro"] = () => new PagSeguroGatewayFactory(),
            ["mercadopago"] = () => new MercadoPagoGatewayFactory(),
        };

    public static IPaymentGatewayFactory GetFactory(string gateway)
    {
        if (Factories.TryGetValue(gateway, out var factory))
            return factory();
        
        var available = string.Join(", ", Factories.Keys);
        throw new ArgumentException($"Gateway '{gateway}' não suportado. Disponíveis: {available}");
    }
}
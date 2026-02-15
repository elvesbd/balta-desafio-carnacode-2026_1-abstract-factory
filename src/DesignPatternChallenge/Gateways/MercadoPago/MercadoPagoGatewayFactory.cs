using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Factories;

namespace DesignPatternChallenge.Gateways.MercadoPago;

public class MercadoPagoGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
}
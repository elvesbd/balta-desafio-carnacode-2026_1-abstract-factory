using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.MercadoPago;

public class MercadoPagoGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
}
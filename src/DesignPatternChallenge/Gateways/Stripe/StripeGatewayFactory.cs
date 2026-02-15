using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.Stripe;

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger() => new StripeLogger();
    public IPaymentValidator CreateValidator() => new StripeValidator();
    public IPaymentProcessor CreateProcessor() => new StripeProcessor();
}
using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Gateways.PagSeguro;

public class PagSeguroGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();
    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();
}
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Factories;

public interface IPaymentGatewayFactory
{
    IPaymentLogger CreateLogger();
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
}
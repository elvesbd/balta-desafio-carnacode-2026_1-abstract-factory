using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Services;

public class PaymentService(IPaymentGatewayFactory gatewayFactory)
{
    private readonly IPaymentLogger _logger = gatewayFactory.CreateLogger();
    private readonly IPaymentValidator _validator = gatewayFactory.CreateValidator();
    private readonly IPaymentProcessor _processor = gatewayFactory.CreateProcessor();

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            _logger.Log("Falha na validação do cartão.");
            return;
        }
        
        var transactionId = _processor.ProcessTransaction(amount, cardNumber);
        _logger.Log($"Transação processada com sucesso: {transactionId}");
    }
}
using DesignPatternChallenge.Services;
using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Gateways.MercadoPago;

Console.WriteLine("=== Sistema de Pagamentos (Abstract Factory) ===\n");

// Via Provider (resolve por string)
var pagSeguroFactory = PaymentGatewayProvider.GetFactory("pagseguro");
var pagSeguroService = new PaymentService(pagSeguroFactory);
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoFactory = PaymentGatewayProvider.GetFactory("mercadopago");
var mercadoPagoService = new PaymentService(mercadoPagoFactory);
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

var stripeFactory = PaymentGatewayProvider.GetFactory("stripe");
var stripeService = new PaymentService(stripeFactory);
stripeService.ProcessPayment(99.99m, "4234567890123456");

// Injeção direta da factory
Console.WriteLine("\n--- Injeção direta da factory ---\n");

var service = new PaymentService(new MercadoPagoGatewayFactory());
service.ProcessPayment(500.00m, "5999888877776666");

// Teste: cartão inválido
Console.WriteLine("\n--- Teste: cartão inválido ---\n");

var stripeService2 = new PaymentService(PaymentGatewayProvider.GetFactory("stripe"));
stripeService2.ProcessPayment(75.00m, "9999999999999999");
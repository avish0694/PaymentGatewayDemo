using System;

namespace PaymentGateway
{
    // Context class that uses the strategy pattern
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void MakePayment(decimal amount)
        {
            bool isSuccess = _paymentStrategy.ProcessPayment(amount);
            Console.WriteLine(isSuccess ? "Payment Successful!" : "Payment Failed!");
        }
    }
}
using System;

namespace PaymentGateway
{
    // Concrete implementation for Credit Card payments
    public class CreditCardPayment : IPaymentStrategy
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment of ${amount}");
            // Simulating payment processing
            return true; // Assume payment is successful
        }
    }
}
using System;

namespace PaymentGateway
{
    // Concrete implementation for PayPal payments
    public class PayPalPayment : IPaymentStrategy
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal Payment of ${amount}");
            // Simulating payment processing
            return true; // Assume payment is successful
        }
    }
}
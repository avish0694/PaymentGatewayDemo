using System;

namespace PaymentGateway
{
    // Strategy Interface - Defines a contract for payment processing
    public interface IPaymentStrategy
    {
        bool ProcessPayment(decimal amount);
    }
}
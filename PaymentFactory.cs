using System;

namespace PaymentGateway
{
    // Factory class to return the appropriate payment processor
    public class PaymentFactory
    {
        public static IPaymentStrategy GetPaymentMethod(string paymentType)
        {
            return paymentType.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPalPayment(),
                _ => throw new ArgumentException("Invalid payment method")
            };
        }
    }
}
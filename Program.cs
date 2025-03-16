// See https://aka.ms/new-console-template for more information

namespace PaymentGateway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Payment Method (CreditCard/PayPal): ");
            string method = Console.ReadLine();

            try
            {
                // Get the payment strategy from the factory
                IPaymentStrategy paymentMethod = PaymentFactory.GetPaymentMethod(method);

                // Inject strategy into the payment processor
                PaymentProcessor processor = new PaymentProcessor(paymentMethod);

                // Simulate payment transaction
                Console.Write("Enter Amount: $");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                processor.MakePayment(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

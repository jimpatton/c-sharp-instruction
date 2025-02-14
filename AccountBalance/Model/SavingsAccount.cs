using System.Security.Cryptography.X509Certificates;

namespace AccountBalance.Model
{
    internal class SavingsAccount : Account
    {
        public decimal MontlyInterestRate {  get; set; }

        public decimal MonthlyInterestPayment {  get; set; }

        public SavingsAccount(decimal monthlyInterestRate)
        {
            this.MontlyInterestRate = monthlyInterestRate;
        }

        public void ApplyInterestPaymentToBalance()
        {
            MonthlyInterestPayment = Balance * MontlyInterestRate;
            Balance += MonthlyInterestPayment;
        }
        
        
    }
}

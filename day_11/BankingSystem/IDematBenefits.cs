namespace BankManagementSystem
{
    public interface IDematBenefits : IBenefits
    {
        float CreditScore { get; set; }
        void AvailFreeCreditScoreCheck();
        void GetDailyStockUpdates();
    }
}
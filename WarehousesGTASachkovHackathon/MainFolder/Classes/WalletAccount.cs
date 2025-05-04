namespace WarehousesGTASachkovHackathon.MainFolder.Classes
{
    public class WalletAccount
    {
        private int money = 0;

        public int GetMoney()
        {
            return money;
        }

        public void AddMoney(int amount)
        {
            money += amount;
        }

        public void SubtractMoney(int amount)
        {
            if (money - amount < 0)
                throw new InvalidOperationException("Not enough money in wallet.");
            money -= amount;
        }

        public WalletAccount(int money)
        {
            this.money = money;
        }
        public WalletAccount()
        {
            this.money = 0;
        }
    }
}
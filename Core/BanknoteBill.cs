using Bank.Core.Banknotes;

namespace Bank.Core
{
    public class BanknoteBill : Dictionary<int, List<Banknote>>
    {
        public BanknoteBill(Dictionary<int, List<Banknote>> data) : base(data)
        {}
        public BanknoteBill() : base() {}

        public int TotalSum()
        {
            int sum = 0;
            foreach (var item in Values)
            {
                sum += item.Count * (item[0]).Value;
            }

            return sum;
        }
    }
}

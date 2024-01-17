using Bank.Core.Banknotes;
using System.Text.Json;

namespace Bank.Core.CashBoxes
{
    public class CashBox
    {
        public BanknoteBill CashIn { get; set; }
        public event EventHandler CashLoaded;

        public string ID { get; set; }

        public void Init(CashBox box)
        {
            this.CashIn = box.CashIn;
            CashLoaded?.Invoke(this, new EventArgs());

            File.WriteAllText(this.ID, JsonSerializer.Serialize(CashIn));
        }

        public CashBox() { ID = Guid.NewGuid().ToString(); }


        public BanknoteBill TakeSum(int sumNeed)
        {
            //алгоритм сами придумаете
            return CashIn;
        }

    }
}

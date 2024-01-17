using Bank.Core.CashBoxes;
using Bank.Core.Exceptions;

namespace Bank.Core
{
    public class ATC
    {
        public CashBox InnerCashBox { get; set; }
        public event EventHandler cashIssued;
        public void DonwloadCashBox(CashBox innerCashBox)
        {
            InnerCashBox = new CashBox();
            InnerCashBox.Init(innerCashBox);
        }

        public BanknoteBill TakeSum(int sumNeed)
        {
            if (InnerCashBox.CashIn.TotalSum() < sumNeed) throw new NoSuchSumException();

            BanknoteBill bill = InnerCashBox.TakeSum(sumNeed);
            cashIssued?.Invoke(this, new EventArgs());

            return bill;
        }
    }
}

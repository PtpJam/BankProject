using Bank.Core.Banknotes;
using System.Reflection;

namespace Bank.Core.CashBoxes
{
    public class CashLoader 
    {
        public CashBox Load()
        {
            BanknoteBill tmp = new BanknoteBill();

            tmp.Add(500,  new List<Banknote>());
            for (int i = 0; i < 10; i++)
            {
                tmp[500].Add(new  Banknote_500(Guid.NewGuid().ToString()));
            }

            tmp.Add(100, new List<Banknote>());
            for (int i = 0; i < 5; i++)
            {
                tmp[100].Add(new Banknote_100(Guid.NewGuid().ToString()));
            }

            return new CashBox() { CashIn = tmp};
        }
    }
}

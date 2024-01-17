// See https://aka.ms/new-console-template for more information
using Bank.Core;
using Bank.Core.CashBoxes;


CashBox cash =new CashBox();
cash.CashLoaded += (s, e) => Console.WriteLine("Cash in terminal");

cash.Init(new CashLoader().Load());


ATC atc = new ATC();
atc.DonwloadCashBox(cash);
atc.InnerCashBox.TakeSum(400);
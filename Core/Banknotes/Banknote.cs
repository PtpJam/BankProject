namespace Bank.Core.Banknotes
{
    public abstract class Banknote : IComparable
    {
        public string ID { get; private set; }
        public int Value { get; private set; }

        private Banknote() { }
        protected Banknote(string id, int value) { ID = id; Value = value; }

        public int CompareTo(object? obj)
        {
            if (obj is not Banknote) return -1;

            return Convert.ToInt32((obj as Banknote).ID.Equals(ID));
        }
    }
}

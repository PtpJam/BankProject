namespace Bank.Core.Exceptions
{
    internal class NoSuchSumException : Exception
    {
        public NoSuchSumException() : base("In ATC now not enough cash!")
        {}
    }
}

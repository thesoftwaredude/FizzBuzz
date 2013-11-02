namespace Library
{
    public abstract class Catagorizer
    {
        public Catagorizer RegisterNext(Catagorizer next)
        {
            Next = next;
            return Next;
        }

        protected Catagorizer Next { get; private set; }

        public abstract string IsSatisfiedBy(int number);
    }
}

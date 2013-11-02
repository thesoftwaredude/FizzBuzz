namespace Library
{
    public class BuzzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number%5 == 0)
                return "Buzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}
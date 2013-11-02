namespace Library
{
    public class FizzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number%3 == 0)
                return "Fizz";
            return Next.IsSatisfiedBy(number);
        }
    }
}
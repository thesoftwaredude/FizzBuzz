namespace Library
{
    public class FizzBuzzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number%15 == 0)
                return "FizzBuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}
using System.Globalization;

namespace Library
{
    public class PlainNumberCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
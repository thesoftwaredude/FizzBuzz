using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class SortNumbers
    {
        public IQueryable<int> Sort(IEnumerable<int> numbers)
        {
            return numbers.OrderBy(n => n).AsQueryable();
        }

        public int SecondSort(IEnumerable<int> numbers)
        {
            return numbers.OrderBy(n => n)
                .Skip(1)
                .Take(1)
                .FirstOrDefault();
        }
    }
}

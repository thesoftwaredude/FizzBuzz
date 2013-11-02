using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            return CatagorizerChain.Calculate(number);
        }
    }

    public class ProcessCalculate
    {
        public void Execute()
        {
            var fb = new FizzBuzz();
            for (int index = 1; index <= 100; index++)
            {
                Console.WriteLine(fb.Calculate(index));
            }
        }
    }
}

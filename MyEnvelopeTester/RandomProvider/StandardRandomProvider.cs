using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvelopeTester.RandomProvider
{
    public class StandardRandomProvider : IRandomProvider
    {
        private Random rnd;
        
        public StandardRandomProvider()
        {
            rnd = new Random();
        }

        public int Next(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvelopeTester.RandomProvider
{
    public interface IRandomProvider
    {
        int Next(int min, int max);
    }
}

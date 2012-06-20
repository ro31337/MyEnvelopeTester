using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnvelopeTester.Core;
using MyEnvelopeTester.RandomProvider;

namespace MyEnvelopeTester.Picker
{
    public interface IPicker
    {
        int Pick(IRandomProvider randomProvider, EnvelopePair envelopePair);
    }
}

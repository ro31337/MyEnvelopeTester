using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnvelopeTester.Core;
using MyEnvelopeTester.RandomProvider;

namespace MyEnvelopeTester.Picker
{
    public class AlwaysSecondPicker : IPicker
    {
        public int Pick(IRandomProvider randomProvider, EnvelopePair envelopePair)
        {
            return envelopePair.SecondEnvelope.Amount;
        }
    }
}

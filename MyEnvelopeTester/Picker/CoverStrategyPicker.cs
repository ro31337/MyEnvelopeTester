using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnvelopeTester.Core;
using MyEnvelopeTester.RandomProvider;

namespace MyEnvelopeTester.Picker
{
    public class CoverStrategyPicker : IPicker
    {
        public int Pick(IRandomProvider randomProvider, EnvelopePair envelopePair)
        {
            int randomValue = randomProvider.Next(1, 10);

            /*
             * То есть чем меньше сумма в конверте А, тем с большей вероятностью следует сменить конверт и наоборот,
             * несколько большая сумма в А говорит о том, что скорее следует оставить первый конверт себе.
             */
            
            if (envelopePair.FirstEnvelope.Amount <= randomValue)
            {
                return envelopePair.SecondEnvelope.Amount;
            }
            else
            {
                return envelopePair.FirstEnvelope.Amount;
            }
        }
    }
}

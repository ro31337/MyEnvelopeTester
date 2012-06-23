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
        private int max = 10;

        public int Pick(IRandomProvider randomProvider, EnvelopePair envelopePair)
        {
            int amount = 0;
            int randomValue = randomProvider.Next(1, max);

            /*
             * То есть чем меньше сумма в конверте А, тем с большей вероятностью следует сменить конверт и наоборот,
             * несколько большая сумма в А говорит о том, что скорее следует оставить первый конверт себе.
             */
            
            if (envelopePair.FirstEnvelope.Amount <= randomValue)
            {
                amount = envelopePair.SecondEnvelope.Amount;
            }
            else
            {
                amount = envelopePair.FirstEnvelope.Amount;
            }


            if (amount > max)
                max = amount;

            return amount;
        }
    }
}

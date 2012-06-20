using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnvelopeTester.Core;
using MyEnvelopeTester.RandomProvider;
using MyEnvelopeTester.Picker;

namespace MyEnvelopeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EnvelopePair> envelopePairs = new List<EnvelopePair>();

            IRandomProvider randomProvider = new StandardRandomProvider();
            IPicker picker = new CoverStrategyPicker(); // change picker here

            // maximum envelope pairs

            int maxEnvelopePairs = 1000000;

            // fill envelopes with random values
            
            for (int i = 0; i < maxEnvelopePairs; i++)
            {
                EnvelopePair envelopePair = new EnvelopePair();
                envelopePair.Init(randomProvider);
                envelopePairs.Add(envelopePair);
            }

            // our balance is 0 at the moment

            int money = 0;

            // lets pick envelopes

            for (int i = 0; i < envelopePairs.Count; i++)
            {
                EnvelopePair currentEnvelopePair = envelopePairs[i];
                money += picker.Pick(randomProvider, currentEnvelopePair);
            }

            Console.WriteLine("Your balance is: " + money);
        }
    }
}

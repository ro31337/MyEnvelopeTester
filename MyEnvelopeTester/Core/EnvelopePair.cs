using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnvelopeTester.RandomProvider;

namespace MyEnvelopeTester.Core
{
    public sealed class EnvelopePair
    {
        public Envelope FirstEnvelope { get; set; }
        public Envelope SecondEnvelope { get; set; }

        public EnvelopePair()
        {
            FirstEnvelope = new Envelope();
            SecondEnvelope = new Envelope();
        }

        public void Init(IRandomProvider randomProvider)
        {
            // $5 or $10

            int a = 0;
            int b = 0;

            if (randomProvider.Next(0, 100) >= 50)
            {
                a = 5;
                b = 10;
            }
            else
            {
                a = 10;
                b = 5;
            }

            // put money inside

            FirstEnvelope.Amount = a;
            SecondEnvelope.Amount = b;
        }
    }
}

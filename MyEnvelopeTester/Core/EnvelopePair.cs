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
            // from $1 or $2000

            int a = randomProvider.Next(1, 1000);
            int b = a * 2;

            if (randomProvider.Next(1, 100) > 50)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            // put money inside

            FirstEnvelope.Amount = a;
            SecondEnvelope.Amount = b;
        }
    }
}

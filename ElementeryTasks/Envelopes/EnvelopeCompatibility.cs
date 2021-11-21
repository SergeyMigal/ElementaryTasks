using System;
using System.Collections.Generic;
using System.Text;

namespace Envelopes
{
    class EnvelopeCompatibility
    {
        public bool Compatibility(EnvelopeModel envelopeModelA, EnvelopeModel envelopeModelB)
        {
            if (envelopeModelA.Height < envelopeModelB.Height & envelopeModelA.Widht < envelopeModelB.Widht)
            {
                return false;
            }
            else if (envelopeModelA.Height < envelopeModelB.Widht & envelopeModelA.Widht < envelopeModelB.Height)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

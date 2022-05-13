using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal interface MatchmakingStrategy
    {
        Individual Match(Individual me, List<Individual> individuals);

        Individual Match_Reverse(Individual me, List<Individual> individuals);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class MatchmakingSystemReverse : MatchmakingSystemBase
    {
        public MatchmakingSystemReverse(MatchmakingStrategy strategy) : base(strategy)
        {
        }

        public override void Start()
        {
            Console.WriteLine("開始進行配對(反向) \r\n");
            Individual individual = _strategy.Match_Reverse(me(), individuals_without_me());
            Console.WriteLine($"與 對象 {individual.id} 配對成功 \r\n");
        }
    }
}

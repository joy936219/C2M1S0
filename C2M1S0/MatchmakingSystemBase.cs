using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal abstract class MatchmakingSystemBase
    {
        protected MatchmakingStrategy _strategy;
        protected List<Individual> _individuals;
        public MatchmakingSystemBase(MatchmakingStrategy strategy)
        {
            _strategy = strategy;
            _individuals = new List<Individual>();
        }
        public void join(Individual individual)
        {
            _individuals.Add(individual);
        }

        public abstract void Start();
       

        public Individual me()
        {
            return _individuals.FirstOrDefault();
        }

        public List<Individual> individuals_without_me()
        {
            return _individuals.Where(x => x.id != me().id).ToList();
        }
    }
}

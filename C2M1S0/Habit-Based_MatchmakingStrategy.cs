using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class Habit_Based_MatchmakingStrategy : MatchmakingStrategy
    {
        
        
        public Individual Match(Individual me, List<Individual> individuals)
        {
            //先以交集量由大到小排序再由ID由小到大, 排序後取第一個
            return individuals.OrderByDescending(x => GetHabits(me, x)).ThenBy(x => x.id).FirstOrDefault();
        }
        //反向
        public Individual Match_Reverse(Individual me, List<Individual> individuals)
        {
            return individuals.OrderBy(x => GetHabits(me, x)).ThenBy(x => x.id).FirstOrDefault();
        }

        private int GetHabits(Individual me, Individual individual)
        {
            string[] me_habits;
            string[] individual_habits;
            int habits = 0;

            me_habits = me.habits != null ? me.habits.Split(',') : new string[] { };
            individual_habits = individual.habits != null ? individual.habits.Split(',') : new string[] { };
            //使用Linq Intersect 交集 找出相同的興趣數量
            habits = me_habits.Intersect(individual_habits).Count();
            Console.WriteLine($"與 對象{individual.id} 有{habits}個興趣的交集 \r\n");
            return habits;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class Distance_Based_MatchmakingStrategy : MatchmakingStrategy
    {
        public Individual Match(Individual me, List<Individual> individuals)
        {
            //先以距離由小到大排序再由ID由小到大, 排序後取第一個
            return individuals.OrderBy(x => GetDistance(me, x)).ThenBy(x => x.id).FirstOrDefault();
        }
        //反向
        public Individual Match_Reverse(Individual me, List<Individual> individuals)
        {
            return individuals.OrderByDescending(x => GetDistance(me, x)).ThenBy(x => x.id).FirstOrDefault();
        }

        private double GetDistance(Individual me, Individual individual)
        {
            int me_x;
            int me_y;
            int individual_x;
            int individual_y;
            double distance;
            me_x = me.coord[0];
            me_y = me.coord[1];
            individual_x = individual.coord[0];
            individual_y = individual.coord[1];
            distance = Math.Round(Math.Sqrt((Math.Pow((individual_y - me_y), 2) + Math.Pow((me_x - individual_x), 2))), 0);
            Console.WriteLine($"與對象 {individual.id} 距離 {distance} \r\n");
            return distance;
        }
    }
}

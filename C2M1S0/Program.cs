using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatchmakingSystemBase matchmakingSystem = new MatchmakingSystem(new Habit_Based_MatchmakingStrategy());
            //MatchmakingSystemBase matchmakingSystem = new MatchmakingSystemReverse(new Habit_Based_MatchmakingStrategy());
            Individual me = new Individual(1, Gender.Male , 18, "", "打籃球,煮菜,玩遊戲", new int[] { 1,1 });

            Individual Ind1 = new Individual(2, Gender.Female, 19, "", "打籃球,煮菜", new int[] { 9, 8 });
            Individual Ind2 = new Individual(3, Gender.Female, 20, "", "煮菜", new int[] { 1, 2 });
            Individual Ind3 = new Individual(4, Gender.Female, 21, "", "玩遊戲", new int[] { 1, 2 });
            Individual Ind4 = new Individual(5, Gender.Female, 22, "", "打籃球", new int[] { 1, 30 });

            matchmakingSystem.join(me);
            matchmakingSystem.join(Ind1);
            matchmakingSystem.join(Ind2);
            matchmakingSystem.join(Ind3);
            matchmakingSystem.join(Ind4);

            matchmakingSystem.Start();

            Console.ReadLine();
        }
    }
}

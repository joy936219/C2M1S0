using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class Individual
    {
        private int _id;
        private Gender _gender;
        private int _age;
        private string _intro;
        private string _habits;
        private int[] _coord;

        public Individual(int id,Gender gender, int age, string intro,string habits,int[] coord)
        {
            _id = id;
            _gender = gender;
            _age = age;
            _intro = intro;
            _habits = habits;
            _coord = coord;
        }

        public int id { get => _id; set => _id = value; }
        public Gender gender { get => _gender; set => _gender = value; }
        public int age { get => _age; set => _age = value; }
        public string intro { get => _intro; set => _intro = value; }
        public string habits { get => _habits; set => _habits = value; }
        public int[] coord { get => _coord; set => _coord = value; }

    }

   

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}

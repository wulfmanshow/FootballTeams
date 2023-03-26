using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FootballTeam
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public int WinCount { get; set; }

        public int LoseCount { get; set; }

        public int DrawCount { get; set; }

        public int LoosedGoals { get; set; }
        public int ScoredGoals { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {City} {WinCount} {LoseCount} {DrawCount} {LoosedGoals} {ScoredGoals}";
        }
    }
}

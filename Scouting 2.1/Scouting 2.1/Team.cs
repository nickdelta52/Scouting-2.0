using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouting_2._1
{
    public class Team
    {
        public Team(int _number, string _binary)
        {
            actions = new Action[120];
            defenses = new bool[9];
            this.number = _number;
            for (int i = 0; i < _binary.Length; i++)
			{
                char letter = _binary[i];
                if (letter == '1')
                {
                    defenses[i] = true;
                }
                else
                {
                    defenses[i] = false;
                }
            }
        }
        public int number;
        public bool[] defenses;
        public Action[] actions;
    }
}

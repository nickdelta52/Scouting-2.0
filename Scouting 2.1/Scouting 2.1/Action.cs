using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouting_2._1
{
    class Action
    {
        /* A key is an action, an id is the object of the action
         * Keys:|D - cross defense | S - shoot | C - challenge tower | P - pick up ball |
         * IDs: |                  |           |                     |                  |
         * 0    |Portcullis        |High Left  |Climb Left           |Success           |
         * 1    |Cheval de Frise   |High Middle|Climb Middle         |Fail              |
         * 2    |Ramparts          |High Right |Climb Right          |                  |
         * 3    |Moat              |High Miss  |Climb Fail           |                  |
         * 4    |Drawbridge        |Low Left   |Challenge Left       |                  |
         * 5    |Sally Port        |           |Challenge Middle     |                  |
         * 6    |Rock Wall         |Low Right  |Challenge Right      |                  |
         * 7    |Rough Terrain     |Low Miss   |Challenge Fail       |                  |
         * 8    |Low Bar           |           |                     |                  |
         * 9    |                  |           |                     |                  |
         */
        public Action(char _key, int _id)
        {
            this.key = _key;
            this.id = _id;
        }
        public char key;
        public int id;
    }
}

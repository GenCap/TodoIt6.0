using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoIt6._0.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int PersonId
        {
            get
            {
                return personId;
            }
            set
            {
                personId = value;
            }
        }

        public static int NextPersonId()
        {
            ++personId;
            return personId;
        }


        public static void Reset()
        {
            personId = 0;

        }
    }
}

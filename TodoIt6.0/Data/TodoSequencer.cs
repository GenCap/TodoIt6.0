using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoIt6._0.Data
{
    public class TodoSequencer
    {
        private static int todoId;

        public static int TodoId
        {
            get
            {
                return todoId;
            }
            set
            {
                todoId = value;
            }
        }

        public static int NextTodoId()
        {
            ++todoId;
            return todoId;
        }


        public static void Reset()
        {
            todoId = 0;

        }
    }
}

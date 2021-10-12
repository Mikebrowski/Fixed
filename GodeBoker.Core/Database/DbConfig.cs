using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodeBoker.Core.Database
{
    class DbConfig
    {
        //public static object Value { get; internal set; }
        public string Database_name { get; set; } // Database name aka for example localhost
        public string Table_name { get; set; } // Name of the table aka GoodBooks
        public string Con_String { get; set; } 

    }
}

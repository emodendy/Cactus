using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARIS2008.DB
{
    internal class ConnectionClass
    {
        public static hypeCactusEntities2 connect = new hypeCactusEntities2();
        public static Role role;
        public static Exhibition exhibition;
    }
}

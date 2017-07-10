using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Platform.Parts.DAL
{
    abstract class Connection
    {
        private SqlConnection _sqlConnetion;

        public int Insert()
        {
            return 0;
        }
    }
}

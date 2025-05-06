using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class ConnectionHandler
    {
        public static Connection GetConnection()
        {
            return new Connection();
        }
    }
}

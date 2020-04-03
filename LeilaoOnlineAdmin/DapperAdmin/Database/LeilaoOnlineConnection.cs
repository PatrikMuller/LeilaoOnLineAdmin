using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAdmin.Database
{
    public class LeilaoOnlineConnection
    {
        string StringConnection = @"Server=localhost;Port=5432;Database=leilao_online;User Id=user_leilao_online;Password=detranR0;";

        public NpgsqlConnection Connection ()
        {
            return new NpgsqlConnection(StringConnection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.Services.Abstract;
using Npgsql;

namespace MicroMoney.Services
{
    public class DbManager : IDbManager
    {
        public DbManager()
        {
            //await using var conn = new NpgsqlConnection(connectionString);
        }
    }
}
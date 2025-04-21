using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;
using MySql.Data.MySqlClient;

namespace EntityProject.Services
{
    public class EntityDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public EntityDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("dbconn");
        }
        
        public IDbConnection CreateConnection()
            => new MySqlConnection(_connectionString);
        
    }
}

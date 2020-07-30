using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Cimena.DAL
{
    public class BaseRepository
    {
        protected IDbConnection conn;
        public BaseRepository()
        {
            string connectionString = @"Data Source=DESKTOP-E754EJE\sqlexpress;Initial Catalog=MovieDB;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }
    }
}


using System.Collections.Generic;
using ProjectRpl.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;


namespace ProjectRpl.DAL
{
    public class LoginDAL : ILogin
    {
        private IConfiguration _config;
        
        public LoginDAL(IConfiguration config)
        {
           _config = config; 
        }

        private string getConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }        

        public IEnumerable<Login> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Login order by username";
            return conn.Query<Login>(strSql);

        }
        }

        public Login GetById(string username)
        {
            
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            // var strSql = @"select * from Login where username=@username, password=@password";
            var strSql = @"select * from Login where username=@username";
            var param = new {username = username};
            var data = conn.QuerySingleOrDefault<Login>(strSql, param);
            if(data!=null)
            return data;
            else
            throw new Exception("Kamu bukan Admin !");
        }
        }


    }
}
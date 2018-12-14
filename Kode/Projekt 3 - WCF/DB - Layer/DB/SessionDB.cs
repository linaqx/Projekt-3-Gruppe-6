﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;

namespace DB___Layer.DB
{
    public class SessionDB : ISessionDB
    {
        private readonly string sql_LOGIN_CONFIRMATION = "select [User].person_id as id, [User].userName, [User].[password], [User].email, Person.firstName, Person.lastName, Person.information from [User], Person where [User].person_id = Person.id and [User].userName = @userName;";
        private readonly string sql_FIND_SESSION = "select [Session].person_id, [Session].session_id from [Session] where [Session].person_id = @person_id;";

        private SqlCommand loginConfirmation;
        private SqlCommand findSession;

        private SqlConnection con;

        public SessionDB()
        {
            con = DBConnection.GetInstance().GetConnection();

            loginConfirmation = con.CreateCommand();

            findSession = con.CreateCommand();
        }

        public User LoginConfirmation(string userName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@userName",
                Value = userName
            };

            loginConfirmation.Parameters.Add(parameter);
            loginConfirmation.CommandText = sql_LOGIN_CONFIRMATION;

            User temp = new User();
            SqlDataReader reader = loginConfirmation.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    UserName = reader.GetString(reader.GetOrdinal("userName")),
                    Password = reader.GetString(reader.GetOrdinal("password"))
                };
                temp = user;
            }

            reader.Close();

            return temp;
        }

        public Session FindSession(int person_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "person_id",
                Value = person_id
            };

            findSession.Parameters.Add(parameter);
            findSession.CommandText = sql_FIND_SESSION;

            Session temp = new Session();
            SqlDataReader reader = findSession.ExecuteReader();

            while (reader.Read())
            {
                Session session = new Session
                {
                    User_id = reader.GetInt32(reader.GetOrdinal("person_id")),
                    Session_id = reader.GetString(reader.GetOrdinal("session_id"))
                };
                temp = session;
            }
            reader.Close();

            return temp;
        }



    }
}

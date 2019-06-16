﻿using GetMeALibrary.Interface;
using MySql.Data.MySqlClient;
using System;

namespace GetMeALibrary.Model
{
    public class UserSetting : DatabaseObject, IUserSetting
    {
        public string Name { get; set; }
        public int Userid { get; set; }
        public string Value { get; set; }

        public override string GetInsertColumns() { return "NAME, USERID, VALUE"; }

        public override string GetInsertValues() { return $"'{Name}', {Userid}, '{Value}'"; }

        public override string GetSetValues(int ID)
        {
            return $"SET NAME = '{Name}', " +
             $"USERID = {Userid}, " +
             $"VALUE = '{Value}', " +
             $"WHERE ID = {ID}";
        }

        public override string GetTableName() { return "USERSETTING"; }



        public override void Parse(MySqlDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"].ToString());
            Name = reader["NAME"].ToString();
            Userid = Convert.ToInt32(reader["USERID"].ToString());
            Value = reader["VALUE"].ToString();
        }
    }
}

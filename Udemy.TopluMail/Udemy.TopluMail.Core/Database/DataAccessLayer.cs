﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TopluMail.Core.Helper;

namespace Udemy.TopluMail.Core.Database
{
    public class DataAccessLayer : globalIslemler
    {
        public SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValue;

        public DataAccessLayer()
        {
            con = new SqlConnection("data source=(localdb)\\MSSQLLOCALDB; initial catalog=Udemyyy;");
        }

        public int Calistir(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            TryCatchKullan(() =>
            {
                ReturnValue = cmd.ExecuteNonQuery();
            });
            con.Close();
            return ReturnValue;
        }

        public SqlDataReader VeriGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            TryCatchKullan(() =>
            {
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public int CalistirINT(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            TryCatchKullan(() =>
            {
                ReturnValue = (int)cmd.ExecuteScalar();
            });
            con.Close();
            return ReturnValue;
        }
    }
}

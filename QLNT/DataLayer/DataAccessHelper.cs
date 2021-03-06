﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLNT.DataLayer
{
    class DataAccessHelper
    {
        #region Data access properties
        public SqlConnection con;
        SqlCommand cmd;
        public DataTable dt;

        #endregion

        #region Init properties
        public DataAccessHelper()
        {
            //con = new System.Data.SqlClient.SqlConnection();
            //con.ConnectionString = "Server=.\\SQLEXPRESS; AttachDbFilename = QLNT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //con.Open();
            String connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QLNT;Data Source=VYLE";
            con = new SqlConnection(connectionString);
        }
        #endregion

        #region Procceed with database
        public void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        private void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public DataTable GetDataTable(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        public SqlCommand Command(String commandString)
        {
            this.cmd = new SqlCommand(commandString, con);
            return cmd;
        }
    }
}

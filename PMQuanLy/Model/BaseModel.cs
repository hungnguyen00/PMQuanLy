using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class BaseModel
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataTable dt1;

        String cnnString = System.IO.Directory.GetCurrentDirectory() + "/../../quanly_db.sqlite";

        private void startConnect()
        {
            if (cmd == null) 
            {
                conn = new SQLiteConnection();
                cmd = new SQLiteCommand();
                adapter = new SQLiteDataAdapter();

                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
                //conn.ConnectionString = @"data source=E:\visual_workspace\PMQuanLy\PMQuanLy\quanly_db.sqlite";
                conn.ConnectionString = @"data source=" + cnnString;
            }
        }
        private void stopConnect()
        {
            if (cmd != null) 
            {
                conn.Close();
                cmd = null;
                adapter = null;
            }
        }
        protected DataTable selectQuery(String select, String from, String where, SQLiteParameter[] arrValues)
        {
            startConnect();
            dt1 = new DataTable();
            String sqlCommand = "SELECT " + select + " FROM " + from;
            if (where.Length > 0) 
            {
                sqlCommand += " WHERE " + where;
            }
            cmd.CommandText = sqlCommand;

            if (arrValues.Count() > 0) 
            {
                foreach (SQLiteParameter value in arrValues) 
                {
                    cmd.Parameters.Add(value);
                }
            }

            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
            return dt1;
        }

        protected bool existQuery(String from, String where, SQLiteParameter[] arrValues)
        {
            startConnect();
            dt1 = new DataTable();
            String sqlCommand = "SELECT count(*) FROM " + from;
            if (where.Length > 0)
            {
                sqlCommand += " WHERE " + where;
            }
            cmd.CommandText = sqlCommand;

            if (arrValues.Count() > 0)
            {
                foreach (SQLiteParameter value in arrValues)
                {
                    cmd.Parameters.Add(value);
                }
            }
            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1") 
            {
                return true;
            }
            return false;
        }
    }
}

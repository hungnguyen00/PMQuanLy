using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class MemberModel:BaseModel
    {
        String table = "member";

        public bool isLoginSuccess(String username, String password)
        {
            String where = "username=@username AND password=@password";
            SQLiteParameter[] arrValues = { new SQLiteParameter("username", username), new SQLiteParameter("password", password) };
            return existQuery(table, where, arrValues);
        }
    }
}

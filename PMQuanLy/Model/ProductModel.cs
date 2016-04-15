using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class ProductModel:BaseModel
    {
        String table = "products";

        public DataTable getAllProduct() 
        {
            String select = " id, code, name, quantity, total_weight ";
            String where = "del_flg=@del_flg";
            SQLiteParameter[] arrValues = {new SQLiteParameter("del_flg", "0") };
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getProductById(int id)
        {
            String select = " id, code, name, quantity, total_weight ";
            String where = "id=@id AND del_flg=@del_flg";
            SQLiteParameter[] arrValues = { new SQLiteParameter("id", id), new SQLiteParameter("del_flg", "0") };
            return selectQuery(select, table, where, arrValues);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class InventoryModel:BaseModel
    {
        String table = "inventory";

        public DataTable getAllProductDetail() 
        {
            String select = " *";
            String where = "";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getProductDetailByCode(int code)
        {
            String select = " code, product_detail_id, weight, status";
            String where = "code=@code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("code", code)};
            return selectQuery(select, table, where, arrValues);
        }
    }
}

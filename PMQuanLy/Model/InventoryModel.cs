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

        public DataTable getAllInventory() 
        {
            String select = " p.name, i.qr_code, i.weight, i.created_date";
            String where = "";
            table = "inventory i left join list_product p on i.product_code = p.product_code";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getInventoryByQrCode(int code)
        {
            String select = " code, product_detail_id, weight, status";
            String where = "code=@code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("code", code)};
            return selectQuery(select, table, where, arrValues);
        }
    }
}

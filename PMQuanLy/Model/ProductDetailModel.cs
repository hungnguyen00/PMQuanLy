using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class ProductDetailModel:BaseModel
    {
        String table = "product_detail";

        public DataTable getAllProductDetail() 
        {
            String select = " code, product_detail_id, weight, status";
            String where = "del_flg=@del_flg";
            SQLiteParameter[] arrValues = {new SQLiteParameter("del_flg", "0") };
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getProductDetailByCode(int code)
        {
            String select = " code, product_detail_id, weight, status";
            String where = "code=@code AND del_flg=@del_flg";
            SQLiteParameter[] arrValues = { new SQLiteParameter("code", code), new SQLiteParameter("del_flg", "0") };
            return selectQuery(select, table, where, arrValues);
        }
    }
}

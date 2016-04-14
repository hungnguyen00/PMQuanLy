using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PMQuanLy
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn = new SQLiteConnection();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        DataTable dt1;
        BindingSource bs = new BindingSource();
        String cnnString = System.IO.Directory.GetCurrentDirectory() + "/../../quanly_db.sqlite";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            LoadDataProduct();
        }
        private void LoadDataProduct()
        {
            dt1 = new DataTable();
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            //conn.ConnectionString = @"data source=E:\visual_workspace\PMQuanLy\PMQuanLy\quanly_db.sqlite";
            conn.ConnectionString = @"data source=" + cnnString;
            cmd.CommandText = "select id, code, name, quantity, total_weight from products";
            adapter.SelectCommand = cmd;
            dt1.Rows.Clear();
            adapter.Fill(dt1);
            bs.DataSource = dt1;
            gridProduct.DataSource = bs;
        }
        private void LoadDataProductDetail()
        {
            dt1 = new DataTable();
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            //conn.ConnectionString = @"data source=E:\visual_workspace\PMQuanLy\PMQuanLy\quanly_db.sqlite";
            conn.ConnectionString = @"data source=" + cnnString;
            cmd.CommandText = "select code, product_detail_id, weight from product_detail";
            adapter.SelectCommand = cmd;
            dt1.Rows.Clear();
            adapter.Fill(dt1);
            bs.DataSource = dt1;
            gridProductDetail.DataSource = bs;
        }

        private void navBarProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            LoadDataProduct();
        }

        private void navBarProductDetail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            LoadDataProductDetail();
        }
        private void navBarOrder_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }
    }
}

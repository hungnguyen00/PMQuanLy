using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using PMQuanLy.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PMQuanLy
{
    public partial class MainForm : Form
    {
        ListProductModel mProduct;
        InventoryModel mInventory;
        BindingSource bs = new BindingSource();
        String cnnString = System.IO.Directory.GetCurrentDirectory() + "/../../quanly_db.sqlite";
        private DataTable dtProduct, dtInventory, dtOrder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mProduct = new ListProductModel();
            mInventory = new InventoryModel();
            xtraTabControl1.SelectedTabPageIndex = 2;
            LoadDataOrder();
        }
        private void LoadDataProduct()
        {
            dtProduct = new DataTable();
            dtProduct = mProduct.getAllProduct();
            bs.DataSource = dtProduct;
            gridProduct.DataSource = bs;
        }
        private void LoadDataInventory()
        {
            dtInventory = new DataTable();
            dtInventory = mInventory.getAllProductDetail();
            bs.DataSource = dtInventory;
            gridProductDetail.DataSource = bs;
        }
        private void LoadDataOrder()
        {
            dtInventory = new DataTable();
            dtOrder = new DataTable();
            dtOrder.Columns.Add("qr_code");
            dtOrder.Columns.Add("weight");
            dtOrder.Columns.Add("product_code");
            dtOrder.Columns.Add("created_date");
            gridOrder2.DataSource = dtOrder;
            dtInventory = mInventory.getAllProductDetail();
            bs.DataSource = dtInventory;
            gridOrder.DataSource = bs;
        }   

        private void navBarProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            LoadDataProduct();
        }

        private void navBarProductDetail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            LoadDataInventory();
        }
        private void navBarOrder_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
            LoadDataOrder();
        }
        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow[] rows = new DataRow[view.SelectedRowsCount];
                for (int i = 0; i < view.SelectedRowsCount; i++)
                {
                    rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
                }
                foreach (DataRow row in rows)
                {
                    dtOrder.ImportRow(row);
                }
                gridOrder2.DataSource = dtOrder;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow[] rows = new DataRow[view.SelectedRowsCount];
                for (int i = 0; i < view.SelectedRowsCount; i++)
                {
                    rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
                }
                foreach (DataRow row in rows)
                {
                    dtProduct.ImportRow(row);
                }
                gridOrder.DataSource = dtInventory;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        /*private void DoRowDoubleClick(GridView view, Point pt)
        {
            //Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //object val = view.GetRowCellValue(info.RowHandle, info.Column);
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}, value: {2}", info.RowHandle, colCaption, val));
                DataRow[] rows = new DataRow[view.SelectedRowsCount];
                for (int i = 0; i < view.SelectedRowsCount; i++)

                    rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
                foreach (DataRow row in rows)

                    dtOrder.Rows.Add(row);

                DataRow dr = dtOrder.NewRow();
                dr["id"] = view.GetRowCellValue(info.RowHandle, "id");
                dr["code"] = view.GetRowCellValue(info.RowHandle, "code");
                dr["name"] = view.GetRowCellValue(info.RowHandle, "name");
                dr["quantity"] = view.GetRowCellValue(info.RowHandle, "quantity");
                dr["total_weight"] = view.GetRowCellValue(info.RowHandle, "total_weight");
                dtOrder.Rows.Add(dr);
                gridOrder2.DataSource = dtOrder;
            }

        }*/

    }
}

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

namespace PMQuanLy
{
    public partial class MainForm : Form
    {
        ProductModel mProduct;
        ProductDetailModel mProductDetail;
        BindingSource bs = new BindingSource();
        String cnnString = System.IO.Directory.GetCurrentDirectory() + "/../../quanly_db.sqlite";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mProduct = new ProductModel();
            mProductDetail = new ProductDetailModel();
            xtraTabControl1.SelectedTabPageIndex = 0;
            LoadDataProduct();
        }
        private void LoadDataProduct()
        {
            bs.DataSource = mProduct.getProductById(1);
            gridProduct.DataSource = bs;
        }
        private void LoadDataProductDetail()
        {
            bs.DataSource = mProductDetail.getAllProductDetail();
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

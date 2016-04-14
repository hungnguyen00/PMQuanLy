namespace PMQuanLy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelProductGrid = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarProductDetail = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.panelProduct = new DevExpress.XtraEditors.PanelControl();
            this.panelProductDetail = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelProductDetailGrid = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridProductDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductGrid)).BeginInit();
            this.panelProductGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProduct)).BeginInit();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetail)).BeginInit();
            this.panelProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetailGrid)).BeginInit();
            this.panelProductDetailGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.labelControl2.Location = new System.Drawing.Point(21, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(189, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Product Management";
            // 
            // panelProductGrid
            // 
            this.panelProductGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductGrid.Controls.Add(this.labelControl1);
            this.panelProductGrid.Controls.Add(this.gridProduct);
            this.panelProductGrid.Location = new System.Drawing.Point(2, 62);
            this.panelProductGrid.Name = "panelProductGrid";
            this.panelProductGrid.Size = new System.Drawing.Size(865, 450);
            this.panelProductGrid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 0;
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(2, 2);
            this.gridProduct.MainView = this.gridView1;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(861, 446);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarProduct,
            this.navBarProductDetail,
            this.navBarOrder});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 520);
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Catalog";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarProductDetail)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarProduct
            // 
            this.navBarProduct.Caption = "Product";
            this.navBarProduct.Name = "navBarProduct";
            this.navBarProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarProduct_LinkClicked);
            // 
            // navBarProductDetail
            // 
            this.navBarProductDetail.Caption = "Product Detail";
            this.navBarProductDetail.Name = "navBarProductDetail";
            this.navBarProductDetail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarProductDetail_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Order";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOrder)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarOrder
            // 
            this.navBarOrder.Name = "navBarOrder";
            this.navBarOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOrder_LinkClicked);
            // 
            // panelProduct
            // 
            this.panelProduct.AutoSize = true;
            this.panelProduct.Controls.Add(this.labelControl2);
            this.panelProduct.Controls.Add(this.panelProductGrid);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(0, 0);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(866, 514);
            this.panelProduct.TabIndex = 6;
            // 
            // panelProductDetail
            // 
            this.panelProductDetail.Controls.Add(this.labelControl3);
            this.panelProductDetail.Controls.Add(this.panelProductDetailGrid);
            this.panelProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDetail.Location = new System.Drawing.Point(0, 0);
            this.panelProductDetail.Name = "panelProductDetail";
            this.panelProductDetail.Size = new System.Drawing.Size(866, 514);
            this.panelProductDetail.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.labelControl3.Location = new System.Drawing.Point(21, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(248, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Product Detail Management";
            // 
            // panelProductDetailGrid
            // 
            this.panelProductDetailGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductDetailGrid.Controls.Add(this.labelControl4);
            this.panelProductDetailGrid.Controls.Add(this.gridProductDetail);
            this.panelProductDetailGrid.Location = new System.Drawing.Point(2, 62);
            this.panelProductDetailGrid.Name = "panelProductDetailGrid";
            this.panelProductDetailGrid.Size = new System.Drawing.Size(862, 450);
            this.panelProductDetailGrid.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 0;
            // 
            // gridProductDetail
            // 
            this.gridProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductDetail.Location = new System.Drawing.Point(2, 2);
            this.gridProductDetail.MainView = this.gridView2;
            this.gridProductDetail.Name = "gridProductDetail";
            this.gridProductDetail.Size = new System.Drawing.Size(858, 446);
            this.gridProductDetail.TabIndex = 0;
            this.gridProductDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridProductDetail;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(116, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(895, 520);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(866, 514);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelProductDetail);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(866, 514);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 520);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelProductGrid)).EndInit();
            this.panelProductGrid.ResumeLayout(false);
            this.panelProductGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelProduct)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetail)).EndInit();
            this.panelProductDetail.ResumeLayout(false);
            this.panelProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductDetailGrid)).EndInit();
            this.panelProductDetailGrid.ResumeLayout(false);
            this.panelProductDetailGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelProductGrid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarProduct;
        private DevExpress.XtraNavBar.NavBarItem navBarProductDetail;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.PanelControl panelProduct;
        private DevExpress.XtraEditors.PanelControl panelProductDetail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelProductDetailGrid;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridProductDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraNavBar.NavBarItem navBarOrder;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;


    }
}


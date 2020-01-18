namespace SaleOnline
{
    partial class frmOnlineSale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnlineSale));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnprint = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintKitchen = new DevExpress.XtraBars.BarButtonItem();
            this.btnAllPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowSaleDetaile = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lblCountNew = new DevExpress.XtraBars.BarHeaderItem();
            this.lblCountCanceled = new DevExpress.XtraBars.BarHeaderItem();
            this.lblCountEdit = new DevExpress.XtraBars.BarHeaderItem();
            this.lblVersion = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.saleFoodReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleFoodIDFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumPriceBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintStatelbl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDateSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleFoodReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnClose,
            this.btnprint,
            this.btnPrintCustomer,
            this.btnPrintKitchen,
            this.btnAllPrint,
            this.btnShowSaleDetaile,
            this.barEditItem1,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.barEditItem2,
            this.barEditItem3,
            this.lblCountNew,
            this.lblCountCanceled,
            this.lblCountEdit,
            this.lblVersion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1240, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "خروج";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 1;
            this.btnClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClose.LargeGlyph")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // btnprint
            // 
            this.btnprint.Caption = "چاپ فاکتور";
            this.btnprint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprint.Glyph")));
            this.btnprint.Id = 2;
            this.btnprint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprint.LargeGlyph")));
            this.btnprint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintKitchen),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAllPrint)});
            this.btnprint.Name = "btnprint";
            // 
            // btnPrintCustomer
            // 
            this.btnPrintCustomer.Caption = "فیش مشتری";
            this.btnPrintCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintCustomer.Glyph")));
            this.btnPrintCustomer.Id = 3;
            this.btnPrintCustomer.Name = "btnPrintCustomer";
            this.btnPrintCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintCustomer_ItemClick);
            // 
            // btnPrintKitchen
            // 
            this.btnPrintKitchen.Caption = "فیش آشپزخانه";
            this.btnPrintKitchen.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintKitchen.Glyph")));
            this.btnPrintKitchen.Id = 4;
            this.btnPrintKitchen.Name = "btnPrintKitchen";
            this.btnPrintKitchen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintKitchen_ItemClick);
            // 
            // btnAllPrint
            // 
            this.btnAllPrint.Caption = "چاپ همه";
            this.btnAllPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAllPrint.Glyph")));
            this.btnAllPrint.Id = 5;
            this.btnAllPrint.Name = "btnAllPrint";
            this.btnAllPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAllPrint_ItemClick);
            // 
            // btnShowSaleDetaile
            // 
            this.btnShowSaleDetaile.Caption = "جزئیات فیش";
            this.btnShowSaleDetaile.Glyph = ((System.Drawing.Image)(resources.GetObject("btnShowSaleDetaile.Glyph")));
            this.btnShowSaleDetaile.Id = 6;
            this.btnShowSaleDetaile.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnShowSaleDetaile.LargeGlyph")));
            this.btnShowSaleDetaile.Name = "btnShowSaleDetaile";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 7;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 8;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "barHeaderItem2";
            this.barHeaderItem2.Id = 9;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemTextEdit2;
            this.barEditItem2.Id = 10;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit3;
            this.barEditItem3.Id = 11;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // lblCountNew
            // 
            this.lblCountNew.Caption = "جدید";
            this.lblCountNew.Id = 12;
            this.lblCountNew.Name = "lblCountNew";
            // 
            // lblCountCanceled
            // 
            this.lblCountCanceled.Caption = "لغو";
            this.lblCountCanceled.Id = 13;
            this.lblCountCanceled.Name = "lblCountCanceled";
            // 
            // lblCountEdit
            // 
            this.lblCountEdit.Caption = "ویرایش";
            this.lblCountEdit.Id = 14;
            this.lblCountEdit.Name = "lblCountEdit";
            // 
            // lblVersion
            // 
            this.lblVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblVersion.Caption = "نسخه برنامه";
            this.lblVersion.Id = 15;
            this.lblVersion.Name = "lblVersion";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "عملیات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowSaleDetaile);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "عملیات";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnprint);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "چاپ فاکتور";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "بستن";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblCountNew);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblCountEdit);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblCountCanceled);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 462);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1240, 23);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 147);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1240, 315);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.saleFoodReportBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.grd;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1216, 291);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd});
            // 
            // saleFoodReportBindingSource
            // 
            this.saleFoodReportBindingSource.DataSource = typeof(SaleFoodReport);
            // 
            // grd
            // 
            this.grd.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grd.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grd.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grd.Appearance.SelectedRow.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grd.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grd.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grd.ColumnPanelRowHeight = 25;
            this.grd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSaleFoodIDFact,
            this.colNumFish,
            this.colSaleTime,
            this.colSumPriceBase,
            this.colSumNet,
            this.colSumDiscount,
            this.colSumNetPrice,
            this.colSumPrice,
            this.colTypeFactor,
            this.colCustomerName,
            this.colCustomerTell,
            this.colCustomerAddress,
            this.colDescription,
            this.colPrintStatelbl,
            this.colSaleDateSH,
            this.colStateFact,
            this.colStateDelivery});
            this.grd.GridControl = this.gridControl1;
            this.grd.IndicatorWidth = 40;
            this.grd.Name = "grd";
            this.grd.OptionsBehavior.Editable = false;
            this.grd.OptionsView.ShowFooter = true;
            this.grd.OptionsView.ShowGroupPanel = false;
            this.grd.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grd_CustomDrawRowIndicator);
            this.grd.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grd_RowStyle);
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 10;
            this.colID.Name = "colID";
            this.colID.Width = 10;
            // 
            // colSaleFoodIDFact
            // 
            this.colSaleFoodIDFact.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleFoodIDFact.AppearanceCell.Options.UseFont = true;
            this.colSaleFoodIDFact.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleFoodIDFact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleFoodIDFact.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleFoodIDFact.AppearanceHeader.Options.UseFont = true;
            this.colSaleFoodIDFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleFoodIDFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleFoodIDFact.Caption = "ش فاکتور";
            this.colSaleFoodIDFact.FieldName = "SaleFoodIDFact";
            this.colSaleFoodIDFact.Name = "colSaleFoodIDFact";
            this.colSaleFoodIDFact.Visible = true;
            this.colSaleFoodIDFact.VisibleIndex = 2;
            // 
            // colNumFish
            // 
            this.colNumFish.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colNumFish.AppearanceCell.Options.UseFont = true;
            this.colNumFish.AppearanceCell.Options.UseTextOptions = true;
            this.colNumFish.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumFish.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colNumFish.AppearanceHeader.Options.UseFont = true;
            this.colNumFish.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumFish.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumFish.Caption = "ش فیش";
            this.colNumFish.FieldName = "NumFish";
            this.colNumFish.Name = "colNumFish";
            this.colNumFish.Visible = true;
            this.colNumFish.VisibleIndex = 4;
            // 
            // colSaleTime
            // 
            this.colSaleTime.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleTime.AppearanceCell.Options.UseFont = true;
            this.colSaleTime.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleTime.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleTime.AppearanceHeader.Options.UseFont = true;
            this.colSaleTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleTime.Caption = "ساعت سفارش";
            this.colSaleTime.DisplayFormat.FormatString = "HH:mm";
            this.colSaleTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaleTime.FieldName = "SaleTime";
            this.colSaleTime.Name = "colSaleTime";
            this.colSaleTime.Visible = true;
            this.colSaleTime.VisibleIndex = 7;
            // 
            // colSumPriceBase
            // 
            this.colSumPriceBase.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumPriceBase.AppearanceCell.Options.UseFont = true;
            this.colSumPriceBase.AppearanceCell.Options.UseTextOptions = true;
            this.colSumPriceBase.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumPriceBase.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumPriceBase.AppearanceHeader.Options.UseFont = true;
            this.colSumPriceBase.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumPriceBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumPriceBase.Caption = "ج مبلغ پایه";
            this.colSumPriceBase.DisplayFormat.FormatString = "c0";
            this.colSumPriceBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumPriceBase.FieldName = "SumPriceBase";
            this.colSumPriceBase.Name = "colSumPriceBase";
            this.colSumPriceBase.Visible = true;
            this.colSumPriceBase.VisibleIndex = 9;
            // 
            // colSumNet
            // 
            this.colSumNet.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumNet.AppearanceCell.Options.UseFont = true;
            this.colSumNet.AppearanceCell.Options.UseTextOptions = true;
            this.colSumNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumNet.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumNet.AppearanceHeader.Options.UseFont = true;
            this.colSumNet.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumNet.Caption = "ج مالیات";
            this.colSumNet.DisplayFormat.FormatString = "c0";
            this.colSumNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumNet.FieldName = "SumNet";
            this.colSumNet.Name = "colSumNet";
            this.colSumNet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumNet", "{0:c0}")});
            this.colSumNet.Visible = true;
            this.colSumNet.VisibleIndex = 13;
            // 
            // colSumDiscount
            // 
            this.colSumDiscount.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumDiscount.AppearanceCell.Options.UseFont = true;
            this.colSumDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colSumDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumDiscount.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumDiscount.AppearanceHeader.Options.UseFont = true;
            this.colSumDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumDiscount.Caption = "ج تخفیف";
            this.colSumDiscount.DisplayFormat.FormatString = "c0";
            this.colSumDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumDiscount.FieldName = "SumDiscount";
            this.colSumDiscount.Name = "colSumDiscount";
            this.colSumDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumDiscount", "{0:c0}")});
            this.colSumDiscount.Visible = true;
            this.colSumDiscount.VisibleIndex = 10;
            // 
            // colSumNetPrice
            // 
            this.colSumNetPrice.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumNetPrice.AppearanceCell.Options.UseFont = true;
            this.colSumNetPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSumNetPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumNetPrice.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumNetPrice.AppearanceHeader.Options.UseFont = true;
            this.colSumNetPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumNetPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumNetPrice.Caption = "ج مبلغ تخفیف";
            this.colSumNetPrice.DisplayFormat.FormatString = "c0";
            this.colSumNetPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumNetPrice.FieldName = "SumNetPrice";
            this.colSumNetPrice.Name = "colSumNetPrice";
            this.colSumNetPrice.Visible = true;
            this.colSumNetPrice.VisibleIndex = 11;
            // 
            // colSumPrice
            // 
            this.colSumPrice.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumPrice.AppearanceCell.Options.UseFont = true;
            this.colSumPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colSumPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumPrice.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSumPrice.AppearanceHeader.Options.UseFont = true;
            this.colSumPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumPrice.Caption = "ج کل";
            this.colSumPrice.DisplayFormat.FormatString = "c0";
            this.colSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumPrice.FieldName = "SumPrice";
            this.colSumPrice.Name = "colSumPrice";
            this.colSumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "{0:c0}")});
            this.colSumPrice.Visible = true;
            this.colSumPrice.VisibleIndex = 12;
            // 
            // colTypeFactor
            // 
            this.colTypeFactor.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colTypeFactor.AppearanceCell.Options.UseFont = true;
            this.colTypeFactor.AppearanceCell.Options.UseTextOptions = true;
            this.colTypeFactor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeFactor.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colTypeFactor.AppearanceHeader.Options.UseFont = true;
            this.colTypeFactor.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeFactor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeFactor.Caption = "نوع فاکتور";
            this.colTypeFactor.FieldName = "TypeFactor";
            this.colTypeFactor.Name = "colTypeFactor";
            this.colTypeFactor.Visible = true;
            this.colTypeFactor.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "مشتری";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            // 
            // colCustomerTell
            // 
            this.colCustomerTell.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerTell.AppearanceCell.Options.UseFont = true;
            this.colCustomerTell.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerTell.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerTell.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerTell.AppearanceHeader.Options.UseFont = true;
            this.colCustomerTell.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerTell.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerTell.Caption = "تلفن";
            this.colCustomerTell.FieldName = "CustomerTell";
            this.colCustomerTell.Name = "colCustomerTell";
            this.colCustomerTell.Visible = true;
            this.colCustomerTell.VisibleIndex = 6;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerAddress.AppearanceCell.Options.UseFont = true;
            this.colCustomerAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colCustomerAddress.AppearanceHeader.Options.UseFont = true;
            this.colCustomerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.Caption = "آدرس";
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 14;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "شرح فاکتور";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 15;
            // 
            // colPrintStatelbl
            // 
            this.colPrintStatelbl.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colPrintStatelbl.AppearanceCell.Options.UseFont = true;
            this.colPrintStatelbl.AppearanceCell.Options.UseTextOptions = true;
            this.colPrintStatelbl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrintStatelbl.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colPrintStatelbl.AppearanceHeader.Options.UseFont = true;
            this.colPrintStatelbl.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrintStatelbl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrintStatelbl.Caption = "چاپ";
            this.colPrintStatelbl.FieldName = "PrintStatelbl";
            this.colPrintStatelbl.Name = "colPrintStatelbl";
            this.colPrintStatelbl.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PrintStatelbl", "{0}")});
            this.colPrintStatelbl.Visible = true;
            this.colPrintStatelbl.VisibleIndex = 1;
            // 
            // colSaleDateSH
            // 
            this.colSaleDateSH.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleDateSH.AppearanceCell.Options.UseFont = true;
            this.colSaleDateSH.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleDateSH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleDateSH.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colSaleDateSH.AppearanceHeader.Options.UseFont = true;
            this.colSaleDateSH.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleDateSH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleDateSH.Caption = "تاریخ سفارش";
            this.colSaleDateSH.FieldName = "SaleDateSH";
            this.colSaleDateSH.Name = "colSaleDateSH";
            this.colSaleDateSH.Visible = true;
            this.colSaleDateSH.VisibleIndex = 3;
            // 
            // colStateFact
            // 
            this.colStateFact.AppearanceCell.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colStateFact.AppearanceCell.Options.UseFont = true;
            this.colStateFact.AppearanceCell.Options.UseTextOptions = true;
            this.colStateFact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStateFact.AppearanceHeader.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.25F);
            this.colStateFact.AppearanceHeader.Options.UseFont = true;
            this.colStateFact.AppearanceHeader.Options.UseTextOptions = true;
            this.colStateFact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStateFact.Caption = "وضعیت فاکتور";
            this.colStateFact.FieldName = "StateFact";
            this.colStateFact.Name = "colStateFact";
            this.colStateFact.Visible = true;
            this.colStateFact.VisibleIndex = 8;
            // 
            // colStateDelivery
            // 
            this.colStateDelivery.FieldName = "StateDelivery";
            this.colStateDelivery.MaxWidth = 10;
            this.colStateDelivery.MinWidth = 10;
            this.colStateDelivery.Name = "colStateDelivery";
            this.colStateDelivery.Width = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1240, 315);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1220, 295);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmOnlineSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 485);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOnlineSale";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "فروش انلاین";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOnlineSale_FormClosing);
            this.Load += new System.EventHandler(this.frmOnlineSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleFoodReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleFoodIDFact;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFish;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSumPriceBase;
        private DevExpress.XtraGrid.Columns.GridColumn colSumNet;
        private DevExpress.XtraGrid.Columns.GridColumn colSumDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumNetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTell;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource saleFoodReportBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintStatelbl;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDateSH;
        private DevExpress.XtraGrid.Columns.GridColumn colStateFact;
        private DevExpress.XtraGrid.Columns.GridColumn colStateDelivery;
        private DevExpress.XtraBars.BarSubItem btnprint;
        private DevExpress.XtraBars.BarButtonItem btnPrintCustomer;
        private DevExpress.XtraBars.BarButtonItem btnPrintKitchen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnAllPrint;
        private DevExpress.XtraBars.BarButtonItem btnShowSaleDetaile;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarHeaderItem lblCountNew;
        private DevExpress.XtraBars.BarHeaderItem lblCountCanceled;
        private DevExpress.XtraBars.BarHeaderItem lblCountEdit;
        private DevExpress.XtraBars.BarButtonItem lblVersion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
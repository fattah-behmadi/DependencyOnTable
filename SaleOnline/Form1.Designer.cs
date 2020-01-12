namespace SaleOnline
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.saleFoodOnlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleFoodIDFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colPrintState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleFoodOnlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.saleFoodOnlineBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 112);
            this.gridControl1.MainView = this.grd;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1070, 342);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd});
            // 
            // saleFoodOnlineBindingSource
            // 
            this.saleFoodOnlineBindingSource.DataSource = typeof(ModeData.ModelDomain.SaleFoodOnline);
            // 
            // grd
            // 
            this.grd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSaleFoodIDFact,
            this.colNumFish,
            this.colSaleDate,
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
            this.colPrintState,
            this.colStateDelivery,
            this.colDescription});
            this.grd.GridControl = this.gridControl1;
            this.grd.Name = "grd";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSaleFoodIDFact
            // 
            this.colSaleFoodIDFact.FieldName = "SaleFoodIDFact";
            this.colSaleFoodIDFact.Name = "colSaleFoodIDFact";
            this.colSaleFoodIDFact.Visible = true;
            this.colSaleFoodIDFact.VisibleIndex = 1;
            // 
            // colNumFish
            // 
            this.colNumFish.FieldName = "NumFish";
            this.colNumFish.Name = "colNumFish";
            this.colNumFish.Visible = true;
            this.colNumFish.VisibleIndex = 2;
            // 
            // colSaleDate
            // 
            this.colSaleDate.FieldName = "SaleDate";
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.Visible = true;
            this.colSaleDate.VisibleIndex = 3;
            // 
            // colSaleTime
            // 
            this.colSaleTime.FieldName = "SaleTime";
            this.colSaleTime.Name = "colSaleTime";
            this.colSaleTime.Visible = true;
            this.colSaleTime.VisibleIndex = 4;
            // 
            // colSumPriceBase
            // 
            this.colSumPriceBase.FieldName = "SumPriceBase";
            this.colSumPriceBase.Name = "colSumPriceBase";
            this.colSumPriceBase.Visible = true;
            this.colSumPriceBase.VisibleIndex = 5;
            // 
            // colSumNet
            // 
            this.colSumNet.FieldName = "SumNet";
            this.colSumNet.Name = "colSumNet";
            this.colSumNet.Visible = true;
            this.colSumNet.VisibleIndex = 6;
            // 
            // colSumDiscount
            // 
            this.colSumDiscount.FieldName = "SumDiscount";
            this.colSumDiscount.Name = "colSumDiscount";
            this.colSumDiscount.Visible = true;
            this.colSumDiscount.VisibleIndex = 7;
            // 
            // colSumNetPrice
            // 
            this.colSumNetPrice.FieldName = "SumNetPrice";
            this.colSumNetPrice.Name = "colSumNetPrice";
            this.colSumNetPrice.Visible = true;
            this.colSumNetPrice.VisibleIndex = 8;
            // 
            // colSumPrice
            // 
            this.colSumPrice.FieldName = "SumPrice";
            this.colSumPrice.Name = "colSumPrice";
            this.colSumPrice.Visible = true;
            this.colSumPrice.VisibleIndex = 9;
            // 
            // colTypeFactor
            // 
            this.colTypeFactor.FieldName = "TypeFactor";
            this.colTypeFactor.Name = "colTypeFactor";
            this.colTypeFactor.Visible = true;
            this.colTypeFactor.VisibleIndex = 10;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 11;
            // 
            // colCustomerTell
            // 
            this.colCustomerTell.FieldName = "CustomerTell";
            this.colCustomerTell.Name = "colCustomerTell";
            this.colCustomerTell.Visible = true;
            this.colCustomerTell.VisibleIndex = 12;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 13;
            // 
            // colPrintState
            // 
            this.colPrintState.FieldName = "PrintState";
            this.colPrintState.Name = "colPrintState";
            this.colPrintState.Visible = true;
            this.colPrintState.VisibleIndex = 14;
            // 
            // colStateDelivery
            // 
            this.colStateDelivery.FieldName = "StateDelivery";
            this.colStateDelivery.Name = "colStateDelivery";
            this.colStateDelivery.Visible = true;
            this.colStateDelivery.VisibleIndex = 15;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(417, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(281, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleFoodOnlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private System.Windows.Forms.BindingSource saleFoodOnlineBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleFoodIDFact;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFish;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDate;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPrintState;
        private DevExpress.XtraGrid.Columns.GridColumn colStateDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.Button button1;
    }
}


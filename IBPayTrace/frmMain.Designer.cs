namespace IBPayTrace
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDownloadCustomers = new C1.Win.C1Input.C1Button();
            this.grdCustomers = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.txtAccessToken = new C1.Win.C1Input.C1TextBox();
            this.cmdGetToken = new C1.Win.C1Input.C1Button();
            this.cmdGetInvoicesForTheDay = new C1.Win.C1Input.C1Button();
            this.btnProcessInvoices = new C1.Win.C1Input.C1Button();
            this.dtInvoiceDate = new C1.Win.Calendar.C1DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccessToken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGetToken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGetInvoicesForTheDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadCustomers
            // 
            this.btnDownloadCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadCustomers.Location = new System.Drawing.Point(585, 43);
            this.btnDownloadCustomers.Name = "btnDownloadCustomers";
            this.btnDownloadCustomers.Size = new System.Drawing.Size(200, 25);
            this.btnDownloadCustomers.TabIndex = 0;
            this.btnDownloadCustomers.Text = "Download Customers";
            this.btnDownloadCustomers.UseVisualStyleBackColor = true;
            this.btnDownloadCustomers.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btnDownloadCustomers.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btnDownloadCustomers.Click += new System.EventHandler(this.btnDownloadCustomers_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.grdCustomers.GroupByCaption = "Drag a column header here to group by that column";
            this.grdCustomers.Images.Add(((System.Drawing.Image)(resources.GetObject("grdCustomers.Images"))));
            this.grdCustomers.Location = new System.Drawing.Point(10, 105);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdCustomers.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdCustomers.PreviewInfo.ZoomFactor = 75D;
            this.grdCustomers.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.grdCustomers.PrintInfo.MeasurementPrinterName = null;
            this.grdCustomers.Size = new System.Drawing.Size(776, 354);
            this.grdCustomers.TabIndex = 1;
            this.grdCustomers.UseCompatibleTextRendering = false;
            this.grdCustomers.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdCustomers.PropBag = resources.GetString("grdCustomers.PropBag");
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(10, 600);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(775, 18);
            this.txtAccessToken.TabIndex = 2;
            this.txtAccessToken.Tag = null;
            // 
            // cmdGetToken
            // 
            this.cmdGetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetToken.Location = new System.Drawing.Point(585, 12);
            this.cmdGetToken.Name = "cmdGetToken";
            this.cmdGetToken.Size = new System.Drawing.Size(200, 25);
            this.cmdGetToken.TabIndex = 3;
            this.cmdGetToken.Text = "Get Token";
            this.cmdGetToken.UseVisualStyleBackColor = true;
            this.cmdGetToken.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.cmdGetToken.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.cmdGetToken.Click += new System.EventHandler(this.cmdGetToken_Click);
            // 
            // cmdGetInvoicesForTheDay
            // 
            this.cmdGetInvoicesForTheDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetInvoicesForTheDay.Location = new System.Drawing.Point(585, 74);
            this.cmdGetInvoicesForTheDay.Name = "cmdGetInvoicesForTheDay";
            this.cmdGetInvoicesForTheDay.Size = new System.Drawing.Size(200, 25);
            this.cmdGetInvoicesForTheDay.TabIndex = 4;
            this.cmdGetInvoicesForTheDay.Text = "Get invoices for the day";
            this.cmdGetInvoicesForTheDay.UseVisualStyleBackColor = true;
            this.cmdGetInvoicesForTheDay.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.cmdGetInvoicesForTheDay.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.cmdGetInvoicesForTheDay.Click += new System.EventHandler(this.cmdGetInvoicesForTheDay_Click);
            // 
            // btnProcessInvoices
            // 
            this.btnProcessInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessInvoices.Location = new System.Drawing.Point(10, 10);
            this.btnProcessInvoices.Name = "btnProcessInvoices";
            this.btnProcessInvoices.Size = new System.Drawing.Size(200, 25);
            this.btnProcessInvoices.TabIndex = 5;
            this.btnProcessInvoices.Text = "Process Invoices";
            this.btnProcessInvoices.UseVisualStyleBackColor = true;
            this.btnProcessInvoices.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btnProcessInvoices.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.btnProcessInvoices.Click += new System.EventHandler(this.btnProcessInvoices_Click);
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtInvoiceDate.Calendar.ClearText = "&Clear";
            this.dtInvoiceDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtInvoiceDate.Calendar.TodayText = "&Today";
            this.dtInvoiceDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtInvoiceDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInvoiceDate.GapHeight = 0;
            this.dtInvoiceDate.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtInvoiceDate.Location = new System.Drawing.Point(216, 12);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtInvoiceDate.TabIndex = 6;
            this.dtInvoiceDate.Tag = null;
            this.dtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 631);
            this.Controls.Add(this.dtInvoiceDate);
            this.Controls.Add(this.btnProcessInvoices);
            this.Controls.Add(this.cmdGetInvoicesForTheDay);
            this.Controls.Add(this.cmdGetToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnDownloadCustomers);
            this.Name = "frmMain";
            this.Text = "Indoor Billboad - PayTrace Interface ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccessToken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGetToken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGetInvoicesForTheDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button btnDownloadCustomers;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdCustomers;
        private C1.Win.C1Input.C1TextBox txtAccessToken;
        private C1.Win.C1Input.C1Button cmdGetToken;
        private C1.Win.C1Input.C1Button cmdGetInvoicesForTheDay;
        private C1.Win.C1Input.C1Button btnProcessInvoices;
        private C1.Win.Calendar.C1DateEdit dtInvoiceDate;
    }
}


using System.Windows.Forms;
using Kiwi.Tpv.Database.DTOs;

namespace Kiwi.Tpv.App.Forms
{
    partial class FrmHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.cbReports = new MetroFramework.Controls.MetroComboBox();
            this.btnCalculate = new MetroFramework.Controls.MetroTile();
            this.dtpEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtpInitDate = new MetroFramework.Controls.MetroDateTime();
            this.chkAllStations = new MetroFramework.Controls.MetroCheckBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.listBoxStations = new System.Windows.Forms.ListBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.btnOpenCashDrawer = new MetroFramework.Controls.MetroTile();
            this.btnExportExcel = new MetroFramework.Controls.MetroTile();
            this.TabHistory = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageFilters = new MetroFramework.Controls.MetroTabPage();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpInitTime = new System.Windows.Forms.DateTimePicker();
            this.spinnerProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageResults = new MetroFramework.Controls.MetroTabPage();
            this.txtTotalReal = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalCreditCard = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalCash = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalLogic = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalInvited = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalDisscount = new MetroFramework.Controls.MetroTile();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewEmployees = new MetroFramework.Controls.MetroGrid();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInvited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDisscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeHistoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewProducts = new MetroFramework.Controls.MetroGrid();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBottlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productHistoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.TabHistory.SuspendLayout();
            this.metroTabPageFilters.SuspendLayout();
            this.metroTabPageResults.SuspendLayout();
            this.txtTotalReal.SuspendLayout();
            this.txtTotalCreditCard.SuspendLayout();
            this.txtTotalCash.SuspendLayout();
            this.txtTotalLogic.SuspendLayout();
            this.txtTotalInvited.SuspendLayout();
            this.txtTotalDisscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeHistoryDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbReports
            // 
            this.cbReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReports.FormattingEnabled = true;
            this.cbReports.ItemHeight = 23;
            this.cbReports.Location = new System.Drawing.Point(366, 358);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(346, 29);
            this.cbReports.TabIndex = 58;
            this.cbReports.UseSelectable = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ActiveControl = null;
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnCalculate.Location = new System.Drawing.Point(552, 627);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(447, 59);
            this.btnCalculate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCalculate.UseSelectable = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(366, 135);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(246, 29);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitDate.Location = new System.Drawing.Point(366, 82);
            this.dtpInitDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(246, 29);
            this.dtpInitDate.TabIndex = 0;
            // 
            // chkAllStations
            // 
            this.chkAllStations.AutoSize = true;
            this.chkAllStations.Location = new System.Drawing.Point(366, 304);
            this.chkAllStations.Name = "chkAllStations";
            this.chkAllStations.Size = new System.Drawing.Size(54, 15);
            this.chkAllStations.TabIndex = 6;
            this.chkAllStations.Text = "Todas";
            this.chkAllStations.UseSelectable = true;
            this.chkAllStations.CheckedChanged += new System.EventHandler(this.chkAllStations_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // listBoxStations
            // 
            this.listBoxStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.listBoxStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStations.ItemHeight = 15;
            this.listBoxStations.Location = new System.Drawing.Point(366, 189);
            this.listBoxStations.Name = "listBoxStations";
            this.listBoxStations.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStations.Size = new System.Drawing.Size(346, 109);
            this.listBoxStations.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // btnOpenCashDrawer
            // 
            this.btnOpenCashDrawer.ActiveControl = null;
            this.btnOpenCashDrawer.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenCashDrawer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnOpenCashDrawer.Location = new System.Drawing.Point(23, 627);
            this.btnOpenCashDrawer.Name = "btnOpenCashDrawer";
            this.btnOpenCashDrawer.Size = new System.Drawing.Size(523, 59);
            this.btnOpenCashDrawer.Style = MetroFramework.MetroColorStyle.Red;
            this.btnOpenCashDrawer.TabIndex = 7;
            this.btnOpenCashDrawer.Text = "Abrir caja";
            this.btnOpenCashDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenCashDrawer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnOpenCashDrawer.UseSelectable = true;
            this.btnOpenCashDrawer.Click += new System.EventHandler(this.btnOpenCashDrawer_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.ActiveControl = null;
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnExportExcel.Location = new System.Drawing.Point(3, 463);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(148, 44);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseSelectable = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // TabHistory
            // 
            this.TabHistory.Controls.Add(this.metroTabPageFilters);
            this.TabHistory.Controls.Add(this.metroTabPageResults);
            this.TabHistory.Location = new System.Drawing.Point(23, 69);
            this.TabHistory.Name = "TabHistory";
            this.TabHistory.SelectedIndex = 0;
            this.TabHistory.Size = new System.Drawing.Size(976, 552);
            this.TabHistory.TabIndex = 59;
            this.TabHistory.UseSelectable = true;
            // 
            // metroTabPageFilters
            // 
            this.metroTabPageFilters.Controls.Add(this.dtpEndTime);
            this.metroTabPageFilters.Controls.Add(this.dtpInitTime);
            this.metroTabPageFilters.Controls.Add(this.spinnerProgress);
            this.metroTabPageFilters.Controls.Add(this.metroLabel3);
            this.metroTabPageFilters.Controls.Add(this.metroLabel2);
            this.metroTabPageFilters.Controls.Add(this.metroLabel1);
            this.metroTabPageFilters.Controls.Add(this.cbReports);
            this.metroTabPageFilters.Controls.Add(this.listBoxStations);
            this.metroTabPageFilters.Controls.Add(this.label2);
            this.metroTabPageFilters.Controls.Add(this.dtpEndDate);
            this.metroTabPageFilters.Controls.Add(this.label1);
            this.metroTabPageFilters.Controls.Add(this.chkAllStations);
            this.metroTabPageFilters.Controls.Add(this.dtpInitDate);
            this.metroTabPageFilters.HorizontalScrollbarBarColor = true;
            this.metroTabPageFilters.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageFilters.HorizontalScrollbarSize = 10;
            this.metroTabPageFilters.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageFilters.Name = "metroTabPageFilters";
            this.metroTabPageFilters.Size = new System.Drawing.Size(968, 510);
            this.metroTabPageFilters.TabIndex = 0;
            this.metroTabPageFilters.Text = "Filtros";
            this.metroTabPageFilters.VerticalScrollbarBarColor = true;
            this.metroTabPageFilters.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageFilters.VerticalScrollbarSize = 10;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(618, 135);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(94, 29);
            this.dtpEndTime.TabIndex = 64;
            // 
            // dtpInitTime
            // 
            this.dtpInitTime.CustomFormat = "HH:mm";
            this.dtpInitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInitTime.Location = new System.Drawing.Point(618, 82);
            this.dtpInitTime.Name = "dtpInitTime";
            this.dtpInitTime.ShowUpDown = true;
            this.dtpInitTime.Size = new System.Drawing.Size(94, 29);
            this.dtpInitTime.TabIndex = 63;
            // 
            // spinnerProgress
            // 
            this.spinnerProgress.Location = new System.Drawing.Point(944, 16);
            this.spinnerProgress.Maximum = 100;
            this.spinnerProgress.Name = "spinnerProgress";
            this.spinnerProgress.Size = new System.Drawing.Size(101, 95);
            this.spinnerProgress.TabIndex = 62;
            this.spinnerProgress.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(170, 358);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Selecciona informe";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(170, 189);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "Selecciona cajas";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(170, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "Selecciona fechas ";
            // 
            // metroTabPageResults
            // 
            this.metroTabPageResults.Controls.Add(this.btnExportExcel);
            this.metroTabPageResults.Controls.Add(this.txtTotalReal);
            this.metroTabPageResults.Controls.Add(this.txtTotalCreditCard);
            this.metroTabPageResults.Controls.Add(this.txtTotalCash);
            this.metroTabPageResults.Controls.Add(this.txtTotalLogic);
            this.metroTabPageResults.Controls.Add(this.txtTotalInvited);
            this.metroTabPageResults.Controls.Add(this.txtTotalDisscount);
            this.metroTabPageResults.Controls.Add(this.dataGridViewEmployees);
            this.metroTabPageResults.Controls.Add(this.DataGridViewProducts);
            this.metroTabPageResults.HorizontalScrollbarBarColor = true;
            this.metroTabPageResults.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageResults.HorizontalScrollbarSize = 10;
            this.metroTabPageResults.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageResults.Name = "metroTabPageResults";
            this.metroTabPageResults.Size = new System.Drawing.Size(968, 510);
            this.metroTabPageResults.TabIndex = 1;
            this.metroTabPageResults.Text = "Resultados";
            this.metroTabPageResults.VerticalScrollbarBarColor = true;
            this.metroTabPageResults.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageResults.VerticalScrollbarSize = 10;
            // 
            // txtTotalReal
            // 
            this.txtTotalReal.ActiveControl = null;
            this.txtTotalReal.Controls.Add(this.metroLabel8);
            this.txtTotalReal.Location = new System.Drawing.Point(838, 7);
            this.txtTotalReal.Name = "txtTotalReal";
            this.txtTotalReal.Size = new System.Drawing.Size(126, 71);
            this.txtTotalReal.Style = MetroFramework.MetroColorStyle.Green;
            this.txtTotalReal.TabIndex = 25;
            this.txtTotalReal.Text = "0 €";
            this.txtTotalReal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalReal.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(0, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Facturación Total";
            // 
            // txtTotalCreditCard
            // 
            this.txtTotalCreditCard.ActiveControl = null;
            this.txtTotalCreditCard.Controls.Add(this.metroLabel7);
            this.txtTotalCreditCard.Location = new System.Drawing.Point(679, 7);
            this.txtTotalCreditCard.Name = "txtTotalCreditCard";
            this.txtTotalCreditCard.Size = new System.Drawing.Size(153, 52);
            this.txtTotalCreditCard.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalCreditCard.TabIndex = 24;
            this.txtTotalCreditCard.Text = "0 €";
            this.txtTotalCreditCard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalCreditCard.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(122, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Facturación Tarjeta";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.ActiveControl = null;
            this.txtTotalCash.Controls.Add(this.metroLabel6);
            this.txtTotalCash.Location = new System.Drawing.Point(520, 7);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(153, 52);
            this.txtTotalCash.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtTotalCash.TabIndex = 23;
            this.txtTotalCash.Text = "0 €";
            this.txtTotalCash.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalCash.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(130, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Facturación Efectivo";
            // 
            // txtTotalLogic
            // 
            this.txtTotalLogic.ActiveControl = null;
            this.txtTotalLogic.Controls.Add(this.metroLabel5);
            this.txtTotalLogic.Location = new System.Drawing.Point(3, 7);
            this.txtTotalLogic.Name = "txtTotalLogic";
            this.txtTotalLogic.Size = new System.Drawing.Size(134, 52);
            this.txtTotalLogic.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtTotalLogic.TabIndex = 22;
            this.txtTotalLogic.Text = "0 €";
            this.txtTotalLogic.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalLogic.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Facturación Lógica";
            // 
            // txtTotalInvited
            // 
            this.txtTotalInvited.ActiveControl = null;
            this.txtTotalInvited.Controls.Add(this.metroLabel4);
            this.txtTotalInvited.Location = new System.Drawing.Point(283, 7);
            this.txtTotalInvited.Name = "txtTotalInvited";
            this.txtTotalInvited.Size = new System.Drawing.Size(134, 52);
            this.txtTotalInvited.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTotalInvited.TabIndex = 21;
            this.txtTotalInvited.Text = "0 €";
            this.txtTotalInvited.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalInvited.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Invitado";
            // 
            // txtTotalDisscount
            // 
            this.txtTotalDisscount.ActiveControl = null;
            this.txtTotalDisscount.Controls.Add(this.label7);
            this.txtTotalDisscount.Location = new System.Drawing.Point(143, 7);
            this.txtTotalDisscount.Name = "txtTotalDisscount";
            this.txtTotalDisscount.Size = new System.Drawing.Size(134, 52);
            this.txtTotalDisscount.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtTotalDisscount.TabIndex = 20;
            this.txtTotalDisscount.Text = "0 €";
            this.txtTotalDisscount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalDisscount.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.Style = MetroFramework.MetroColorStyle.Orange;
            this.label7.TabIndex = 12;
            this.label7.Text = "Descuentos";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToResizeColumns = false;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeDataGridViewTextBoxColumn,
            this.TotalInvited,
            this.totalDisscountDataGridViewTextBoxColumn,
            this.totalRealDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.employeeHistoryDtoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployees.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 288);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEmployees.RowTemplate.Height = 20;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(964, 171);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TotalInvited
            // 
            this.TotalInvited.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalInvited.DataPropertyName = "TotalInvited";
            this.TotalInvited.HeaderText = "Invitado (€)";
            this.TotalInvited.Name = "TotalInvited";
            this.TotalInvited.ReadOnly = true;
            // 
            // totalDisscountDataGridViewTextBoxColumn
            // 
            this.totalDisscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDisscountDataGridViewTextBoxColumn.DataPropertyName = "TotalDisscount";
            this.totalDisscountDataGridViewTextBoxColumn.HeaderText = "Descuentos (€)";
            this.totalDisscountDataGridViewTextBoxColumn.Name = "totalDisscountDataGridViewTextBoxColumn";
            this.totalDisscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalRealDataGridViewTextBoxColumn
            // 
            this.totalRealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalRealDataGridViewTextBoxColumn.DataPropertyName = "TotalReal";
            this.totalRealDataGridViewTextBoxColumn.HeaderText = "Facturación Real (€)";
            this.totalRealDataGridViewTextBoxColumn.Name = "totalRealDataGridViewTextBoxColumn";
            this.totalRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeHistoryDtoBindingSource
            // 
            this.employeeHistoryDtoBindingSource.DataSource = typeof(Kiwi.Tpv.Database.DTOs.EmployeeHistoryDto);
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToAddRows = false;
            this.DataGridViewProducts.AllowUserToDeleteRows = false;
            this.DataGridViewProducts.AllowUserToResizeColumns = false;
            this.DataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewProducts.AutoGenerateColumns = false;
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.totalQuantityDataGridViewTextBoxColumn,
            this.totalBottlesDataGridViewTextBoxColumn});
            this.DataGridViewProducts.DataSource = this.productHistoryDtoBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewProducts.EnableHeadersVisualStyles = false;
            this.DataGridViewProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewProducts.Location = new System.Drawing.Point(0, 91);
            this.DataGridViewProducts.MultiSelect = false;
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewProducts.RowHeadersVisible = false;
            this.DataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewProducts.RowTemplate.Height = 20;
            this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProducts.Size = new System.Drawing.Size(964, 190);
            this.DataGridViewProducts.TabIndex = 3;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            this.totalQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "TotalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            this.totalQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBottlesDataGridViewTextBoxColumn
            // 
            this.totalBottlesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalBottlesDataGridViewTextBoxColumn.DataPropertyName = "TotalBottles";
            this.totalBottlesDataGridViewTextBoxColumn.HeaderText = "Botellas";
            this.totalBottlesDataGridViewTextBoxColumn.Name = "totalBottlesDataGridViewTextBoxColumn";
            this.totalBottlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productHistoryDtoBindingSource
            // 
            this.productHistoryDtoBindingSource.DataSource = typeof(Kiwi.Tpv.Database.DTOs.ProductHistoryDto);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(908, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 60;
            this.btnClose.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClose.TileImage")));
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TabHistory);
            this.Controls.Add(this.btnOpenCashDrawer);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmHistory";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            this.TabHistory.ResumeLayout(false);
            this.metroTabPageFilters.ResumeLayout(false);
            this.metroTabPageFilters.PerformLayout();
            this.metroTabPageResults.ResumeLayout(false);
            this.txtTotalReal.ResumeLayout(false);
            this.txtTotalReal.PerformLayout();
            this.txtTotalCreditCard.ResumeLayout(false);
            this.txtTotalCreditCard.PerformLayout();
            this.txtTotalCash.ResumeLayout(false);
            this.txtTotalCash.PerformLayout();
            this.txtTotalLogic.ResumeLayout(false);
            this.txtTotalLogic.PerformLayout();
            this.txtTotalInvited.ResumeLayout(false);
            this.txtTotalInvited.PerformLayout();
            this.txtTotalDisscount.ResumeLayout(false);
            this.txtTotalDisscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeHistoryDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroDateTime dtpEndDate;
        private MetroFramework.Controls.MetroDateTime dtpInitDate;
        private MetroFramework.Controls.MetroCheckBox chkAllStations;
        private System.Windows.Forms.ListBox listBoxStations;
        private System.Windows.Forms.BindingSource productHistoryDtoBindingSource;
        private System.Windows.Forms.BindingSource employeeHistoryDtoBindingSource;
        private MetroFramework.Controls.MetroTile btnOpenCashDrawer;
        private MetroFramework.Controls.MetroTile btnExportExcel;
        private MetroFramework.Controls.MetroComboBox cbReports;
        private MetroFramework.Controls.MetroTabControl TabHistory;
        private MetroFramework.Controls.MetroTabPage metroTabPageFilters;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPageResults;
        private MetroFramework.Controls.MetroTile txtTotalReal;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile txtTotalCreditCard;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile txtTotalCash;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile txtTotalLogic;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile txtTotalInvited;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile txtTotalDisscount;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroGrid dataGridViewEmployees;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalInvited;
        private DataGridViewTextBoxColumn totalDisscountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalRealDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid DataGridViewProducts;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalBottlesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile btnCalculate;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroProgressSpinner spinnerProgress;
        private DateTimePicker dtpInitTime;
        private DateTimePicker dtpEndTime;
    }
}
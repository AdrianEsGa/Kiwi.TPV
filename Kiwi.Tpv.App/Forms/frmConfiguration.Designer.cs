using System.Windows.Forms;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App.Forms
{
    partial class FrmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguration));
            this.tabConfig = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cmbServerStation = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnDbBackupFilePath = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDbBackupFilePath = new MetroFramework.Controls.MetroTextBox();
            this.txtTableButtonsDimensions = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkShowJokeReport = new System.Windows.Forms.CheckBox();
            this.label11 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.txtAdminPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnOpenBackImage = new MetroFramework.Controls.MetroTile();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.TxtBackImagePath = new MetroFramework.Controls.MetroTextBox();
            this.txtProductButtonsDimension = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployeeButtonsDimension = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.chkCombinationControlWithSoda = new System.Windows.Forms.CheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BtnSelectReportTicket = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtTicketReport = new MetroFramework.Controls.MetroTextBox();
            this.btnRemoveCompanyLocalImage = new MetroFramework.Controls.MetroTile();
            this.picBoxReportsLocalImage = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSelectCompanyLocalImage = new MetroFramework.Controls.MetroTile();
            this.chkCombinationControl = new System.Windows.Forms.CheckBox();
            this.label12 = new MetroFramework.Controls.MetroLabel();
            this.btnRemoveCompanyReportsLogo = new MetroFramework.Controls.MetroTile();
            this.picBoxReportsLogo = new System.Windows.Forms.PictureBox();
            this.btnRemoveCompanyAppLogo = new MetroFramework.Controls.MetroTile();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.TxtCompanyName = new MetroFramework.Controls.MetroTextBox();
            this.picBoxAppLogo = new System.Windows.Forms.PictureBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.txtCompanyCif = new MetroFramework.Controls.MetroTextBox();
            this.btnSelectCompanyReportsLogo = new MetroFramework.Controls.MetroTile();
            this.btnSelectCompanyAppLogo = new MetroFramework.Controls.MetroTile();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.chkShowSaleOrderTicket = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtActualStation = new MetroFramework.Controls.MetroTextBox();
            this.DataGridViewStations = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printterComPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.btnTestPrintter = new MetroFramework.Controls.MetroTile();
            this.cbPrinter = new MetroFramework.Controls.MetroComboBox();
            this.btnOpenBox = new MetroFramework.Controls.MetroTile();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnVer = new MetroFramework.Controls.MetroTile();
            this.btnLoadJokeImage = new MetroFramework.Controls.MetroTile();
            this.btnJokeImage = new MetroFramework.Controls.MetroTile();
            this.txtJokeImage = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.chkShowAnimations = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tabConfig.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReportsLocalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReportsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppLogo)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.metroTabPage1);
            this.tabConfig.Controls.Add(this.metroTabPage2);
            this.tabConfig.Controls.Add(this.metroTabPage3);
            this.tabConfig.Controls.Add(this.metroTabPage4);
            this.tabConfig.Location = new System.Drawing.Point(23, 69);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 2;
            this.tabConfig.Size = new System.Drawing.Size(856, 433);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cmbServerStation);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.btnDbBackupFilePath);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtDbBackupFilePath);
            this.metroTabPage1.Controls.Add(this.txtTableButtonsDimensions);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.chkShowJokeReport);
            this.metroTabPage1.Controls.Add(this.label11);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.txtAdminPassword);
            this.metroTabPage1.Controls.Add(this.btnOpenBackImage);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.TxtBackImagePath);
            this.metroTabPage1.Controls.Add(this.txtProductButtonsDimension);
            this.metroTabPage1.Controls.Add(this.txtEmployeeButtonsDimension);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(848, 391);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // cmbServerStation
            // 
            this.cmbServerStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cmbServerStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbServerStation.FormattingEnabled = true;
            this.cmbServerStation.ItemHeight = 23;
            this.cmbServerStation.Location = new System.Drawing.Point(232, 275);
            this.cmbServerStation.Name = "cmbServerStation";
            this.cmbServerStation.Size = new System.Drawing.Size(217, 29);
            this.cmbServerStation.TabIndex = 85;
            this.cmbServerStation.UseSelectable = true;
            this.cmbServerStation.SelectionChangeCommitted += new System.EventHandler(this.cmbServerStation_SelectionChangeCommitted);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 275);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(149, 19);
            this.metroLabel5.TabIndex = 84;
            this.metroLabel5.Text = "Punto de venta servidor";
            // 
            // btnDbBackupFilePath
            // 
            this.btnDbBackupFilePath.Location = new System.Drawing.Point(458, 310);
            this.btnDbBackupFilePath.Name = "btnDbBackupFilePath";
            this.btnDbBackupFilePath.Size = new System.Drawing.Size(26, 23);
            this.btnDbBackupFilePath.TabIndex = 83;
            this.btnDbBackupFilePath.UseSelectable = true;
            this.btnDbBackupFilePath.Click += new System.EventHandler(this.btnDbBackupFilePath_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 310);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(133, 19);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Ruta copia seguridad";
            // 
            // txtDbBackupFilePath
            // 
            // 
            // 
            // 
            this.txtDbBackupFilePath.CustomButton.Image = null;
            this.txtDbBackupFilePath.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtDbBackupFilePath.CustomButton.Name = "";
            this.txtDbBackupFilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDbBackupFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDbBackupFilePath.CustomButton.TabIndex = 1;
            this.txtDbBackupFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDbBackupFilePath.CustomButton.UseSelectable = true;
            this.txtDbBackupFilePath.CustomButton.Visible = false;
            this.txtDbBackupFilePath.Enabled = false;
            this.txtDbBackupFilePath.Lines = new string[0];
            this.txtDbBackupFilePath.Location = new System.Drawing.Point(232, 310);
            this.txtDbBackupFilePath.MaxLength = 32767;
            this.txtDbBackupFilePath.Name = "txtDbBackupFilePath";
            this.txtDbBackupFilePath.PasswordChar = '\0';
            this.txtDbBackupFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDbBackupFilePath.SelectedText = "";
            this.txtDbBackupFilePath.SelectionLength = 0;
            this.txtDbBackupFilePath.SelectionStart = 0;
            this.txtDbBackupFilePath.ShortcutsEnabled = true;
            this.txtDbBackupFilePath.Size = new System.Drawing.Size(220, 23);
            this.txtDbBackupFilePath.TabIndex = 81;
            this.txtDbBackupFilePath.UseSelectable = true;
            this.txtDbBackupFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDbBackupFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTableButtonsDimensions
            // 
            this.txtTableButtonsDimensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtTableButtonsDimensions.CustomButton.Image = null;
            this.txtTableButtonsDimensions.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.txtTableButtonsDimensions.CustomButton.Name = "";
            this.txtTableButtonsDimensions.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTableButtonsDimensions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTableButtonsDimensions.CustomButton.TabIndex = 1;
            this.txtTableButtonsDimensions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTableButtonsDimensions.CustomButton.UseSelectable = true;
            this.txtTableButtonsDimensions.CustomButton.Visible = false;
            this.txtTableButtonsDimensions.Lines = new string[0];
            this.txtTableButtonsDimensions.Location = new System.Drawing.Point(232, 137);
            this.txtTableButtonsDimensions.MaxLength = 32767;
            this.txtTableButtonsDimensions.Name = "txtTableButtonsDimensions";
            this.txtTableButtonsDimensions.PasswordChar = '\0';
            this.txtTableButtonsDimensions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTableButtonsDimensions.SelectedText = "";
            this.txtTableButtonsDimensions.SelectionLength = 0;
            this.txtTableButtonsDimensions.SelectionStart = 0;
            this.txtTableButtonsDimensions.ShortcutsEnabled = true;
            this.txtTableButtonsDimensions.Size = new System.Drawing.Size(185, 20);
            this.txtTableButtonsDimensions.TabIndex = 59;
            this.txtTableButtonsDimensions.UseSelectable = true;
            this.txtTableButtonsDimensions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTableButtonsDimensions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTableButtonsDimensions.Click += new System.EventHandler(this.txtTableButtonsDimensions_Click);
            this.txtTableButtonsDimensions.Validated += new System.EventHandler(this.txtTableButtonsDimensions_Validated);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(161, 19);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Dimensión Botones Mesas";
            // 
            // chkShowJokeReport
            // 
            this.chkShowJokeReport.AutoSize = true;
            this.chkShowJokeReport.Location = new System.Drawing.Point(232, 211);
            this.chkShowJokeReport.Name = "chkShowJokeReport";
            this.chkShowJokeReport.Size = new System.Drawing.Size(15, 14);
            this.chkShowJokeReport.TabIndex = 57;
            this.chkShowJokeReport.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 56;
            this.label11.Text = "Ver Informes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña Admin.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Imagen de fondo";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtAdminPassword.CustomButton.Image = null;
            this.txtAdminPassword.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.txtAdminPassword.CustomButton.Name = "";
            this.txtAdminPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAdminPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdminPassword.CustomButton.TabIndex = 1;
            this.txtAdminPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdminPassword.CustomButton.UseSelectable = true;
            this.txtAdminPassword.CustomButton.Visible = false;
            this.txtAdminPassword.Lines = new string[0];
            this.txtAdminPassword.Location = new System.Drawing.Point(232, 26);
            this.txtAdminPassword.MaxLength = 32767;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '\0';
            this.txtAdminPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminPassword.SelectedText = "";
            this.txtAdminPassword.SelectionLength = 0;
            this.txtAdminPassword.SelectionStart = 0;
            this.txtAdminPassword.ShortcutsEnabled = true;
            this.txtAdminPassword.Size = new System.Drawing.Size(185, 20);
            this.txtAdminPassword.TabIndex = 3;
            this.txtAdminPassword.UseSelectable = true;
            this.txtAdminPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdminPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdminPassword.Click += new System.EventHandler(this.txtAdminPassword_Click);
            this.txtAdminPassword.Validated += new System.EventHandler(this.txtAdminPassword_Validated);
            // 
            // btnOpenBackImage
            // 
            this.btnOpenBackImage.ActiveControl = null;
            this.btnOpenBackImage.Location = new System.Drawing.Point(559, 174);
            this.btnOpenBackImage.Name = "btnOpenBackImage";
            this.btnOpenBackImage.Size = new System.Drawing.Size(22, 20);
            this.btnOpenBackImage.TabIndex = 53;
            this.btnOpenBackImage.UseSelectable = true;
            this.btnOpenBackImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimensión Botones Productos";
            // 
            // TxtBackImagePath
            // 
            this.TxtBackImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtBackImagePath.CustomButton.Image = null;
            this.TxtBackImagePath.CustomButton.Location = new System.Drawing.Point(303, 2);
            this.TxtBackImagePath.CustomButton.Name = "";
            this.TxtBackImagePath.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtBackImagePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBackImagePath.CustomButton.TabIndex = 1;
            this.TxtBackImagePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBackImagePath.CustomButton.UseSelectable = true;
            this.TxtBackImagePath.CustomButton.Visible = false;
            this.TxtBackImagePath.Lines = new string[0];
            this.TxtBackImagePath.Location = new System.Drawing.Point(232, 174);
            this.TxtBackImagePath.MaxLength = 50;
            this.TxtBackImagePath.Name = "TxtBackImagePath";
            this.TxtBackImagePath.PasswordChar = '\0';
            this.TxtBackImagePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBackImagePath.SelectedText = "";
            this.TxtBackImagePath.SelectionLength = 0;
            this.TxtBackImagePath.SelectionStart = 0;
            this.TxtBackImagePath.ShortcutsEnabled = true;
            this.TxtBackImagePath.Size = new System.Drawing.Size(321, 20);
            this.TxtBackImagePath.TabIndex = 52;
            this.TxtBackImagePath.UseSelectable = true;
            this.TxtBackImagePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBackImagePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBackImagePath.Click += new System.EventHandler(this.TxtBackImagePath_Click);
            this.TxtBackImagePath.Validated += new System.EventHandler(this.TxtBackImagePath_Validated);
            // 
            // txtProductButtonsDimension
            // 
            this.txtProductButtonsDimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtProductButtonsDimension.CustomButton.Image = null;
            this.txtProductButtonsDimension.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.txtProductButtonsDimension.CustomButton.Name = "";
            this.txtProductButtonsDimension.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtProductButtonsDimension.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductButtonsDimension.CustomButton.TabIndex = 1;
            this.txtProductButtonsDimension.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductButtonsDimension.CustomButton.UseSelectable = true;
            this.txtProductButtonsDimension.CustomButton.Visible = false;
            this.txtProductButtonsDimension.Lines = new string[0];
            this.txtProductButtonsDimension.Location = new System.Drawing.Point(232, 63);
            this.txtProductButtonsDimension.MaxLength = 32767;
            this.txtProductButtonsDimension.Name = "txtProductButtonsDimension";
            this.txtProductButtonsDimension.PasswordChar = '\0';
            this.txtProductButtonsDimension.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductButtonsDimension.SelectedText = "";
            this.txtProductButtonsDimension.SelectionLength = 0;
            this.txtProductButtonsDimension.SelectionStart = 0;
            this.txtProductButtonsDimension.ShortcutsEnabled = true;
            this.txtProductButtonsDimension.Size = new System.Drawing.Size(185, 20);
            this.txtProductButtonsDimension.TabIndex = 5;
            this.txtProductButtonsDimension.UseSelectable = true;
            this.txtProductButtonsDimension.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductButtonsDimension.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductButtonsDimension.Click += new System.EventHandler(this.txtProductButtonsDimension_Click);
            this.txtProductButtonsDimension.Validated += new System.EventHandler(this.txtProductButtonsDimension_Validated);
            // 
            // txtEmployeeButtonsDimension
            // 
            this.txtEmployeeButtonsDimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtEmployeeButtonsDimension.CustomButton.Image = null;
            this.txtEmployeeButtonsDimension.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.txtEmployeeButtonsDimension.CustomButton.Name = "";
            this.txtEmployeeButtonsDimension.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtEmployeeButtonsDimension.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeButtonsDimension.CustomButton.TabIndex = 1;
            this.txtEmployeeButtonsDimension.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeButtonsDimension.CustomButton.UseSelectable = true;
            this.txtEmployeeButtonsDimension.CustomButton.Visible = false;
            this.txtEmployeeButtonsDimension.Lines = new string[0];
            this.txtEmployeeButtonsDimension.Location = new System.Drawing.Point(232, 100);
            this.txtEmployeeButtonsDimension.MaxLength = 32767;
            this.txtEmployeeButtonsDimension.Name = "txtEmployeeButtonsDimension";
            this.txtEmployeeButtonsDimension.PasswordChar = '\0';
            this.txtEmployeeButtonsDimension.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeButtonsDimension.SelectedText = "";
            this.txtEmployeeButtonsDimension.SelectionLength = 0;
            this.txtEmployeeButtonsDimension.SelectionStart = 0;
            this.txtEmployeeButtonsDimension.ShortcutsEnabled = true;
            this.txtEmployeeButtonsDimension.Size = new System.Drawing.Size(185, 20);
            this.txtEmployeeButtonsDimension.TabIndex = 7;
            this.txtEmployeeButtonsDimension.UseSelectable = true;
            this.txtEmployeeButtonsDimension.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeButtonsDimension.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeButtonsDimension.Click += new System.EventHandler(this.txtEmployeeButtonsDimension_Click);
            this.txtEmployeeButtonsDimension.Validated += new System.EventHandler(this.txtEmployeeButtonsDimension_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dimensión Botones Empleados";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.chkCombinationControlWithSoda);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.BtnSelectReportTicket);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TxtTicketReport);
            this.metroTabPage2.Controls.Add(this.btnRemoveCompanyLocalImage);
            this.metroTabPage2.Controls.Add(this.picBoxReportsLocalImage);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.btnSelectCompanyLocalImage);
            this.metroTabPage2.Controls.Add(this.chkCombinationControl);
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.btnRemoveCompanyReportsLogo);
            this.metroTabPage2.Controls.Add(this.picBoxReportsLogo);
            this.metroTabPage2.Controls.Add(this.btnRemoveCompanyAppLogo);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.TxtCompanyName);
            this.metroTabPage2.Controls.Add(this.picBoxAppLogo);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.txtCompanyCif);
            this.metroTabPage2.Controls.Add(this.btnSelectCompanyReportsLogo);
            this.metroTabPage2.Controls.Add(this.btnSelectCompanyAppLogo);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(848, 391);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Empresa";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // chkCombinationControlWithSoda
            // 
            this.chkCombinationControlWithSoda.AutoSize = true;
            this.chkCombinationControlWithSoda.Location = new System.Drawing.Point(427, 107);
            this.chkCombinationControlWithSoda.Name = "chkCombinationControlWithSoda";
            this.chkCombinationControlWithSoda.Size = new System.Drawing.Size(15, 14);
            this.chkCombinationControlWithSoda.TabIndex = 81;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(225, 102);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(196, 19);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Control combinados + Refresco";
            // 
            // BtnSelectReportTicket
            // 
            this.BtnSelectReportTicket.Location = new System.Drawing.Point(509, 140);
            this.BtnSelectReportTicket.Name = "BtnSelectReportTicket";
            this.BtnSelectReportTicket.Size = new System.Drawing.Size(26, 23);
            this.BtnSelectReportTicket.TabIndex = 79;
            this.BtnSelectReportTicket.UseSelectable = true;
            this.BtnSelectReportTicket.Click += new System.EventHandler(this.BtnSelectReportTicket_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Ticket";
            // 
            // TxtTicketReport
            // 
            this.TxtTicketReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtTicketReport.CustomButton.Image = null;
            this.TxtTicketReport.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.TxtTicketReport.CustomButton.Name = "";
            this.TxtTicketReport.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtTicketReport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTicketReport.CustomButton.TabIndex = 1;
            this.TxtTicketReport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTicketReport.CustomButton.UseSelectable = true;
            this.TxtTicketReport.CustomButton.Visible = false;
            this.TxtTicketReport.Lines = new string[0];
            this.TxtTicketReport.Location = new System.Drawing.Point(147, 141);
            this.TxtTicketReport.MaxLength = 10;
            this.TxtTicketReport.Name = "TxtTicketReport";
            this.TxtTicketReport.PasswordChar = '\0';
            this.TxtTicketReport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTicketReport.SelectedText = "";
            this.TxtTicketReport.SelectionLength = 0;
            this.TxtTicketReport.SelectionStart = 0;
            this.TxtTicketReport.ShortcutsEnabled = true;
            this.TxtTicketReport.Size = new System.Drawing.Size(355, 20);
            this.TxtTicketReport.TabIndex = 78;
            this.TxtTicketReport.UseSelectable = true;
            this.TxtTicketReport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTicketReport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTicketReport.Click += new System.EventHandler(this.TxtTicketReport_Click);
            this.TxtTicketReport.Validated += new System.EventHandler(this.TxtTicketReport_Validated);
            // 
            // btnRemoveCompanyLocalImage
            // 
            this.btnRemoveCompanyLocalImage.ActiveControl = null;
            this.btnRemoveCompanyLocalImage.Location = new System.Drawing.Point(541, 208);
            this.btnRemoveCompanyLocalImage.Name = "btnRemoveCompanyLocalImage";
            this.btnRemoveCompanyLocalImage.Size = new System.Drawing.Size(88, 38);
            this.btnRemoveCompanyLocalImage.TabIndex = 76;
            this.btnRemoveCompanyLocalImage.Text = "Eliminar";
            this.btnRemoveCompanyLocalImage.UseSelectable = true;
            this.btnRemoveCompanyLocalImage.Click += new System.EventHandler(this.btnRemoveCompanyLocalImage_Click);
            // 
            // picBoxReportsLocalImage
            // 
            this.picBoxReportsLocalImage.Location = new System.Drawing.Point(479, 252);
            this.picBoxReportsLocalImage.Name = "picBoxReportsLocalImage";
            this.picBoxReportsLocalImage.Size = new System.Drawing.Size(122, 96);
            this.picBoxReportsLocalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReportsLocalImage.TabIndex = 75;
            this.picBoxReportsLocalImage.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(447, 186);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 74;
            this.metroLabel1.Text = "Imagen local";
            // 
            // btnSelectCompanyLocalImage
            // 
            this.btnSelectCompanyLocalImage.ActiveControl = null;
            this.btnSelectCompanyLocalImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSelectCompanyLocalImage.Location = new System.Drawing.Point(447, 208);
            this.btnSelectCompanyLocalImage.Name = "btnSelectCompanyLocalImage";
            this.btnSelectCompanyLocalImage.Size = new System.Drawing.Size(88, 38);
            this.btnSelectCompanyLocalImage.TabIndex = 73;
            this.btnSelectCompanyLocalImage.Text = "Seleccionar";
            this.btnSelectCompanyLocalImage.UseSelectable = true;
            this.btnSelectCompanyLocalImage.Click += new System.EventHandler(this.btnSelectCompanyLocalImage_Click);
            // 
            // chkCombinationControl
            // 
            this.chkCombinationControl.AutoSize = true;
            this.chkCombinationControl.Location = new System.Drawing.Point(147, 107);
            this.chkCombinationControl.Name = "chkCombinationControl";
            this.chkCombinationControl.Size = new System.Drawing.Size(15, 14);
            this.chkCombinationControl.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Control combinados";
            // 
            // btnRemoveCompanyReportsLogo
            // 
            this.btnRemoveCompanyReportsLogo.ActiveControl = null;
            this.btnRemoveCompanyReportsLogo.Location = new System.Drawing.Point(319, 208);
            this.btnRemoveCompanyReportsLogo.Name = "btnRemoveCompanyReportsLogo";
            this.btnRemoveCompanyReportsLogo.Size = new System.Drawing.Size(88, 38);
            this.btnRemoveCompanyReportsLogo.TabIndex = 70;
            this.btnRemoveCompanyReportsLogo.Text = "Eliminar";
            this.btnRemoveCompanyReportsLogo.UseSelectable = true;
            this.btnRemoveCompanyReportsLogo.Click += new System.EventHandler(this.btnRemoveCompanyReportsLogo_Click);
            // 
            // picBoxReportsLogo
            // 
            this.picBoxReportsLogo.Location = new System.Drawing.Point(257, 252);
            this.picBoxReportsLogo.Name = "picBoxReportsLogo";
            this.picBoxReportsLogo.Size = new System.Drawing.Size(122, 96);
            this.picBoxReportsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReportsLogo.TabIndex = 68;
            this.picBoxReportsLogo.TabStop = false;
            // 
            // btnRemoveCompanyAppLogo
            // 
            this.btnRemoveCompanyAppLogo.ActiveControl = null;
            this.btnRemoveCompanyAppLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemoveCompanyAppLogo.Location = new System.Drawing.Point(98, 211);
            this.btnRemoveCompanyAppLogo.Name = "btnRemoveCompanyAppLogo";
            this.btnRemoveCompanyAppLogo.Size = new System.Drawing.Size(88, 35);
            this.btnRemoveCompanyAppLogo.TabIndex = 69;
            this.btnRemoveCompanyAppLogo.Text = "Eliminar";
            this.btnRemoveCompanyAppLogo.UseSelectable = true;
            this.btnRemoveCompanyAppLogo.Click += new System.EventHandler(this.btnRemoveCompanyAppLogo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nombre";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtCompanyName.CustomButton.Image = null;
            this.TxtCompanyName.CustomButton.Location = new System.Drawing.Point(468, 2);
            this.TxtCompanyName.CustomButton.Name = "";
            this.TxtCompanyName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCompanyName.CustomButton.TabIndex = 1;
            this.TxtCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCompanyName.CustomButton.UseSelectable = true;
            this.TxtCompanyName.CustomButton.Visible = false;
            this.TxtCompanyName.Lines = new string[0];
            this.TxtCompanyName.Location = new System.Drawing.Point(147, 27);
            this.TxtCompanyName.MaxLength = 50;
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.PasswordChar = '\0';
            this.TxtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCompanyName.SelectedText = "";
            this.TxtCompanyName.SelectionLength = 0;
            this.TxtCompanyName.SelectionStart = 0;
            this.TxtCompanyName.ShortcutsEnabled = true;
            this.TxtCompanyName.Size = new System.Drawing.Size(486, 20);
            this.TxtCompanyName.TabIndex = 56;
            this.TxtCompanyName.UseSelectable = true;
            this.TxtCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCompanyName.Click += new System.EventHandler(this.TxtCompanyName_Click);
            this.TxtCompanyName.Validated += new System.EventHandler(this.TxtCompanyName_Validated);
            // 
            // picBoxAppLogo
            // 
            this.picBoxAppLogo.Location = new System.Drawing.Point(36, 252);
            this.picBoxAppLogo.Name = "picBoxAppLogo";
            this.picBoxAppLogo.Size = new System.Drawing.Size(122, 96);
            this.picBoxAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAppLogo.TabIndex = 67;
            this.picBoxAppLogo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "Cif";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Logo Informes";
            // 
            // txtCompanyCif
            // 
            this.txtCompanyCif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtCompanyCif.CustomButton.Image = null;
            this.txtCompanyCif.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.txtCompanyCif.CustomButton.Name = "";
            this.txtCompanyCif.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCompanyCif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompanyCif.CustomButton.TabIndex = 1;
            this.txtCompanyCif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompanyCif.CustomButton.UseSelectable = true;
            this.txtCompanyCif.CustomButton.Visible = false;
            this.txtCompanyCif.Lines = new string[0];
            this.txtCompanyCif.Location = new System.Drawing.Point(147, 67);
            this.txtCompanyCif.MaxLength = 10;
            this.txtCompanyCif.Name = "txtCompanyCif";
            this.txtCompanyCif.PasswordChar = '\0';
            this.txtCompanyCif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyCif.SelectedText = "";
            this.txtCompanyCif.SelectionLength = 0;
            this.txtCompanyCif.SelectionStart = 0;
            this.txtCompanyCif.ShortcutsEnabled = true;
            this.txtCompanyCif.Size = new System.Drawing.Size(185, 20);
            this.txtCompanyCif.TabIndex = 58;
            this.txtCompanyCif.UseSelectable = true;
            this.txtCompanyCif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompanyCif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyCif.Click += new System.EventHandler(this.txtCompanyCif_Click);
            this.txtCompanyCif.Validated += new System.EventHandler(this.txtCompanyCif_Validated);
            // 
            // btnSelectCompanyReportsLogo
            // 
            this.btnSelectCompanyReportsLogo.ActiveControl = null;
            this.btnSelectCompanyReportsLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSelectCompanyReportsLogo.Location = new System.Drawing.Point(225, 208);
            this.btnSelectCompanyReportsLogo.Name = "btnSelectCompanyReportsLogo";
            this.btnSelectCompanyReportsLogo.Size = new System.Drawing.Size(88, 38);
            this.btnSelectCompanyReportsLogo.TabIndex = 65;
            this.btnSelectCompanyReportsLogo.Text = "Seleccionar";
            this.btnSelectCompanyReportsLogo.UseSelectable = true;
            this.btnSelectCompanyReportsLogo.Click += new System.EventHandler(this.btnSelectCompanyReportsLogo_Click);
            // 
            // btnSelectCompanyAppLogo
            // 
            this.btnSelectCompanyAppLogo.ActiveControl = null;
            this.btnSelectCompanyAppLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSelectCompanyAppLogo.Location = new System.Drawing.Point(4, 211);
            this.btnSelectCompanyAppLogo.Name = "btnSelectCompanyAppLogo";
            this.btnSelectCompanyAppLogo.Size = new System.Drawing.Size(88, 35);
            this.btnSelectCompanyAppLogo.TabIndex = 62;
            this.btnSelectCompanyAppLogo.Text = "Seleccionar";
            this.btnSelectCompanyAppLogo.UseSelectable = true;
            this.btnSelectCompanyAppLogo.Click += new System.EventHandler(this.btnSelectCompanyAppLogo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Logo App";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.chkShowAnimations);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.chkShowSaleOrderTicket);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.txtActualStation);
            this.metroTabPage3.Controls.Add(this.DataGridViewStations);
            this.metroTabPage3.Controls.Add(this.label3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(848, 391);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Puntos de venta";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // chkShowSaleOrderTicket
            // 
            this.chkShowSaleOrderTicket.AutoSize = true;
            this.chkShowSaleOrderTicket.Location = new System.Drawing.Point(160, 60);
            this.chkShowSaleOrderTicket.Name = "chkShowSaleOrderTicket";
            this.chkShowSaleOrderTicket.Size = new System.Drawing.Size(80, 17);
            this.chkShowSaleOrderTicket.TabIndex = 91;
            this.chkShowSaleOrderTicket.Text = "Off";
            this.chkShowSaleOrderTicket.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 58);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 73;
            this.metroLabel7.Text = "Ticket de pedido";
            // 
            // txtActualStation
            // 
            // 
            // 
            // 
            this.txtActualStation.CustomButton.Image = null;
            this.txtActualStation.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtActualStation.CustomButton.Name = "";
            this.txtActualStation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtActualStation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtActualStation.CustomButton.TabIndex = 1;
            this.txtActualStation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtActualStation.CustomButton.UseSelectable = true;
            this.txtActualStation.CustomButton.Visible = false;
            this.txtActualStation.Enabled = false;
            this.txtActualStation.Lines = new string[0];
            this.txtActualStation.Location = new System.Drawing.Point(160, 16);
            this.txtActualStation.MaxLength = 32767;
            this.txtActualStation.Name = "txtActualStation";
            this.txtActualStation.PasswordChar = '\0';
            this.txtActualStation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtActualStation.SelectedText = "";
            this.txtActualStation.SelectionLength = 0;
            this.txtActualStation.SelectionStart = 0;
            this.txtActualStation.ShortcutsEnabled = true;
            this.txtActualStation.Size = new System.Drawing.Size(220, 23);
            this.txtActualStation.TabIndex = 5;
            this.txtActualStation.UseSelectable = true;
            this.txtActualStation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtActualStation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DataGridViewStations
            // 
            this.DataGridViewStations.AllowUserToAddRows = false;
            this.DataGridViewStations.AllowUserToDeleteRows = false;
            this.DataGridViewStations.AllowUserToResizeColumns = false;
            this.DataGridViewStations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DataGridViewStations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewStations.AutoGenerateColumns = false;
            this.DataGridViewStations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DataGridViewStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewStations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridViewStations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.printterComPortDataGridViewTextBoxColumn});
            this.DataGridViewStations.DataSource = this.stationBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewStations.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewStations.EnableHeadersVisualStyles = false;
            this.DataGridViewStations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewStations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewStations.Location = new System.Drawing.Point(-4, 199);
            this.DataGridViewStations.MultiSelect = false;
            this.DataGridViewStations.Name = "DataGridViewStations";
            this.DataGridViewStations.ReadOnly = true;
            this.DataGridViewStations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewStations.RowHeadersVisible = false;
            this.DataGridViewStations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewStations.RowTemplate.Height = 20;
            this.DataGridViewStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStations.Size = new System.Drawing.Size(856, 189);
            this.DataGridViewStations.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printterComPortDataGridViewTextBoxColumn
            // 
            this.printterComPortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.printterComPortDataGridViewTextBoxColumn.DataPropertyName = "PrintterComPort";
            this.printterComPortDataGridViewTextBoxColumn.HeaderText = "Puerto COM";
            this.printterComPortDataGridViewTextBoxColumn.Name = "printterComPortDataGridViewTextBoxColumn";
            this.printterComPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.Station);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Punto de venta actual";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.btnTestPrintter);
            this.metroTabPage4.Controls.Add(this.cbPrinter);
            this.metroTabPage4.Controls.Add(this.btnOpenBox);
            this.metroTabPage4.Controls.Add(this.label4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(848, 391);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Caja y impresora";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // btnTestPrintter
            // 
            this.btnTestPrintter.ActiveControl = null;
            this.btnTestPrintter.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestPrintter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnTestPrintter.Location = new System.Drawing.Point(216, 89);
            this.btnTestPrintter.Name = "btnTestPrintter";
            this.btnTestPrintter.Size = new System.Drawing.Size(215, 53);
            this.btnTestPrintter.TabIndex = 6;
            this.btnTestPrintter.Text = "Probar Impresión";
            this.btnTestPrintter.UseSelectable = true;
            this.btnTestPrintter.Click += new System.EventHandler(this.btnTestPrintter_Click);
            // 
            // cbPrinter
            // 
            this.cbPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.ItemHeight = 23;
            this.cbPrinter.Location = new System.Drawing.Point(119, 26);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(217, 29);
            this.cbPrinter.TabIndex = 5;
            this.cbPrinter.UseSelectable = true;
            // 
            // btnOpenBox
            // 
            this.btnOpenBox.ActiveControl = null;
            this.btnOpenBox.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnOpenBox.Location = new System.Drawing.Point(28, 89);
            this.btnOpenBox.Name = "btnOpenBox";
            this.btnOpenBox.Size = new System.Drawing.Size(161, 53);
            this.btnOpenBox.TabIndex = 0;
            this.btnOpenBox.Text = "Abrir";
            this.btnOpenBox.UseSelectable = true;
            this.btnOpenBox.Click += new System.EventHandler(this.btnOpenBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impresora";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnVer);
            this.panel10.Controls.Add(this.btnLoadJokeImage);
            this.panel10.Controls.Add(this.btnJokeImage);
            this.panel10.Controls.Add(this.txtJokeImage);
            this.panel10.Location = new System.Drawing.Point(701, 512);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(50, 44);
            this.panel10.TabIndex = 55;
            this.panel10.Visible = false;
            // 
            // btnLoadJokeImage
            // 
            this.btnLoadJokeImage.ActiveControl = null;
            this.btnLoadJokeImage.Location = new System.Drawing.Point(3, 98);
            this.btnLoadJokeImage.Name = "btnLoadJokeImage";
            this.btnLoadJokeImage.Size = new System.Drawing.Size(353, 45);
            this.btnLoadJokeImage.TabIndex = 57;
            this.btnLoadJokeImage.Text = "Guardar";
            this.btnLoadJokeImage.UseSelectable = true;
            this.btnLoadJokeImage.Click += new System.EventHandler(this.btnLoadJokeImage_Click);
            // 
            // btnJokeImage
            // 
            this.btnJokeImage.ActiveControl = null;
            this.btnJokeImage.Location = new System.Drawing.Point(334, 3);
            this.btnJokeImage.Name = "btnJokeImage";
            this.btnJokeImage.Size = new System.Drawing.Size(22, 20);
            this.btnJokeImage.TabIndex = 56;
            this.btnJokeImage.UseSelectable = true;
            this.btnJokeImage.Click += new System.EventHandler(this.btnJokeImage_Click);
            // 
            // txtJokeImage
            // 
            this.txtJokeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtJokeImage.CustomButton.Image = null;
            this.txtJokeImage.CustomButton.Location = new System.Drawing.Point(303, 2);
            this.txtJokeImage.CustomButton.Name = "";
            this.txtJokeImage.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtJokeImage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJokeImage.CustomButton.TabIndex = 1;
            this.txtJokeImage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJokeImage.CustomButton.UseSelectable = true;
            this.txtJokeImage.CustomButton.Visible = false;
            this.txtJokeImage.Lines = new string[0];
            this.txtJokeImage.Location = new System.Drawing.Point(3, 3);
            this.txtJokeImage.MaxLength = 50;
            this.txtJokeImage.Name = "txtJokeImage";
            this.txtJokeImage.PasswordChar = '\0';
            this.txtJokeImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJokeImage.SelectedText = "";
            this.txtJokeImage.SelectionLength = 0;
            this.txtJokeImage.SelectionStart = 0;
            this.txtJokeImage.ShortcutsEnabled = true;
            this.txtJokeImage.Size = new System.Drawing.Size(321, 20);
            this.txtJokeImage.TabIndex = 55;
            this.txtJokeImage.UseSelectable = true;
            this.txtJokeImage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJokeImage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(818, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 55;
            this.btnClose.TileImage = global::Kiwi.Tpv.App.Properties.Resources.icoClose;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(774, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 48);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Guardar";
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkShowAnimations
            // 
            this.chkShowAnimations.AutoSize = true;
            this.chkShowAnimations.Location = new System.Drawing.Point(160, 92);
            this.chkShowAnimations.Name = "chkShowAnimations";
            this.chkShowAnimations.Size = new System.Drawing.Size(80, 17);
            this.chkShowAnimations.TabIndex = 93;
            this.chkShowAnimations.Text = "Off";
            this.chkShowAnimations.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 19);
            this.metroLabel8.TabIndex = 92;
            this.metroLabel8.Text = "Animaciones";
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabConfig);
            this.Controls.Add(this.panel10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FrmConfiguration";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Configuración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguration_FormClosed);
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.tabConfig.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReportsLocalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReportsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppLogo)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabConfig;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.CheckBox chkShowJokeReport;
        private MetroFramework.Controls.MetroLabel label11;
        private System.Windows.Forms.Panel panel10;
        private MetroFramework.Controls.MetroTile btnVer;
        private MetroFramework.Controls.MetroTile btnLoadJokeImage;
        private MetroFramework.Controls.MetroTile btnJokeImage;
        private MetroFramework.Controls.MetroTextBox txtJokeImage;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroTextBox txtAdminPassword;
        private MetroFramework.Controls.MetroTile btnOpenBackImage;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroTextBox TxtBackImagePath;
        private MetroFramework.Controls.MetroTextBox txtProductButtonsDimension;
        private MetroFramework.Controls.MetroTextBox txtEmployeeButtonsDimension;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.CheckBox chkCombinationControl;
        private MetroFramework.Controls.MetroLabel label12;
        private MetroFramework.Controls.MetroTile btnRemoveCompanyReportsLogo;
        private System.Windows.Forms.PictureBox picBoxReportsLogo;
        private MetroFramework.Controls.MetroTile btnRemoveCompanyAppLogo;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroTextBox TxtCompanyName;
        private System.Windows.Forms.PictureBox picBoxAppLogo;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroTextBox txtCompanyCif;
        private MetroFramework.Controls.MetroTile btnSelectCompanyReportsLogo;
        private MetroFramework.Controls.MetroTile btnSelectCompanyAppLogo;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroGrid DataGridViewStations;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTile btnTestPrintter;
        private MetroFramework.Controls.MetroComboBox cbPrinter;
        private MetroFramework.Controls.MetroTile btnOpenBox;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroTile btnClose;
        private MetroTile btnSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn printterComPortDataGridViewTextBoxColumn;
        private BindingSource stationBindingSource;
        private MetroTile btnRemoveCompanyLocalImage;
        private PictureBox picBoxReportsLocalImage;
        private MetroLabel metroLabel1;
        private MetroTile btnSelectCompanyLocalImage;
        private MetroTextBox txtTableButtonsDimensions;
        private MetroLabel metroLabel2;
        private MetroLabel metroLabel3;
        private MetroTextBox TxtTicketReport;
        private MetroButton BtnSelectReportTicket;
        private MetroTextBox txtActualStation;
        private MetroComboBox cmbServerStation;
        private MetroLabel metroLabel5;
        private MetroButton btnDbBackupFilePath;
        private MetroLabel metroLabel4;
        private MetroTextBox txtDbBackupFilePath;
        private CheckBox chkCombinationControlWithSoda;
        private MetroLabel metroLabel6;
        private MetroLabel metroLabel7;
        private MetroToggle chkShowSaleOrderTicket;
        private MetroToggle chkShowAnimations;
        private MetroLabel metroLabel8;
    }
}
/*
 * Created by SharpDevelop.
 * User: sc5
 * Date: 28/11/2022
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MythicalProjectDays
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_proj_days = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DatePick_StartDate = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DatePick_EndDate = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_days_between = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_days_between = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_project_days = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_project_days_percentage = new System.Windows.Forms.TextBox();
            this.lbl_project_days_percentage = new System.Windows.Forms.Label();
            this.tab_annual_holidays = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.DatePick_Hol_Date = new System.Windows.Forms.DateTimePicker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btn_remove_annual = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btn_add_holiday = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lstbx_annual_hol = new System.Windows.Forms.ListBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_annual_holiday_clear = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btn_save_private_hol = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btn_open_private_holiday = new System.Windows.Forms.Button();
            this.tab_public_holidays = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lstbx_public_hol = new System.Windows.Forms.ListBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btn_public_holidays = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_proj_days.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tab_annual_holidays.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tab_public_holidays.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 397);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_proj_days);
            this.tabControl1.Controls.Add(this.tab_annual_holidays);
            this.tabControl1.Controls.Add(this.tab_public_holidays);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_proj_days
            // 
            this.tab_proj_days.Controls.Add(this.tableLayoutPanel2);
            this.tab_proj_days.Location = new System.Drawing.Point(4, 29);
            this.tab_proj_days.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_proj_days.Name = "tab_proj_days";
            this.tab_proj_days.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_proj_days.Size = new System.Drawing.Size(945, 364);
            this.tab_proj_days.TabIndex = 0;
            this.tab_proj_days.Text = "Mythical Project Days";
            this.tab_proj_days.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 354);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DatePick_StartDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(425, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 52);
            this.panel4.TabIndex = 0;
            // 
            // DatePick_StartDate
            // 
            this.DatePick_StartDate.Location = new System.Drawing.Point(3, 11);
            this.DatePick_StartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_StartDate.Name = "DatePick_StartDate";
            this.DatePick_StartDate.Size = new System.Drawing.Size(202, 26);
            this.DatePick_StartDate.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DatePick_EndDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(425, 67);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 52);
            this.panel5.TabIndex = 1;
            // 
            // DatePick_EndDate
            // 
            this.DatePick_EndDate.Location = new System.Drawing.Point(2, 11);
            this.DatePick_EndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_EndDate.Name = "DatePick_EndDate";
            this.DatePick_EndDate.Size = new System.Drawing.Size(205, 26);
            this.DatePick_EndDate.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_days_between);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(425, 129);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 52);
            this.panel6.TabIndex = 2;
            // 
            // btn_days_between
            // 
            this.btn_days_between.Location = new System.Drawing.Point(50, 9);
            this.btn_days_between.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_days_between.Name = "btn_days_between";
            this.btn_days_between.Size = new System.Drawing.Size(112, 35);
            this.btn_days_between.TabIndex = 8;
            this.btn_days_between.Text = "Go";
            this.btn_days_between.UseVisualStyleBackColor = true;
            this.btn_days_between.Click += new System.EventHandler(this.Btn_days_betweenClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(238, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(179, 52);
            this.panel8.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(238, 67);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(179, 52);
            this.panel9.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date From:";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(238, 129);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(179, 52);
            this.panel10.TabIndex = 6;
            // 
            // panel11
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel11, 2);
            this.panel11.Controls.Add(this.lbl_days_between);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(4, 191);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.tableLayoutPanel2.SetRowSpan(this.panel11, 2);
            this.panel11.Size = new System.Drawing.Size(413, 158);
            this.panel11.TabIndex = 7;
            // 
            // lbl_days_between
            // 
            this.lbl_days_between.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_days_between.Location = new System.Drawing.Point(0, 0);
            this.lbl_days_between.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_days_between.Name = "lbl_days_between";
            this.lbl_days_between.Size = new System.Drawing.Size(413, 158);
            this.lbl_days_between.TabIndex = 0;
            this.lbl_days_between.Text = "......";
            // 
            // panel7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.lbl_project_days);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txtbx_project_days_percentage);
            this.panel7.Controls.Add(this.lbl_project_days_percentage);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(425, 191);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel2.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(508, 158);
            this.panel7.TabIndex = 3;
            // 
            // lbl_project_days
            // 
            this.lbl_project_days.Location = new System.Drawing.Point(4, 45);
            this.lbl_project_days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_project_days.Name = "lbl_project_days";
            this.lbl_project_days.Size = new System.Drawing.Size(500, 113);
            this.lbl_project_days.TabIndex = 3;
            this.lbl_project_days.Text = "...........";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(236, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "%";
            // 
            // txtbx_project_days_percentage
            // 
            this.txtbx_project_days_percentage.Location = new System.Drawing.Point(186, 5);
            this.txtbx_project_days_percentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_project_days_percentage.Name = "txtbx_project_days_percentage";
            this.txtbx_project_days_percentage.Size = new System.Drawing.Size(43, 26);
            this.txtbx_project_days_percentage.TabIndex = 1;
            this.txtbx_project_days_percentage.Text = "75";
            // 
            // lbl_project_days_percentage
            // 
            this.lbl_project_days_percentage.Location = new System.Drawing.Point(0, 9);
            this.lbl_project_days_percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_project_days_percentage.Name = "lbl_project_days_percentage";
            this.lbl_project_days_percentage.Size = new System.Drawing.Size(177, 35);
            this.lbl_project_days_percentage.TabIndex = 0;
            this.lbl_project_days_percentage.Text = "Percentage on Project";
            // 
            // tab_annual_holidays
            // 
            this.tab_annual_holidays.Controls.Add(this.tableLayoutPanel3);
            this.tab_annual_holidays.Location = new System.Drawing.Point(4, 29);
            this.tab_annual_holidays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_annual_holidays.Name = "tab_annual_holidays";
            this.tab_annual_holidays.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_annual_holidays.Size = new System.Drawing.Size(945, 364);
            this.tab_annual_holidays.TabIndex = 1;
            this.tab_annual_holidays.Text = "Annual Holidays";
            this.tab_annual_holidays.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel13, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel14, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel16, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel17, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.panel18, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(937, 354);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.DatePick_Hol_Date);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(7, 5);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(217, 48);
            this.panel12.TabIndex = 0;
            // 
            // DatePick_Hol_Date
            // 
            this.DatePick_Hol_Date.CustomFormat = "dd/MM/yyyy";
            this.DatePick_Hol_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePick_Hol_Date.Location = new System.Drawing.Point(38, 9);
            this.DatePick_Hol_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_Hol_Date.Name = "DatePick_Hol_Date";
            this.DatePick_Hol_Date.Size = new System.Drawing.Size(140, 26);
            this.DatePick_Hol_Date.TabIndex = 0;
            this.DatePick_Hol_Date.Value = new System.DateTime(2022, 12, 7, 11, 48, 51, 0);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tableLayoutPanel5);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(7, 63);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(217, 48);
            this.panel13.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel26, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel27, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(217, 48);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btn_remove_annual);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(4, 5);
            this.panel26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(100, 38);
            this.panel26.TabIndex = 0;
            // 
            // btn_remove_annual
            // 
            this.btn_remove_annual.Location = new System.Drawing.Point(4, 3);
            this.btn_remove_annual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remove_annual.Name = "btn_remove_annual";
            this.btn_remove_annual.Size = new System.Drawing.Size(90, 35);
            this.btn_remove_annual.TabIndex = 1;
            this.btn_remove_annual.Text = "Remove";
            this.btn_remove_annual.UseVisualStyleBackColor = true;
            this.btn_remove_annual.Click += new System.EventHandler(this.Btn_remove_annualClick);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btn_add_holiday);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(112, 5);
            this.panel27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(101, 38);
            this.panel27.TabIndex = 1;
            // 
            // btn_add_holiday
            // 
            this.btn_add_holiday.Location = new System.Drawing.Point(4, 3);
            this.btn_add_holiday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_holiday.Name = "btn_add_holiday";
            this.btn_add_holiday.Size = new System.Drawing.Size(90, 35);
            this.btn_add_holiday.TabIndex = 0;
            this.btn_add_holiday.Text = "Add";
            this.btn_add_holiday.UseVisualStyleBackColor = true;
            this.btn_add_holiday.Click += new System.EventHandler(this.Btn_add_holidayClick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.lstbx_annual_hol);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(232, 5);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.tableLayoutPanel3.SetRowSpan(this.panel14, 5);
            this.panel14.Size = new System.Drawing.Size(701, 344);
            this.panel14.TabIndex = 2;
            // 
            // lstbx_annual_hol
            // 
            this.lstbx_annual_hol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbx_annual_hol.FormatString = "d";
            this.lstbx_annual_hol.FormattingEnabled = true;
            this.lstbx_annual_hol.ItemHeight = 20;
            this.lstbx_annual_hol.Location = new System.Drawing.Point(0, 0);
            this.lstbx_annual_hol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbx_annual_hol.Name = "lstbx_annual_hol";
            this.lstbx_annual_hol.Size = new System.Drawing.Size(701, 344);
            this.lstbx_annual_hol.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btn_annual_holiday_clear);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(7, 179);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(217, 48);
            this.panel16.TabIndex = 4;
            // 
            // btn_annual_holiday_clear
            // 
            this.btn_annual_holiday_clear.Location = new System.Drawing.Point(52, 8);
            this.btn_annual_holiday_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_annual_holiday_clear.Name = "btn_annual_holiday_clear";
            this.btn_annual_holiday_clear.Size = new System.Drawing.Size(112, 35);
            this.btn_annual_holiday_clear.TabIndex = 2;
            this.btn_annual_holiday_clear.Text = "Clear";
            this.btn_annual_holiday_clear.UseVisualStyleBackColor = true;
            this.btn_annual_holiday_clear.Click += new System.EventHandler(this.Btn_annual_holiday_clearClick);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btn_save_private_hol);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(7, 237);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(217, 112);
            this.panel17.TabIndex = 5;
            // 
            // btn_save_private_hol
            // 
            this.btn_save_private_hol.Location = new System.Drawing.Point(30, 6);
            this.btn_save_private_hol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save_private_hol.Name = "btn_save_private_hol";
            this.btn_save_private_hol.Size = new System.Drawing.Size(158, 35);
            this.btn_save_private_hol.TabIndex = 1;
            this.btn_save_private_hol.Text = "Save Annual";
            this.btn_save_private_hol.UseVisualStyleBackColor = true;
            this.btn_save_private_hol.Click += new System.EventHandler(this.Btn_save_private_holClick);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_open_private_holiday);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(7, 121);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(217, 48);
            this.panel18.TabIndex = 6;
            // 
            // btn_open_private_holiday
            // 
            this.btn_open_private_holiday.Location = new System.Drawing.Point(30, 8);
            this.btn_open_private_holiday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open_private_holiday.Name = "btn_open_private_holiday";
            this.btn_open_private_holiday.Size = new System.Drawing.Size(158, 35);
            this.btn_open_private_holiday.TabIndex = 1;
            this.btn_open_private_holiday.Text = "Open Annual";
            this.btn_open_private_holiday.UseVisualStyleBackColor = true;
            this.btn_open_private_holiday.Click += new System.EventHandler(this.Btn_open_private_holidayClick);
            // 
            // tab_public_holidays
            // 
            this.tab_public_holidays.Controls.Add(this.panel19);
            this.tab_public_holidays.Location = new System.Drawing.Point(4, 29);
            this.tab_public_holidays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_public_holidays.Name = "tab_public_holidays";
            this.tab_public_holidays.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_public_holidays.Size = new System.Drawing.Size(945, 364);
            this.tab_public_holidays.TabIndex = 2;
            this.tab_public_holidays.Text = "Public Holidays";
            this.tab_public_holidays.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.tableLayoutPanel4);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(4, 5);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(937, 354);
            this.panel19.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel20, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel21, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel22, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel23, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel24, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel25, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(937, 354);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.lstbx_public_hol);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(229, 5);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel20.Name = "panel20";
            this.tableLayoutPanel4.SetRowSpan(this.panel20, 5);
            this.panel20.Size = new System.Drawing.Size(704, 344);
            this.panel20.TabIndex = 0;
            // 
            // lstbx_public_hol
            // 
            this.lstbx_public_hol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbx_public_hol.FormatString = "d";
            this.lstbx_public_hol.FormattingEnabled = true;
            this.lstbx_public_hol.ItemHeight = 20;
            this.lstbx_public_hol.Location = new System.Drawing.Point(0, 0);
            this.lstbx_public_hol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbx_public_hol.Name = "lstbx_public_hol";
            this.lstbx_public_hol.Size = new System.Drawing.Size(704, 344);
            this.lstbx_public_hol.TabIndex = 2;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btn_public_holidays);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(4, 5);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(217, 52);
            this.panel21.TabIndex = 1;
            // 
            // btn_public_holidays
            // 
            this.btn_public_holidays.Location = new System.Drawing.Point(18, 9);
            this.btn_public_holidays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_public_holidays.Name = "btn_public_holidays";
            this.btn_public_holidays.Size = new System.Drawing.Size(180, 35);
            this.btn_public_holidays.TabIndex = 2;
            this.btn_public_holidays.Text = "Open Public Holidays";
            this.btn_public_holidays.UseVisualStyleBackColor = true;
            this.btn_public_holidays.Click += new System.EventHandler(this.Btn_public_holidaysClick);
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(4, 67);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(217, 52);
            this.panel22.TabIndex = 2;
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(4, 129);
            this.panel23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(217, 52);
            this.panel23.TabIndex = 3;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(4, 191);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(217, 52);
            this.panel24.TabIndex = 4;
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(4, 253);
            this.panel25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(217, 96);
            this.panel25.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 52);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 474);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 52);
            this.panel3.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btn_close);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(953, 52);
            this.panel15.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(420, 9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 35);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_closeClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MythicalProjectDays";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_proj_days.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tab_annual_holidays.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.tab_public_holidays.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lbl_project_days_percentage;
		private System.Windows.Forms.TextBox txtbx_project_days_percentage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_project_days;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.Button btn_remove_annual;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.ListBox lstbx_public_hol;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.ListBox lstbx_annual_hol;
		private System.Windows.Forms.Button btn_annual_holiday_clear;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.TabPage tab_public_holidays;
		private System.Windows.Forms.Button btn_save_private_hol;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Button btn_open_private_holiday;
		private System.Windows.Forms.Button btn_public_holidays;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Button btn_add_holiday;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.DateTimePicker DatePick_Hol_Date;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lbl_days_between;
		private System.Windows.Forms.Button btn_days_between;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabPage tab_annual_holidays;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DateTimePicker DatePick_EndDate;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DateTimePicker DatePick_StartDate;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TabPage tab_proj_days;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

namespace PointOfSale
{
    partial class FrmManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExtendMenu = new PointOfSale.EFlatButton();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnAdmins = new PointOfSale.EFlatButton();
            this.btnManagers = new PointOfSale.EFlatButton();
            this.btnCustomers = new PointOfSale.EFlatButton();
            this.btnDashboard = new PointOfSale.EFlatButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.eTabControl1 = new PointOfSale.ETabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlDboardRight = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlInventoryPadding = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button11 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.pnlHeaderPadding = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlDboardLeftSide = new System.Windows.Forms.Panel();
            this.pnlSalesPadding = new System.Windows.Forms.Panel();
            this.pnlSalesContainer = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlTransactionContainer = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.eTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlDboardRight.SuspendLayout();
            this.pnlInventoryPadding.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlHeaderPadding.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDboardLeftSide.SuspendLayout();
            this.pnlSalesPadding.SuspendLayout();
            this.pnlSalesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlTransactionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.menuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.White;
            this.pnlTitleBar.Controls.Add(this.btnTitle);
            this.pnlTitleBar.Controls.Add(this.btnOptions);
            this.pnlTitleBar.Controls.Add(this.btnExtendMenu);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTitleBar.Location = new System.Drawing.Point(48, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(651, 48);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSize = true;
            this.btnTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTitle.BackColor = System.Drawing.Color.White;
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(48, 0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(41, 48);
            this.btnTitle.TabIndex = 44;
            this.btnTitle.Text = "test";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // btnOptions
            // 
            this.btnOptions.AutoSize = true;
            this.btnOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOptions.BackColor = System.Drawing.Color.White;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnOptions.Image = global::PointOfSale.Properties.Resources.ic_menu_dropdown_black_24dp;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.Location = new System.Drawing.Point(579, 0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(72, 48);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "NAME";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnExtendMenu
            // 
            this.btnExtendMenu.BackColor = System.Drawing.Color.White;
            this.btnExtendMenu.ColorIdle = System.Drawing.Color.White;
            this.btnExtendMenu.ColorWorking = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnExtendMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExtendMenu.FlatAppearance.BorderSize = 0;
            this.btnExtendMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendMenu.ForeColor = System.Drawing.Color.White;
            this.btnExtendMenu.Image = global::PointOfSale.Properties.Resources.ic_burger_menu_blue_24dp;
            this.btnExtendMenu.ImageIdle = global::PointOfSale.Properties.Resources.ic_burger_menu_blue_24dp;
            this.btnExtendMenu.ImageWorking = global::PointOfSale.Properties.Resources.ic_backburger_white_24dp;
            this.btnExtendMenu.Location = new System.Drawing.Point(0, 0);
            this.btnExtendMenu.Name = "btnExtendMenu";
            this.btnExtendMenu.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnExtendMenu.Size = new System.Drawing.Size(48, 48);
            this.btnExtendMenu.TabIndex = 6;
            this.btnExtendMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtendMenu.Title = "Administrators";
            this.btnExtendMenu.UseVisualStyleBackColor = false;
            this.btnExtendMenu.Click += new System.EventHandler(this.BtnExtendMenu_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlSideBar.Controls.Add(this.btnAdmins);
            this.pnlSideBar.Controls.Add(this.btnManagers);
            this.pnlSideBar.Controls.Add(this.btnCustomers);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(48, 541);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAdmins.ColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAdmins.ColorWorking = System.Drawing.Color.White;
            this.btnAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.ForeColor = System.Drawing.Color.White;
            this.btnAdmins.Image = global::PointOfSale.Properties.Resources.ic_shield_account_outline_white_24dp;
            this.btnAdmins.ImageIdle = global::PointOfSale.Properties.Resources.ic_shield_account_outline_white_24dp;
            this.btnAdmins.ImageWorking = global::PointOfSale.Properties.Resources.ic_shield_account_outline_blue_24dp;
            this.btnAdmins.Location = new System.Drawing.Point(0, 144);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAdmins.Size = new System.Drawing.Size(48, 48);
            this.btnAdmins.TabIndex = 3;
            this.btnAdmins.TabStop = false;
            this.btnAdmins.Tag = "3";
            this.btnAdmins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmins.Title = "Administrators";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.MultiClick);
            // 
            // btnManagers
            // 
            this.btnManagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnManagers.ColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnManagers.ColorWorking = System.Drawing.Color.White;
            this.btnManagers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagers.FlatAppearance.BorderSize = 0;
            this.btnManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagers.ForeColor = System.Drawing.Color.White;
            this.btnManagers.Image = global::PointOfSale.Properties.Resources.ic_manager_white_24dp;
            this.btnManagers.ImageIdle = global::PointOfSale.Properties.Resources.ic_manager_white_24dp;
            this.btnManagers.ImageWorking = global::PointOfSale.Properties.Resources.ic_manager_blue_24dp;
            this.btnManagers.Location = new System.Drawing.Point(0, 96);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnManagers.Size = new System.Drawing.Size(48, 48);
            this.btnManagers.TabIndex = 2;
            this.btnManagers.TabStop = false;
            this.btnManagers.Tag = "2";
            this.btnManagers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagers.Title = "Managers";
            this.btnManagers.UseVisualStyleBackColor = false;
            this.btnManagers.Click += new System.EventHandler(this.MultiClick);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCustomers.ColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCustomers.ColorWorking = System.Drawing.Color.White;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::PointOfSale.Properties.Resources.ic_account_outline_white_24dp;
            this.btnCustomers.ImageIdle = global::PointOfSale.Properties.Resources.ic_account_outline_white_24dp;
            this.btnCustomers.ImageWorking = global::PointOfSale.Properties.Resources.ic_account_outline_blue_24dp;
            this.btnCustomers.Location = new System.Drawing.Point(0, 48);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnCustomers.Size = new System.Drawing.Size(48, 48);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.Tag = "1";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.Title = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.MultiClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnDashboard.ColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnDashboard.ColorWorking = System.Drawing.Color.White;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::PointOfSale.Properties.Resources.ic_dashboard_outline_white_24dp;
            this.btnDashboard.ImageIdle = global::PointOfSale.Properties.Resources.ic_dashboard_outline_white_24dp;
            this.btnDashboard.ImageWorking = global::PointOfSale.Properties.Resources.ic_dashboard_outline_blue_24dp;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDashboard.Size = new System.Drawing.Size(48, 48);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Tag = "0";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.Title = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.MultiClick);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Silver;
            this.pnlContainer.Controls.Add(this.eTabControl1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(48, 48);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContainer.Size = new System.Drawing.Size(651, 493);
            this.pnlContainer.TabIndex = 2;
            // 
            // eTabControl1
            // 
            this.eTabControl1.Controls.Add(this.tabPage1);
            this.eTabControl1.Controls.Add(this.tabPage2);
            this.eTabControl1.Controls.Add(this.tabPage3);
            this.eTabControl1.Controls.Add(this.tabPage4);
            this.eTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eTabControl1.Location = new System.Drawing.Point(8, 8);
            this.eTabControl1.Multiline = true;
            this.eTabControl1.Name = "eTabControl1";
            this.eTabControl1.SelectedIndex = 0;
            this.eTabControl1.Size = new System.Drawing.Size(635, 477);
            this.eTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.pnlDboardRight);
            this.tabPage1.Controls.Add(this.pnlDboardLeftSide);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // pnlDboardRight
            // 
            this.pnlDboardRight.Controls.Add(this.panel4);
            this.pnlDboardRight.Controls.Add(this.pnlInventoryPadding);
            this.pnlDboardRight.Controls.Add(this.pnlHeaderPadding);
            this.pnlDboardRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDboardRight.Location = new System.Drawing.Point(328, 3);
            this.pnlDboardRight.Name = "pnlDboardRight";
            this.pnlDboardRight.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlDboardRight.Size = new System.Drawing.Size(296, 445);
            this.pnlDboardRight.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(8, 368);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel4.Size = new System.Drawing.Size(288, 77);
            this.panel4.TabIndex = 2;
            // 
            // pnlInventoryPadding
            // 
            this.pnlInventoryPadding.Controls.Add(this.panel3);
            this.pnlInventoryPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventoryPadding.Location = new System.Drawing.Point(8, 112);
            this.pnlInventoryPadding.Name = "pnlInventoryPadding";
            this.pnlInventoryPadding.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlInventoryPadding.Size = new System.Drawing.Size(288, 256);
            this.pnlInventoryPadding.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel3.Size = new System.Drawing.Size(288, 248);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 56;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 48;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(272, 198);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.TabStop = false;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button11.Location = new System.Drawing.Point(8, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(272, 23);
            this.button11.TabIndex = 46;
            this.button11.Text = "Sort items by..";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(8, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(272, 27);
            this.button17.TabIndex = 45;
            this.button17.Text = "Inventory";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // pnlHeaderPadding
            // 
            this.pnlHeaderPadding.Controls.Add(this.panel1);
            this.pnlHeaderPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPadding.Location = new System.Drawing.Point(8, 0);
            this.pnlHeaderPadding.Name = "pnlHeaderPadding";
            this.pnlHeaderPadding.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlHeaderPadding.Size = new System.Drawing.Size(288, 112);
            this.pnlHeaderPadding.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel1.Size = new System.Drawing.Size(288, 104);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 77);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(3, 32);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 42);
            this.button10.TabIndex = 51;
            this.button10.Text = "0";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(93, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 42);
            this.button9.TabIndex = 50;
            this.button9.Text = "0";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(183, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 42);
            this.button8.TabIndex = 49;
            this.button8.Text = "0.00";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(93, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "Transactions";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "Items Sold";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(183, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Revenue";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 27);
            this.button4.TabIndex = 45;
            this.button4.Text = "Sales Today";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnlDboardLeftSide
            // 
            this.pnlDboardLeftSide.Controls.Add(this.pnlSalesPadding);
            this.pnlDboardLeftSide.Controls.Add(this.pnlTransactionContainer);
            this.pnlDboardLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDboardLeftSide.Location = new System.Drawing.Point(3, 3);
            this.pnlDboardLeftSide.Name = "pnlDboardLeftSide";
            this.pnlDboardLeftSide.Size = new System.Drawing.Size(325, 445);
            this.pnlDboardLeftSide.TabIndex = 2;
            // 
            // pnlSalesPadding
            // 
            this.pnlSalesPadding.Controls.Add(this.pnlSalesContainer);
            this.pnlSalesPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesPadding.Location = new System.Drawing.Point(0, 229);
            this.pnlSalesPadding.Name = "pnlSalesPadding";
            this.pnlSalesPadding.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlSalesPadding.Size = new System.Drawing.Size(325, 216);
            this.pnlSalesPadding.TabIndex = 1;
            // 
            // pnlSalesContainer
            // 
            this.pnlSalesContainer.BackColor = System.Drawing.Color.White;
            this.pnlSalesContainer.Controls.Add(this.chart1);
            this.pnlSalesContainer.Controls.Add(this.button3);
            this.pnlSalesContainer.Controls.Add(this.button2);
            this.pnlSalesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesContainer.Location = new System.Drawing.Point(0, 8);
            this.pnlSalesContainer.Name = "pnlSalesContainer";
            this.pnlSalesContainer.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnlSalesContainer.Size = new System.Drawing.Size(325, 208);
            this.pnlSalesContainer.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(8, 50);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(309, 150);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button3.Location = new System.Drawing.Point(8, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Sort sales by...";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 27);
            this.button2.TabIndex = 44;
            this.button2.Text = "Sales Performance";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlTransactionContainer
            // 
            this.pnlTransactionContainer.BackColor = System.Drawing.Color.White;
            this.pnlTransactionContainer.Controls.Add(this.dgvTransactions);
            this.pnlTransactionContainer.Controls.Add(this.button1);
            this.pnlTransactionContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransactionContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactionContainer.Name = "pnlTransactionContainer";
            this.pnlTransactionContainer.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnlTransactionContainer.Size = new System.Drawing.Size(325, 229);
            this.pnlTransactionContainer.TabIndex = 3;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTransactions.ColumnHeadersHeight = 56;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Location = new System.Drawing.Point(8, 27);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 24;
            this.dgvTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactions.RowTemplate.Height = 48;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.ShowEditingIcon = false;
            this.dgvTransactions.Size = new System.Drawing.Size(309, 194);
            this.dgvTransactions.TabIndex = 42;
            this.dgvTransactions.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 27);
            this.button1.TabIndex = 43;
            this.button1.Text = "Transactions";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // menuOptions
            // 
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogs,
            this.menuItemSettings,
            this.menuItemLogout});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(138, 70);
            // 
            // menuItemLogs
            // 
            this.menuItemLogs.Name = "menuItemLogs";
            this.menuItemLogs.Size = new System.Drawing.Size(137, 22);
            this.menuItemLogs.Text = "Activity Log";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(137, 22);
            this.menuItemSettings.Text = "Settings";
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(137, 22);
            this.menuItemLogout.Text = "Logout";
            this.menuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(627, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(627, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(699, 541);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManager_Load);
            this.SizeChanged += new System.EventHandler(this.FrmManager_SizeChanged);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.eTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlDboardRight.ResumeLayout(false);
            this.pnlInventoryPadding.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlHeaderPadding.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlDboardLeftSide.ResumeLayout(false);
            this.pnlSalesPadding.ResumeLayout(false);
            this.pnlSalesContainer.ResumeLayout(false);
            this.pnlSalesContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlTransactionContainer.ResumeLayout(false);
            this.pnlTransactionContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.menuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlContainer;
        private ETabControl eTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EFlatButton btnCustomers;
        private EFlatButton btnAdmins;
        private EFlatButton btnManagers;
        private EFlatButton btnDashboard;
        private System.Windows.Forms.ContextMenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogs;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
        private EFlatButton btnExtendMenu;
        private System.Windows.Forms.Panel pnlDboardLeftSide;
        private System.Windows.Forms.Panel pnlSalesPadding;
        private System.Windows.Forms.Panel pnlSalesContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlTransactionContainer;
        internal System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDboardRight;
        private System.Windows.Forms.Panel pnlHeaderPadding;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel pnlInventoryPadding;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button11;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
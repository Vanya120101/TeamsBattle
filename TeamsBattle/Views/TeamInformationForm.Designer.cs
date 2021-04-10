
namespace BattleStrategy.Views
{
    partial class TeamInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamInformationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AchievementsList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PeopleList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.InnerInformationPanelTwo = new System.Windows.Forms.Panel();
            this.panelno = new System.Windows.Forms.Panel();
            this.TeamStatisticsBox = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.TeamPowerBox = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.TeamNameBox = new System.Windows.Forms.Label();
            this.InnerInformationPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.InnerInformationPanelTwo.SuspendLayout();
            this.panelno.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.InnerInformationPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMainPanel
            // 
            this.TopMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.TopMainPanel.Controls.Add(this.TopMenu);
            this.TopMainPanel.Controls.Add(this.CloseButton);
            this.TopMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMainPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopMainPanel.Name = "TopMainPanel";
            this.TopMainPanel.Size = new System.Drawing.Size(800, 61);
            this.TopMainPanel.TabIndex = 2;
            // 
            // TopMenu
            // 
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMenu.ForeColor = System.Drawing.Color.White;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(744, 61);
            this.TopMenu.TabIndex = 1;
            this.TopMenu.Text = "Информация";
            this.TopMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseDown);
            this.TopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ImageKey = "Close";
            this.CloseButton.ImageList = this.ImageList;
            this.CloseButton.Location = new System.Drawing.Point(744, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 61);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Close");
            this.ImageList.Images.SetKeyName(1, "Question");
            this.ImageList.Images.SetKeyName(2, "Minimize");
            this.ImageList.Images.SetKeyName(3, "Battle.png");
            this.ImageList.Images.SetKeyName(4, "Hero.png");
            this.ImageList.Images.SetKeyName(5, "Team.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AchievementsList);
            this.panel1.Controls.Add(this.PeopleList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.InnerInformationPanelTwo);
            this.panel1.Controls.Add(this.InnerInformationPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 40);
            this.panel1.Size = new System.Drawing.Size(800, 635);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(506, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Достижения";
            // 
            // AchievementsList
            // 
            this.AchievementsList.AllowUserToAddRows = false;
            this.AchievementsList.AllowUserToDeleteRows = false;
            this.AchievementsList.AllowUserToResizeColumns = false;
            this.AchievementsList.AllowUserToResizeRows = false;
            this.AchievementsList.AutoGenerateColumns = false;
            this.AchievementsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.AchievementsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AchievementsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AchievementsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AchievementsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AchievementsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AchievementsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.AchievementsList.DataSource = this.achievementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AchievementsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.AchievementsList.EnableHeadersVisualStyles = false;
            this.AchievementsList.GridColor = System.Drawing.Color.White;
            this.AchievementsList.Location = new System.Drawing.Point(511, 246);
            this.AchievementsList.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.AchievementsList.MultiSelect = false;
            this.AchievementsList.Name = "AchievementsList";
            this.AchievementsList.ReadOnly = true;
            this.AchievementsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AchievementsList.RowHeadersVisible = false;
            this.AchievementsList.RowHeadersWidth = 51;
            this.AchievementsList.RowTemplate.Height = 40;
            this.AchievementsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AchievementsList.ShowCellErrors = false;
            this.AchievementsList.ShowCellToolTips = false;
            this.AchievementsList.ShowEditingIcon = false;
            this.AchievementsList.ShowRowErrors = false;
            this.AchievementsList.Size = new System.Drawing.Size(192, 298);
            this.AchievementsList.TabIndex = 15;
         
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 164;
            // 
            // achievementBindingSource
            // 
            // 
            // PeopleList
            // 
            this.PeopleList.AllowUserToAddRows = false;
            this.PeopleList.AllowUserToDeleteRows = false;
            this.PeopleList.AllowUserToResizeColumns = false;
            this.PeopleList.AllowUserToResizeRows = false;
            this.PeopleList.AutoGenerateColumns = false;
            this.PeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PeopleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Level});
            this.PeopleList.DataSource = this.personBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PeopleList.DefaultCellStyle = dataGridViewCellStyle4;
            this.PeopleList.EnableHeadersVisualStyles = false;
            this.PeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PeopleList.Location = new System.Drawing.Point(45, 246);
            this.PeopleList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.PeopleList.MultiSelect = false;
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.ReadOnly = true;
            this.PeopleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PeopleList.RowHeadersVisible = false;
            this.PeopleList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PeopleList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PeopleList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PeopleList.RowTemplate.Height = 40;
            this.PeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PeopleList.ShowCellErrors = false;
            this.PeopleList.ShowCellToolTips = false;
            this.PeopleList.ShowEditingIcon = false;
            this.PeopleList.ShowRowErrors = false;
            this.PeopleList.Size = new System.Drawing.Size(413, 323);
            this.PeopleList.TabIndex = 14;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 109;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Уровень";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 151;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BattleStrategy.Domain_models.Person);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Участники";
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = true;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(676, 547);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(101, 36);
            this.OkButton.TabIndex = 11;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // InnerInformationPanelTwo
            // 
            this.InnerInformationPanelTwo.AutoSize = true;
            this.InnerInformationPanelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.InnerInformationPanelTwo.Controls.Add(this.panelno);
            this.InnerInformationPanelTwo.Controls.Add(this.panel19);
            this.InnerInformationPanelTwo.Controls.Add(this.panel20);
            this.InnerInformationPanelTwo.Location = new System.Drawing.Point(229, 45);
            this.InnerInformationPanelTwo.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.InnerInformationPanelTwo.Name = "InnerInformationPanelTwo";
            this.InnerInformationPanelTwo.Size = new System.Drawing.Size(197, 153);
            this.InnerInformationPanelTwo.TabIndex = 8;
            // 
            // panelno
            // 
            this.panelno.AutoSize = true;
            this.panelno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelno.Controls.Add(this.TeamStatisticsBox);
            this.panelno.Location = new System.Drawing.Point(0, 100);
            this.panelno.Name = "panelno";
            this.panelno.Size = new System.Drawing.Size(194, 50);
            this.panelno.TabIndex = 2;
            // 
            // TeamStatisticsBox
            // 
            this.TeamStatisticsBox.AutoSize = true;
            this.TeamStatisticsBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeamStatisticsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamStatisticsBox.Location = new System.Drawing.Point(0, 0);
            this.TeamStatisticsBox.Name = "TeamStatisticsBox";
            this.TeamStatisticsBox.Size = new System.Drawing.Size(0, 26);
            this.TeamStatisticsBox.TabIndex = 2;
            this.TeamStatisticsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.AutoSize = true;
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel19.Controls.Add(this.TeamPowerBox);
            this.panel19.Location = new System.Drawing.Point(0, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(194, 50);
            this.panel19.TabIndex = 1;
            // 
            // TeamPowerBox
            // 
            this.TeamPowerBox.AutoSize = true;
            this.TeamPowerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TeamPowerBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeamPowerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamPowerBox.Location = new System.Drawing.Point(0, 0);
            this.TeamPowerBox.Name = "TeamPowerBox";
            this.TeamPowerBox.Size = new System.Drawing.Size(0, 26);
            this.TeamPowerBox.TabIndex = 2;
            this.TeamPowerBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.AutoSize = true;
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel20.Controls.Add(this.TeamNameBox);
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(194, 50);
            this.panel20.TabIndex = 0;
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.AutoSize = true;
            this.TeamNameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeamNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamNameBox.Location = new System.Drawing.Point(0, 0);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(0, 26);
            this.TeamNameBox.TabIndex = 0;
            this.TeamNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InnerInformationPanel
            // 
            this.InnerInformationPanel.AutoSize = true;
            this.InnerInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.InnerInformationPanel.Controls.Add(this.panel3);
            this.InnerInformationPanel.Controls.Add(this.panel2);
            this.InnerInformationPanel.Controls.Add(this.panel7);
            this.InnerInformationPanel.Location = new System.Drawing.Point(45, 45);
            this.InnerInformationPanel.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.InnerInformationPanel.Name = "InnerInformationPanel";
            this.InnerInformationPanel.Size = new System.Drawing.Size(197, 153);
            this.InnerInformationPanel.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 50);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Процент побед:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 50);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Мощь команды:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 50);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя команды:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamInformationForm";
            this.Text = "TeamInformationForm";
            this.TopMainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.InnerInformationPanelTwo.ResumeLayout(false);
            this.InnerInformationPanelTwo.PerformLayout();
            this.panelno.ResumeLayout(false);
            this.panelno.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.InnerInformationPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMainPanel;
        private System.Windows.Forms.Label TopMenu;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel InnerInformationPanelTwo;
        private System.Windows.Forms.Panel panelno;
        private System.Windows.Forms.Label TeamStatisticsBox;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label TeamPowerBox;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label TeamNameBox;
        private System.Windows.Forms.Panel InnerInformationPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PeopleList;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView AchievementsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource achievementBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}

namespace BattleStrategy.Views.Controls
{
    partial class TeamListControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TeamsList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statistics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TeamInformationButton = new System.Windows.Forms.Button();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.DeleteTeamButton = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.TeamsList);
            this.LeftPanel.Controls.Add(this.ButtonPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(45, 45);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(1334, 465);
            this.LeftPanel.TabIndex = 4;
            // 
            // TeamsList
            // 
            this.TeamsList.AllowUserToAddRows = false;
            this.TeamsList.AllowUserToDeleteRows = false;
            this.TeamsList.AllowUserToResizeColumns = false;
            this.TeamsList.AllowUserToResizeRows = false;
            this.TeamsList.AutoGenerateColumns = false;
            this.TeamsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TeamsList.BackgroundColor = System.Drawing.Color.White;
            this.TeamsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TeamsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeamsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.Statistics,
            this.countDataGridViewTextBoxColumn});
            this.TeamsList.DataSource = this.teamBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeamsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeamsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsList.EnableHeadersVisualStyles = false;
            this.TeamsList.GridColor = System.Drawing.Color.White;
            this.TeamsList.Location = new System.Drawing.Point(0, 0);
            this.TeamsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.TeamsList.MultiSelect = false;
            this.TeamsList.Name = "TeamsList";
            this.TeamsList.ReadOnly = true;
            this.TeamsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TeamsList.RowHeadersVisible = false;
            this.TeamsList.RowHeadersWidth = 51;
            this.TeamsList.RowTemplate.Height = 40;
            this.TeamsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeamsList.ShowCellErrors = false;
            this.TeamsList.ShowCellToolTips = false;
            this.TeamsList.ShowEditingIcon = false;
            this.TeamsList.ShowRowErrors = false;
            this.TeamsList.Size = new System.Drawing.Size(1334, 415);
            this.TeamsList.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя команды";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 191;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощь команды";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Width = 205;
            // 
            // Statistics
            // 
            this.Statistics.DataPropertyName = "Statistics";
            this.Statistics.HeaderText = "Процент побед";
            this.Statistics.Name = "Statistics";
            this.Statistics.ReadOnly = true;
            this.Statistics.Width = 203;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество членов";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 243;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(BattleStrategy.Domain_models.Team);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoSize = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.White;
            this.ButtonPanel.Controls.Add(this.TeamInformationButton);
            this.ButtonPanel.Controls.Add(this.AddTeamButton);
            this.ButtonPanel.Controls.Add(this.DeleteTeamButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 415);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1334, 50);
            this.ButtonPanel.TabIndex = 4;
            // 
            // TeamInformationButton
            // 
            this.TeamInformationButton.AutoSize = true;
            this.TeamInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamInformationButton.FlatAppearance.BorderSize = 0;
            this.TeamInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamInformationButton.Location = new System.Drawing.Point(2, 2);
            this.TeamInformationButton.Margin = new System.Windows.Forms.Padding(2);
            this.TeamInformationButton.Name = "TeamInformationButton";
            this.TeamInformationButton.Size = new System.Drawing.Size(430, 43);
            this.TeamInformationButton.TabIndex = 2;
            this.TeamInformationButton.Text = "Информация";
            this.TeamInformationButton.UseVisualStyleBackColor = true;
            this.TeamInformationButton.Click += new System.EventHandler(this.TeamInformationButton_Click);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeamButton.FlatAppearance.BorderSize = 0;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeamButton.Location = new System.Drawing.Point(436, 2);
            this.AddTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(430, 46);
            this.AddTeamButton.TabIndex = 0;
            this.AddTeamButton.Text = "Добавить";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // DeleteTeamButton
            // 
            this.DeleteTeamButton.AutoSize = true;
            this.DeleteTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTeamButton.FlatAppearance.BorderSize = 0;
            this.DeleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTeamButton.Location = new System.Drawing.Point(870, 2);
            this.DeleteTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteTeamButton.Name = "DeleteTeamButton";
            this.DeleteTeamButton.Size = new System.Drawing.Size(430, 43);
            this.DeleteTeamButton.TabIndex = 1;
            this.DeleteTeamButton.Text = "Удалить";
            this.DeleteTeamButton.UseVisualStyleBackColor = true;
            this.DeleteTeamButton.Click += new System.EventHandler(this.DeleteTeamButton_Click);
            // 
            // TeamListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LeftPanel);
            this.Name = "TeamListControl";
            this.Padding = new System.Windows.Forms.Padding(45);
            this.Size = new System.Drawing.Size(1424, 555);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.DataGridView TeamsList;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button TeamInformationButton;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button DeleteTeamButton;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}

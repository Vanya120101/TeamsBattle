
namespace BattleStrategy.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.AuxiliaryButtonsPanel = new System.Windows.Forms.Panel();
            this.MinimizeWindowButton = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PeopleButton = new System.Windows.Forms.Button();
            this.TeamsButton = new System.Windows.Forms.Button();
            this.FightsButton = new System.Windows.Forms.Button();
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.AuxiliaryButtonsPanel.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.TopMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 61);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(886, 796);
            this.ContentPanel.TabIndex = 1;
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
            // AuxiliaryButtonsPanel
            // 
            this.AuxiliaryButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.AuxiliaryButtonsPanel.Controls.Add(this.MinimizeWindowButton);
            this.AuxiliaryButtonsPanel.Controls.Add(this.QuestionButton);
            this.AuxiliaryButtonsPanel.Controls.Add(this.CloseButton);
            this.AuxiliaryButtonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AuxiliaryButtonsPanel.Location = new System.Drawing.Point(636, 0);
            this.AuxiliaryButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuxiliaryButtonsPanel.Name = "AuxiliaryButtonsPanel";
            this.AuxiliaryButtonsPanel.Size = new System.Drawing.Size(250, 61);
            this.AuxiliaryButtonsPanel.TabIndex = 1;
            // 
            // MinimizeWindowButton
            // 
            this.MinimizeWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MinimizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindowButton.ImageKey = "Minimize";
            this.MinimizeWindowButton.ImageList = this.ImageList;
            this.MinimizeWindowButton.Location = new System.Drawing.Point(130, 2);
            this.MinimizeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeWindowButton.Name = "MinimizeWindowButton";
            this.MinimizeWindowButton.Size = new System.Drawing.Size(56, 61);
            this.MinimizeWindowButton.TabIndex = 2;
            this.MinimizeWindowButton.UseVisualStyleBackColor = true;
            // 
            // QuestionButton
            // 
            this.QuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionButton.FlatAppearance.BorderSize = 0;
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.ImageKey = "Question";
            this.QuestionButton.ImageList = this.ImageList;
            this.QuestionButton.Location = new System.Drawing.Point(70, 0);
            this.QuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(56, 61);
            this.QuestionButton.TabIndex = 1;
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ImageKey = "Close";
            this.CloseButton.ImageList = this.ImageList;
            this.CloseButton.Location = new System.Drawing.Point(191, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 61);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.MainMenuPanel.Controls.Add(this.PeopleButton);
            this.MainMenuPanel.Controls.Add(this.TeamsButton);
            this.MainMenuPanel.Controls.Add(this.FightsButton);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(525, 61);
            this.MainMenuPanel.TabIndex = 2;
            // 
            // PeopleButton
            // 
            this.PeopleButton.AutoSize = true;
            this.PeopleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeopleButton.FlatAppearance.BorderSize = 0;
            this.PeopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleButton.ForeColor = System.Drawing.Color.White;
            this.PeopleButton.ImageKey = "Hero.png";
            this.PeopleButton.ImageList = this.ImageList;
            this.PeopleButton.Location = new System.Drawing.Point(2, 2);
            this.PeopleButton.Margin = new System.Windows.Forms.Padding(2);
            this.PeopleButton.Name = "PeopleButton";
            this.PeopleButton.Size = new System.Drawing.Size(172, 61);
            this.PeopleButton.TabIndex = 2;
            this.PeopleButton.Text = "Персонажи";
            this.PeopleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeopleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PeopleButton.UseVisualStyleBackColor = true;
            this.PeopleButton.Click += new System.EventHandler(this.PersonsButton_Click);
            // 
            // TeamsButton
            // 
            this.TeamsButton.AutoSize = true;
            this.TeamsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamsButton.FlatAppearance.BorderSize = 0;
            this.TeamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsButton.ForeColor = System.Drawing.Color.White;
            this.TeamsButton.ImageKey = "Team.png";
            this.TeamsButton.ImageList = this.ImageList;
            this.TeamsButton.Location = new System.Drawing.Point(178, 2);
            this.TeamsButton.Margin = new System.Windows.Forms.Padding(2);
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.Size = new System.Drawing.Size(152, 61);
            this.TeamsButton.TabIndex = 3;
            this.TeamsButton.Text = "Команды";
            this.TeamsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TeamsButton.UseVisualStyleBackColor = true;
            this.TeamsButton.Click += new System.EventHandler(this.TeamsButton_Click);
            // 
            // FightsButton
            // 
            this.FightsButton.AutoSize = true;
            this.FightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FightsButton.FlatAppearance.BorderSize = 0;
            this.FightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightsButton.ForeColor = System.Drawing.Color.White;
            this.FightsButton.ImageKey = "Battle.png";
            this.FightsButton.ImageList = this.ImageList;
            this.FightsButton.Location = new System.Drawing.Point(334, 2);
            this.FightsButton.Margin = new System.Windows.Forms.Padding(2);
            this.FightsButton.Name = "FightsButton";
            this.FightsButton.Size = new System.Drawing.Size(161, 61);
            this.FightsButton.TabIndex = 4;
            this.FightsButton.Text = "Сражения";
            this.FightsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FightsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FightsButton.UseVisualStyleBackColor = true;
            this.FightsButton.Click += new System.EventHandler(this.FightsButton_Click);
            // 
            // TopMainPanel
            // 
            this.TopMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.TopMainPanel.Controls.Add(this.MainMenuPanel);
            this.TopMainPanel.Controls.Add(this.AuxiliaryButtonsPanel);
            this.TopMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMainPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopMainPanel.Name = "TopMainPanel";
            this.TopMainPanel.Size = new System.Drawing.Size(886, 61);
            this.TopMainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 857);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TopMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AuxiliaryButtonsPanel.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.TopMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel AuxiliaryButtonsPanel;
        private System.Windows.Forms.Button MinimizeWindowButton;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.FlowLayoutPanel MainMenuPanel;
        private System.Windows.Forms.Button PeopleButton;
        private System.Windows.Forms.Button TeamsButton;
        private System.Windows.Forms.Button FightsButton;
        private System.Windows.Forms.Panel TopMainPanel;
    }
}
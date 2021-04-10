
namespace BattleStrategy.Views
{
    partial class PersonInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonInformationForm));
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.InnerInformationPanelTwo = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.SpiritBox = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.MindBox = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.Panel();
            this.BodyBox = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.LevelBox = new System.Windows.Forms.Label();
            this.panen = new System.Windows.Forms.Panel();
            this.ClassBox = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.NameBox = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.InnerInformationPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMainPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.InnerInformationPanelTwo.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.fff.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panen.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.InnerInformationPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.TopMainPanel.Size = new System.Drawing.Size(700, 61);
            this.TopMainPanel.TabIndex = 1;
            // 
            // TopMenu
            // 
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMenu.ForeColor = System.Drawing.Color.White;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(644, 61);
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
            this.CloseButton.Location = new System.Drawing.Point(644, 0);
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
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ContentPanel.Controls.Add(this.OkButton);
            this.ContentPanel.Controls.Add(this.InnerInformationPanelTwo);
            this.ContentPanel.Controls.Add(this.ImageBox);
            this.ContentPanel.Controls.Add(this.InnerInformationPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 61);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(700, 389);
            this.ContentPanel.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = true;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(603, 352);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 36);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // InnerInformationPanelTwo
            // 
            this.InnerInformationPanelTwo.AutoSize = true;
            this.InnerInformationPanelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.InnerInformationPanelTwo.Controls.Add(this.panel15);
            this.InnerInformationPanelTwo.Controls.Add(this.panel16);
            this.InnerInformationPanelTwo.Controls.Add(this.fff);
            this.InnerInformationPanelTwo.Controls.Add(this.panel18);
            this.InnerInformationPanelTwo.Controls.Add(this.panen);
            this.InnerInformationPanelTwo.Controls.Add(this.panel20);
            this.InnerInformationPanelTwo.Location = new System.Drawing.Point(421, 25);
            this.InnerInformationPanelTwo.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.InnerInformationPanelTwo.Name = "InnerInformationPanelTwo";
            this.InnerInformationPanelTwo.Size = new System.Drawing.Size(197, 303);
            this.InnerInformationPanelTwo.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.Controls.Add(this.SpiritBox);
            this.panel15.Location = new System.Drawing.Point(0, 250);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(116, 50);
            this.panel15.TabIndex = 5;
            // 
            // SpiritBox
            // 
            this.SpiritBox.AutoSize = true;
            this.SpiritBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpiritBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpiritBox.Location = new System.Drawing.Point(0, 0);
            this.SpiritBox.Name = "SpiritBox";
            this.SpiritBox.Size = new System.Drawing.Size(0, 26);
            this.SpiritBox.TabIndex = 2;
            this.SpiritBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.Controls.Add(this.MindBox);
            this.panel16.Location = new System.Drawing.Point(0, 200);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(116, 50);
            this.panel16.TabIndex = 4;
            // 
            // MindBox
            // 
            this.MindBox.AutoSize = true;
            this.MindBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MindBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MindBox.Location = new System.Drawing.Point(0, 0);
            this.MindBox.Name = "MindBox";
            this.MindBox.Size = new System.Drawing.Size(0, 26);
            this.MindBox.TabIndex = 2;
            this.MindBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fff
            // 
            this.fff.AutoSize = true;
            this.fff.Controls.Add(this.BodyBox);
            this.fff.Location = new System.Drawing.Point(0, 150);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(116, 50);
            this.fff.TabIndex = 3;
            // 
            // BodyBox
            // 
            this.BodyBox.AutoSize = true;
            this.BodyBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BodyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyBox.Location = new System.Drawing.Point(0, 0);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(0, 26);
            this.BodyBox.TabIndex = 2;
            this.BodyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.AutoSize = true;
            this.panel18.Controls.Add(this.LevelBox);
            this.panel18.Location = new System.Drawing.Point(0, 100);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(116, 50);
            this.panel18.TabIndex = 2;
            // 
            // LevelBox
            // 
            this.LevelBox.AutoSize = true;
            this.LevelBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelBox.Location = new System.Drawing.Point(0, 0);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(0, 26);
            this.LevelBox.TabIndex = 2;
            this.LevelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panen
            // 
            this.panen.AutoSize = true;
            this.panen.Controls.Add(this.ClassBox);
            this.panen.Location = new System.Drawing.Point(0, 50);
            this.panen.Name = "panen";
            this.panen.Size = new System.Drawing.Size(190, 50);
            this.panen.TabIndex = 1;
            // 
            // ClassBox
            // 
            this.ClassBox.AutoSize = true;
            this.ClassBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassBox.Location = new System.Drawing.Point(0, 0);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(0, 26);
            this.ClassBox.TabIndex = 2;
            this.ClassBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.AutoSize = true;
            this.panel20.Controls.Add(this.NameBox);
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(194, 50);
            this.panel20.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(0, 0);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(0, 26);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.Color.Silver;
            this.ImageBox.Location = new System.Drawing.Point(58, 25);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(200, 200);
            this.ImageBox.TabIndex = 4;
            this.ImageBox.TabStop = false;
            // 
            // InnerInformationPanel
            // 
            this.InnerInformationPanel.AutoSize = true;
            this.InnerInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.InnerInformationPanel.Controls.Add(this.panel6);
            this.InnerInformationPanel.Controls.Add(this.panel5);
            this.InnerInformationPanel.Controls.Add(this.panel4);
            this.InnerInformationPanel.Controls.Add(this.panel3);
            this.InnerInformationPanel.Controls.Add(this.panel2);
            this.InnerInformationPanel.Controls.Add(this.panel1);
            this.InnerInformationPanel.Location = new System.Drawing.Point(306, 25);
            this.InnerInformationPanel.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.InnerInformationPanel.Name = "InnerInformationPanel";
            this.InnerInformationPanel.Size = new System.Drawing.Size(116, 303);
            this.InnerInformationPanel.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(116, 50);
            this.panel6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Дух:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 50);
            this.panel5.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Разум:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 50);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Тело:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 50);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Уровень:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 50);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Класс:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TopMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonInformationForm";
            this.Text = "PersonInformationForm";
            this.TopMainPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.InnerInformationPanelTwo.ResumeLayout(false);
            this.InnerInformationPanelTwo.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.fff.ResumeLayout(false);
            this.fff.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panen.ResumeLayout(false);
            this.panen.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.InnerInformationPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMainPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel InnerInformationPanelTwo;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label SpiritBox;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label MindBox;
        private System.Windows.Forms.Panel fff;
        private System.Windows.Forms.Label BodyBox;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label LevelBox;
        private System.Windows.Forms.Panel panen;
        private System.Windows.Forms.Label ClassBox;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel InnerInformationPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TopMenu;
    }
}

namespace BattleStrategy.Views.Controls
{
    partial class ChoosingFightControl
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
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstTeamBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondTeamBox = new System.Windows.Forms.ComboBox();
            this.FightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(BattleStrategy.Domain_models.Team);
            // 
            // FirstTeamBox
            // 
            this.FirstTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTeamBox.FormattingEnabled = true;
            this.FirstTeamBox.Location = new System.Drawing.Point(300, 50);
            this.FirstTeamBox.Name = "FirstTeamBox";
            this.FirstTeamBox.Size = new System.Drawing.Size(121, 33);
            this.FirstTeamBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первая команда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторая команда";
            // 
            // SecondTeamBox
            // 
            this.SecondTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTeamBox.FormattingEnabled = true;
            this.SecondTeamBox.Location = new System.Drawing.Point(300, 101);
            this.SecondTeamBox.Name = "SecondTeamBox";
            this.SecondTeamBox.Size = new System.Drawing.Size(121, 33);
            this.SecondTeamBox.TabIndex = 3;
            // 
            // FightButton
            // 
            this.FightButton.AutoSize = true;
            this.FightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FightButton.FlatAppearance.BorderSize = 0;
            this.FightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightButton.Location = new System.Drawing.Point(313, 192);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(108, 36);
            this.FightButton.TabIndex = 20;
            this.FightButton.Text = "Битва";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // FightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondTeamBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstTeamBox);
            this.Name = "FightControl";
            this.Padding = new System.Windows.Forms.Padding(45);
            this.Size = new System.Drawing.Size(1334, 415);
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.ComboBox FirstTeamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SecondTeamBox;
        private System.Windows.Forms.Button FightButton;
    }
}

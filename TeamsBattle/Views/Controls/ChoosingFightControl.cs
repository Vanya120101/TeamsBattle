using BattleStrategy.Domain_models;
using BattleStrategy.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BattleStrategy.Views.Controls
{
    public partial class ChoosingFightControl : UserControl
    {
        //Свойство для установки ссылки для выпадающих списков
        public BindingList<Team> Teams
        {
            set
            {
                this.FirstTeamBox.DataSource = value;
                this.FirstTeamBox.DisplayMember = "Name";

                this.SecondTeamBox.BindingContext = new BindingContext();
                this.SecondTeamBox.DataSource = value;
                this.SecondTeamBox.DisplayMember = "Name";

            }
        }

        //первая команда
        public Team FirstTeam { get => this.FirstTeamBox.SelectedItem as Team; }
        //Вторая команда
        public Team SecondTeam { get => this.SecondTeamBox.SelectedItem as Team; }


        public ChoosingFightControl()
        {
            InitializeComponent();
            Teams teams = new Teams();
            this.Teams = teams.GetTeams();

        }




        //Происходит при нажатии кнопки Битва
        private void FightButton_Click(object sender, EventArgs e)
        {
            
            FightControl fightControl = MainForm.GetFightControl();
            fightControl.Show(FirstTeam, SecondTeam);
        }

    
        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

    

        public new void Show()
        {
            this.BringToFront();
        }

   
    }
}

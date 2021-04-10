using BattleStrategy.Domain_models;
using BattleStrategy.Models;
using System;
using System.Windows.Forms;

namespace BattleStrategy.Views.Controls
{
    public partial class TeamListControl : UserControl
    {
        readonly Teams Teams;
        #region Constructs
        public TeamListControl()
        {
            InitializeComponent();
            Teams = new Teams();
            this.TeamsList.DataSource = Teams.GetTeams();
           

        }

        #endregion

        public new void Show()
        {
            this.BringToFront();
        }



        #region Events
        private void TeamInformationButton_Click(object sender, EventArgs e)
        {
            if (!(TeamsList.CurrentRow.DataBoundItem is Team currentTeam))
            {
                return;
            }

            TeamInformationForm teamInformationForm = new TeamInformationForm();
            teamInformationForm.Show(currentTeam);

        }


        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            if (!(TeamsList.CurrentRow.DataBoundItem is Team currentTeam))
            {
                return;
            }

            Teams.RemoveTeam(currentTeam);
        }

        

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.Show();
        }

        #endregion

    }
}

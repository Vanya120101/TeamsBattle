using BattleStrategy.Domain_models;
using BattleStrategy.Models;
using System;
using System.Windows.Forms;

namespace BattleStrategy.Views.Controls
{
    //Класс для контрола. Все команды.
    public partial class TeamListControl : UserControl
    {
        //Класс для команд. Смотри в класс Teams.
        readonly Teams Teams;
        #region Constructs
        public TeamListControl()
        {
            InitializeComponent();
            Teams = new Teams();

            //В список на форме помещаем все команды из класса Teams.
            this.TeamsList.DataSource = Teams.GetTeams();
           

        }

        #endregion


        //Метод для показа формы
        public new void Show()
        {
            //Данная команда перемещает контрол вперед.
            this.BringToFront();
        }



        #region Events
        //Метод для показа информаци ио команде
        private void TeamInformationButton_Click(object sender, EventArgs e)
        {
            //Проверяем, выделена ли команда
            if (!(TeamsList.CurrentRow.DataBoundItem is Team currentTeam))
            {
                return;
            }
            //Создаем форму для показа инфомрации и показываем её.
            TeamInformationForm teamInformationForm = new TeamInformationForm();
            teamInformationForm.Show(currentTeam);

        }

        //Удаляем команду
        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            if (!(TeamsList.CurrentRow.DataBoundItem is Team currentTeam))
            {
                return;
            }

            Teams.RemoveTeam(currentTeam);
        }

        
        //Добавляем команду
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            //Создаем форму для добавления команды
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.Show();
        }

        #endregion

    }
}

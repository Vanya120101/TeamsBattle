using BattleStrategy.Domain_models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Models
{
    //Класс для всех команд.
    class Teams
    {
        //Список команд
        private static BindingList<Team> TeamsList { get; set; }
        static Teams()
        {

            //Получаем команды.
            TeamsList = SaveLoadService.Load<Team>();
            
        }
        //ДОбавление команды
        public void AddTeam(string name, BindingList<Person> people, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(name))
            {
                errorMessage = "Имя команды не должно быть пустым";
                return;
            }
            if (people.Count < 3)
            {
                errorMessage = "Количество членов команды должно быть не меньше 3";
                return;
            }
            if (people.Count > 6)
            {
                errorMessage = "Количество членов коамнды не должно быть больше 6";
                return;
            }

          
            
            Team team = new Team(name, people);
            TeamsList.Add(team);
            SaveLoadService.Save(TeamsList);
        }

        public void RemoveTeam(Team team)
        {
            TeamsList.Remove(team);
            SaveLoadService.Save(TeamsList);

        }

        public BindingList<Team> GetTeams()
        {
            return TeamsList;
        }
    }


}

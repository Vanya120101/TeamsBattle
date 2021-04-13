using BattleStrategy.Models;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace BattleStrategy.Domain_models
{
    //Класс, отвечающий за команду.
    [Serializable]
    public class Team
    {
        //Имя команды
        public string Name { get; set; }

        // Список персонажей в команде. BindingList - тот же самый лист, только который перерисовывается при изменении. У него под капотом есть функционал, который перерисовывает
        //список в формах при добавлении, удалении и изменнии персонажей.
        public BindingList<Person> People { get; set; }

        //Список для карт бойцов. Не сериализуется.
        [NonSerialized]
        public BindingList<FighterCard> FighterCards;

        //Переменная для указания, что команда проиграла. Нужен для логики работы битвы.
        public bool Loser { get; set; }

        //Мощь. Не реализована.
        public int Power { get; set; }
        //Статистика. Не реализована.
        public int Statistics { get; set; }
        //Количество персонажей в команде. Нужна для логики работы битвы.
        public int Count
        {
            get { return People.Count; }
        }

         //Конструктор по умолчанию для создания команды.
        public Team()
        {

        }

        //Конструктор для создания команды. На вход - имя команды и список персонажей.
        public Team(string name, BindingList<Person> people)
        {
            Name = name;
            People = people;
            Power = 0;
            Statistics = 0;

            //Инициализирует список бойцов.
            FighterCards = new BindingList<FighterCard>();
        }


        //Метод, который вызывается сразу после сериализации. Берет список персонажей из команды, ищет данных персонажей в общем списке персонажей и обновляет команду этими персонажами.
        //Когда мы сохраняем (серилаизуем) членов команды, а после сериализуем, то у нас в ОБЩЕМ списке персонажей персонажи отличаются от персонажей в КОМАНДЕ. Не знаю почему, но тут это исправляется 
        
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            People people = new People();
            BindingList<Person> peopleInTeam = new BindingList<Person>();
            foreach (Person person in people.GetPeople())
            {
                foreach (Person personInTeam in People)
                {
                    if (personInTeam.Name == person.Name)
                    {
                        peopleInTeam.Add(person);
                    }
                }
            }

            People = peopleInTeam;
            FighterCards = new BindingList<FighterCard>();


        }
    }
}

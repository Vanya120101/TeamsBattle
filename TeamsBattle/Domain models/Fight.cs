using BattleStrategy.Views;
using BattleStrategy.Views.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleStrategy.Domain_models
{
    //Класс, отвечающий за битву
    class Fight
    {
        //Команды, участвующие в битве
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }

        //Все люди, участвующие в битве
        public List<Person> People { get; set; }
        //Все карты бойцов, участвующие в битве.
        public List<FighterCard> FighterCards { get; set; }

        //Текущий персонаж, который наносит удар
        public FighterCard CurrentStepCard { get; set; }

        //Персонаж, которому наносится урон
        public FighterCard CurrentEnemyCard { get; set; }

        //Команда победитель
        public Team Winner { get; set; }

        //Нужна для реализации алгоритма битвы
        int step = 0;

        //Конструктор
        public Fight()
        {
            FirstTeam = new Team();
            SecondTeam = new Team();
            People = new List<Person>();
            FighterCards = new List<FighterCard>();
        }

        //Установка команд. Первая команда и вторая команда.

        public void SetTeams(Team firstTeam, Team secondTeam)
        {
            //перед битвой - очищаем список бойцов-карт, список людей, далее идем в команды - очищаем в них список бойцов, устанавливаем команды
            FighterCards.Clear();
            People.Clear();
            firstTeam.FighterCards.Clear();
            secondTeam.FighterCards.Clear();
            FirstTeam = firstTeam;
            SecondTeam = secondTeam;

            //В цикле перебираем всех персонажей в двух командах и заносим их в список людей
            foreach (Person person in FirstTeam.People)
            {
                People.Add(person);
            }

            foreach (Person person in SecondTeam.People)
            {
                People.Add(person);
            }
        }


        //Метод для начала битвы. 
        public void StartFight()
        {
            SetInitiative();
            SortFightersCardsList();
            FirstStep();
        }


        //Установка иницитивы
        public void SetInitiative()
        {
            
            //Класс для рандома
            Random random = new Random();

            //В цикле устанавливаем всем бойцам их инициативу
            foreach (FighterCard fighterCard in FighterCards)
            {
                fighterCard.Initiative = random.Next(0, 20);
                //На каждом бойце вызываем метод StartFight();
                fighterCard.StartFight();
            }
        }


        //Сортируем список всех бойцов по уменьшению по их иницативе. Сортировка пузырьком.
        public void SortFightersCardsList()
        {

            FighterCard fighterCardTemp;
            for (int i = 0; i < FighterCards.Count - 1; i++)
            {
                for (int j = 0; j < FighterCards.Count - 1; j++)
                {
                    if (FighterCards[j].Initiative < FighterCards[j + 1].Initiative)
                    {
                        fighterCardTemp = FighterCards[j + 1];
                        FighterCards[j + 1] = FighterCards[j];
                        FighterCards[j] = fighterCardTemp;
                    }
                }
            }
        }


        //Первый шаг битвы.
        public void FirstStep()
        {
            //Проверяем, есть ли ходящий персонаж. Если нет, то заканчиваем битву
            if (CurrentStepCard != null)
            {
                CurrentStepCard.FinishStep();
            }
            //Првоеряем, каков шаг данного круга битвы. Если больше, чем количество персонажей, начинаем заново. Идем по инициативе.
            if (step >= FighterCards.Count)
            {
                step = 0;
            }
            //Текущий ходящий персонаж - берем из отсортированного списка бойцов
            CurrentStepCard = FighterCards[step];
            
            FighterCards[step].StartStep();
            step++;
        }

        //Второй шаг битвы. Просходит при выборе персонажа, которому наносят урон
        public void SecondStep()
        {
            if (CurrentEnemyCard == null)
            {
                return;
            }

           // CurrentStepCard.DoAnimation();
           //логика нанесение урона
            CurrentEnemyCard.HP = CurrentEnemyCard.HP - CurrentStepCard.GetDamage();
            CurrentStepCard.FinishStep();
            CurrentEnemyCard.FinishStep();
            this.ThirdStep();
        }

        //Третий шаг битвы. 
        public void ThirdStep()
        {
            //Проверяем всех бойцов на отрицательное хп. Если меньше нуля, то удаляем этого бойца из общего списка бойцов. Соответственно, из проверки на иницативу он тоже убирается
            for (int i = 0; i < FighterCards.Count; i++)
            {
                if (FighterCards[i].HP <= 0)
                {
                    FighterCards.Remove(FighterCards[i]);
                }
            }

            FirstTeam.Loser = true;
            SecondTeam.Loser = true;
            //Проверяем, есть ли в команде персонажи с хп больше нуля. Если нет, то команда объявлется НЕпроигавшей
            foreach (FighterCard fighterCard in FirstTeam.FighterCards)
            {
                if (fighterCard.HP > 0)
                {
                    FirstTeam.Loser = false;
                }
            }
            foreach (FighterCard fighterCard in SecondTeam.FighterCards)
            {
                if (fighterCard.HP > 0)
                {
                    SecondTeam.Loser = false;
                }
            }

             //Проверяем, проиграла ли какая-то команда и назначаем победиля.
            if (FirstTeam.Loser == true)
            {
                this.Winner = SecondTeam;
            }
            if (SecondTeam.Loser == true)
            {
                this.Winner = FirstTeam;
            }

            //Проверка победителя.
            if (Winner != null)
            {
                FinalStep();
                return;
            }
            //Возвращаемся к первому шагу.
            this.FirstStep();
        }

        //Последний шаг битвы.
        public void FinalStep()
        {
            //Каждому персонажу в команде победителя даем 100 опыта.
            foreach (Person person in Winner.People)
            {
                person.GetExperience(100);
              

            }
            //Объявляем победителя, а также чистим класс битвы для последующих битв
            MessageBox.Show("Команда " + Winner.Name + "победила");
            FirstTeam.Loser = false;
            SecondTeam.Loser = false;
            CurrentEnemyCard = null;
            CurrentStepCard = null;
            FighterCards.Clear();
            Winner = null;
            step = 0;
            FirstTeam = null;
            SecondTeam = null;

            //FormService.ShowForm(Forms.ChoosingFightForm);

            //Вызываем контрол для выбора битв.
            ChoosingFightControl choosingFightControl = MainForm.GetChoosingFight();
            choosingFightControl.Show();

        }


    }
}

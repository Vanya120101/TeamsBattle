using BattleStrategy.Models;
using BattleStrategy.Views;
using BattleStrategy.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleStrategy.Domain_models
{
    class Fight
    {
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }
        public List<Person> People { get; set; }
        public List<FighterCard> FighterCards { get; set; }
        public FighterCard CurrentStepCard { get; set; }
        public FighterCard CurrentEnemyCard { get; set; }
        public Team Winner { get; set; }


        int step = 0;
        public Fight()
        {
            FirstTeam = new Team();
            SecondTeam = new Team();
            People = new List<Person>();
            FighterCards = new List<FighterCard>();
        }

        public void SetTeams(Team firstTeam, Team secondTeam)
        {
            FighterCards.Clear();
            People.Clear();
            firstTeam.FighterCards.Clear();
            secondTeam.FighterCards.Clear();
            FirstTeam = firstTeam;
            SecondTeam = secondTeam;

            foreach (Person person in FirstTeam.People)
            {
                People.Add(person);
            }

            foreach (Person person in SecondTeam.People)
            {
                People.Add(person);
            }
        }

        public void StartFight()
        {
            SetInitiative();
            SortFightersCardsList();
            FirstStep();
        }



        public void SetInitiative()
        {
            

            Random random = new Random();
            foreach (FighterCard fighterCard in FighterCards)
            {
                fighterCard.Initiative = random.Next(0, 20);
                fighterCard.StartFight();
            }
        }

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

        public void FirstStep()
        {
            if (CurrentStepCard != null)
            {
                CurrentStepCard.FinishStep();
            }
            if (step >= FighterCards.Count)
            {
                step = 0;
            }
            CurrentStepCard = FighterCards[step];
            FighterCards[step].StartStep();
            step++;
        }

        public void SecondStep()
        {
            if (CurrentEnemyCard == null)
            {
                return;
            }

           // CurrentStepCard.DoAnimation();
            CurrentEnemyCard.HP = CurrentEnemyCard.HP - CurrentStepCard.GetDamage();
            CurrentStepCard.FinishStep();
            CurrentEnemyCard.FinishStep();
            this.ThirdStep();
        }

        public void ThirdStep()
        {
            for (int i = 0; i < FighterCards.Count; i++)
            {
                if (FighterCards[i].HP <= 0)
                {
                    FighterCards.Remove(FighterCards[i]);
                }
            }

            FirstTeam.Loser = true;
            SecondTeam.Loser = true;
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

            if (FirstTeam.Loser == true)
            {
                this.Winner = SecondTeam;
            }
            if (SecondTeam.Loser == true)
            {
                this.Winner = FirstTeam;
            }

            if (Winner != null)
            {
                FinalStep();
                return;
            }
            this.FirstStep();
        }

        public void FinalStep()
        {
            foreach (Person person in Winner.People)
            {
                person.GetExperience(100);
              

            }

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
            ChoosingFightControl choosingFightControl = MainForm.GetChoosingFight();
            choosingFightControl.Show();

        }


    }
}

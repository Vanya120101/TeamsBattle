using BattleStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Domain_models
{
    [Serializable]

    public class Team
    {
        public string Name { get; set; }

        public BindingList<Person> People { get; set; }
        [NonSerialized]
        public BindingList<FighterCard> FighterCards;

        public bool Loser { get; set; }

        public int Power { get; set; }
        public int Statistics { get; set; }
        public int Count
        {
            get { return People.Count; }
        }

        public Team()
        {

        }
        public Team(string name, BindingList<Person> people)
        {
            Name = name;
            People = people;
            Power = 0;
            Statistics = 0;
            FighterCards = new BindingList<FighterCard>();
        }



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

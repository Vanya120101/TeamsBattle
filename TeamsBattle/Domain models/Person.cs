using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Domain_models
{
    [Serializable]

    public class Person
    {
        public string Name { get; set; }
        public string PersonClass { get; }
        public int Level { get; set; }
        public int Mind { get; set; }
        public int Body { get; set; }
        public int Spirit { get; set; }
        public int Experience { get; set; }
        private int StartBody { get; set; }
        private int StartMind { get; set; }
        private int StartSpirit { get; set; }



        public Person(string name, string personClass, int body, int mind, int spirit)
        {
            Name = name;
            PersonClass = personClass;
            Level = 1;

            StartBody = body;
            StartMind = mind;
            StartSpirit = spirit;

            Renewal();
            Experience = 0;
        }

        public void GetExperience(int experience)
        {
            Experience += experience ;
            LevelUp();
        }

        private void LevelUp()
        {
            Level = (Experience / (10 )) + 1;
            Renewal();
        }
        
        private void Renewal()
        {
            if (Level == 1)
            {
                Body = StartBody;
                Mind = StartMind;
                Spirit = StartSpirit;
                return;
            }

            Body = StartBody + Level * 2;
            Mind = StartMind + Level * 2;
            Spirit = StartSpirit + Level * 2;

        }

       
        





    }
}

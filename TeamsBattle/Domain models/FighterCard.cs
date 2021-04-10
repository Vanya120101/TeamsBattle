using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleStrategy.Domain_models
{
    public class FighterCard
    {
        public Person Person { get; set; }
        public Panel Panel { get; set; }
        public Team Team { get; set; }

        private float hp;
        public float HP
        {
            get
            {

                return hp;
            }
            set
            {
                this.hp = value;
                Panel.Controls[1].Text = HP.ToString();

            }
        }
        public Image Image { get; set; }
        public bool HadStep { get; set; }
        public int Initiative { get; set; }

        public string Tag { get; set; }

        public bool isStep = false;


        public FighterCard(Person person, Panel panel, Team team)
        {
            Person = person;
            Panel = panel;
            Team = team;

           

        }

        public void StartFight()
        {
            Panel.Visible = true;
            HP = Person.Body * 2 + 5;
            HadStep = false;
            Panel.Controls[2].Text = Person.Name;
            Panel.Controls[1].Text = HP.ToString();
            Tag = Panel.Controls[0].Tag.ToString();

        }

        public void StartStep()
        {
            Panel.Controls[2].BackColor = Color.Green;
        }

        public void FinishStep()
        {
            Panel.Controls[2].BackColor = Color.White;
            if (HP <= 0)
            {
                HP = 0;
                FighterDead();
            }
            Panel.Controls[1].Text = HP.ToString();

        }

        public float GetDamage()
        {
            isStep = true;
            if (Person.PersonClass == "Воин")
            {
                return (float)(0.1 * Person.Body);
            }
            if (Person.PersonClass == "Маг")
            {
                return (float)(0.5 * Person.Spirit);
            }
            if (Person.PersonClass == "Хиллер")
            {
                foreach (FighterCard fighterCard in Team.FighterCards)
                {
                    if (fighterCard.HP > 0)
                    {
                        fighterCard.HP = +fighterCard.HP + (float)(0.5 * Person.Spirit);
                    }
                }

                return 0;
            }
            return 0;
        }

        public void Update()
        {
        }

        public void FighterDead()
        {
            Panel.Visible = false;
        }


      


    }
}

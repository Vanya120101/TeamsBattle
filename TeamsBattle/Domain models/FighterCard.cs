using System.Drawing;
using System.Windows.Forms;

namespace BattleStrategy.Domain_models
{
    //Класс для карточки-бойца. Это, по сути, обертка для персонажа, которая и будет участвовать вместо персонажа.
    public class FighterCard
    {
        //Устанавливаем персонажа для данной карточки-бойцы
        public Person Person { get; set; }
        //Устанавливаем Панель - то есть, место на форме, где будет располагаться данный боев
        public Panel Panel { get; set; }

        //команда, к которой принадлежит данный боев
        public Team Team { get; set; }

        //Хп данного бойцы
        private float hp;
        //Ха данного бойца
        public float HP
        {
            get
            {

                return hp;
            }
            set
            {
                //Устанавливает текущее хп, а также устанавливает его на форму.
                this.hp = value;
                Panel.Controls[1].Text = HP.ToString();

            }
        }
        //изображение для бойца. Не реализовано
        public Image Image { get; set; }
        //Булево свойство, показываюещее, ходил ли данный персонаж
        public bool HadStep { get; set; }

        //Инициатива
        public int Initiative { get; set; }
        //Тэг для данного бойца.
        public string Tag { get; set; }
        //свойство, показывающее, шаг ли бойца
        public bool isStep = false;

        //конструктор
        public FighterCard(Person person, Panel panel, Team team)
        {
            Person = person;
            Panel = panel;
            Team = team;

           

        }


        //Метод для старта битвы.
        public void StartFight()
        {
            //Панель данного бойца - показать на форме.
            Panel.Visible = true;
            //Установить хп бойца.
            HP = Person.Body * 2 + 5;

            //
            HadStep = false;

            //Установка имени, хп на форме для данного персонажа. Тэг нужен для алгоритма
            Panel.Controls[2].Text = Person.Name;
            Panel.Controls[1].Text = HP.ToString();
            Tag = Panel.Controls[0].Tag.ToString();

        }

        //Показывает, что начался шаг данного бойыа. То есть, он наносит урон
        public void StartStep()
        {
            // Меняем цвет карточки на зеленый
            Panel.Controls[2].BackColor = Color.Green;
        }


        //Метод для завершения хода данного персонажа. 
        public void FinishStep()
        {
            //Ставим цвет карточки в белый, проверяем хп, если меньше - вызываем метод для смерти
            Panel.Controls[2].BackColor = Color.White;
            if (HP <= 0)
            {
                HP = 0;
                FighterDead();
            }

            //Устанавливаем текущее хп на форму
            Panel.Controls[1].Text = HP.ToString();

        }
        
        //Удар персонажа
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

        //убираем карточку персонажа с формы
        public void FighterDead()
        {
            Panel.Visible = false;
        }


      


    }
}

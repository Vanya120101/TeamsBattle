using System;

namespace BattleStrategy.Domain_models
{
    //Класс, отвечающий за Person
    //Атрибут, который показывает, что класс можно сериализовать
    [Serializable]
    public class Person
    {
        //Атрибуты персонажа
        public string Name { get; set; }
        public string PersonClass { get; }
        public int Level { get; set; }
        public int Mind { get; set; }
        public int Body { get; set; }
        public int Spirit { get; set; }
        public int Experience { get; set; }

        //Атрибуты, в которых сохраняется значения персонажа при его создании. Нужно для алгоритма лвлапа.
        private int StartBody { get; set; }
        private int StartMind { get; set; }
        private int StartSpirit { get; set; }


        //Конструктор, который используем для создания Person. Передаем имя, класс персонажа, тело, разум и дух
        
        public Person(string name, string personClass, int body, int mind, int spirit)
        {
            Name = name;
            PersonClass = personClass;
            Level = 1;

            StartBody = body;
            StartMind = mind;
            StartSpirit = spirit;


            //Вызываем метод Renewal, чтобы произвести лвлап на первый уровень. Пока что основные параметры персонажа равны нулю
            Renewal();
            Experience = 0;
        }

        //Метод для передачи персонажу опыта. Входной параметр - опыт. 
        public void GetExperience(int experience)
        {
            Experience += experience ;
            //Вызываем метод, который отвечает за логику лвлапа.
            LevelUp();
        }

        //Метод для повышения уровня.
        private void LevelUp()
        {
            Level = (Experience / (10 )) + 1;
            //Вызываем метод, чтобы сделать характеристики соответственно уровню.
            Renewal();
        }
        
        //Метод для установки характеристик соотвветственно уровню.
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

using BattleStrategy.Domain_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Models
{
    //Класс для работы со всеми персонажами
    class People
    {
        //Список персонажей. Статическое свойство. Для всех экземляров данного класса оно одно. Неизменно.
        private static BindingList<Person> PeopleList { get; set; }
        //Лист классов
        public string[] ListOfClass { get; set; }

        //Статичческий конструктор. Отрабатывает раньше всего. 
        static People()
        {

            //Загружает список персонажей.
            PeopleList = SaveLoadService.Load<Person>();
            
        }

        //Обычный конструктор. Загружает классы персонажей
        public People()
        {
            ListOfClass = new string[3] { "Воин", "Маг", "Хиллер" };
        }


        //ДОбавление персонажа
        public void AddPerson(string name, string personClass, int body, int mind, int spirit, out string errorMessage)
        {
            errorMessage = "";
            //Првоерка, существует ли персонаж с таким именем
            Person exsistPerson = PeopleList.FirstOrDefault(p => p.Name == name);
            if (exsistPerson != null)
            {
                errorMessage = "Персонаж с таким именем уже существует";
                return;
            }

            //Прочие проверки
            if (string.IsNullOrEmpty(name))
            {
                errorMessage = "Имя не должно быть пустым";
                return;
            }
            if (string.IsNullOrEmpty(personClass))
            {
                errorMessage = "Класс не должен быть пустым";
                return;
            }
            if (body < 5)
            {
                errorMessage = "Параметр body не должен быть меньше 5";
                return;
            }
            if (mind < 5)
            {
                errorMessage = "Параметр mind не должен быть меньше пяти";
                return;
            }
            if (spirit < 5)
            {
                errorMessage = "Парметр spirit не должен быть меньше пять";
                return;
            }
            if (!(body + spirit + mind <=20))
            {
                errorMessage = "Сумма параметров body, mind, spirit не может превышать 20";
                return;
            }

            //Создание персонажа, добавление в список, а также сохранение данного списка
            Person person = new Person(name, personClass, body, mind, spirit);
            PeopleList.Add(person);
            SaveLoadService.Save(PeopleList);

        }

        //Удаление персонажа
        public void RemovePerson(Person person)
        {
            PeopleList.Remove(person);
            SaveLoadService.Save(PeopleList);

        }

        //Метод, который позволяет получить персонажей
        public BindingList<Person> GetPeople()
        {
            return PeopleList;
        }
    }
}

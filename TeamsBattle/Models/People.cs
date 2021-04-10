using BattleStrategy.Domain_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Models
{
    class People
    {
        private static BindingList<Person> PeopleList { get; set; }
        public string[] ListOfClass { get; set; }
        static People()
        {
            PeopleList = SaveLoadService.Load<Person>();
            
        }
        public People()
        {
            ListOfClass = new string[3] { "Воин", "Маг", "Хиллер" };
        }

        public void AddPerson(string name, string personClass, int body, int mind, int spirit, out string errorMessage)
        {
            errorMessage = "";

            Person exsistPerson = PeopleList.FirstOrDefault(p => p.Name == name);
            if (exsistPerson != null)
            {
                errorMessage = "Персонаж с таким именем уже существует";
                return;
            }

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


            Person person = new Person(name, personClass, body, mind, spirit);
            PeopleList.Add(person);
            SaveLoadService.Save(PeopleList);

        }

        public void RemovePerson(Person person)
        {
            PeopleList.Remove(person);
            SaveLoadService.Save(PeopleList);

        }

        public BindingList<Person> GetPeople()
        {
            return PeopleList;
        }
    }
}

using BattleStrategy.Domain_models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BattleStrategy.Models
{
    //класс для сериализаци и десериализации. Статический. Значит, что не нужно создавать экземляр класса. Можно использовать через тип класса. Через обычное название. 
    //SaveLoadService.Load();
    static class SaveLoadService
    {
       
        //Метод для десериализации. 
        public static BindingList<T> Load<T>() where T : class
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is BindingList<T> items)
                {
                    return items;
                }
                else
                {
                    return new BindingList<T>();
                }
            }
        }

        public static void Save<T>(BindingList<T> items)
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T).Name;
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, items);
            }
        }


       
    }
}

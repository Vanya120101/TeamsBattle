using BattleStrategy.Views;
using System;
using System.Windows.Forms;

namespace BattleStrategy
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///Метод, с которого начинается приложение. Точка входа в приложение.
        [STAThread]
        static void Main()
        {
            //Настройка формы: включение стилей и ещё что-то непонятное.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Запуск первой формы. Здесь назначается главная форма. Закроется она - закроются все остальные.
            Application.Run(new MainForm());




        }
    }
}

using BattleStrategy.Views.Controls;
using System;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    //Главная форма
    public partial class MainForm : Form
    {

         //Список контролов. Из папки Controls.
        static TeamListControl TeamListControl;
        static PeopleListControl PeopleListControl;
        static ChoosingFightControl ChoosingFightControl;
        static FightControl FightControl;

        
        #region Constructs
        public MainForm()
        {
            //Инициализируем форму.
            InitializeComponent();

            //Инициализируем контролы.
            TeamListControl = new TeamListControl();
            PeopleListControl = new PeopleListControl();
            ChoosingFightControl = new ChoosingFightControl();
            FightControl = new FightControl();


            // Добавляем контролы
            AddControl(TeamListControl);
            AddControl(PeopleListControl);
            AddControl(ChoosingFightControl);
            AddControl(FightControl);


        }

        #endregion

        //Добавляем контролы в панель для контента.
        public void AddControl(UserControl control)
        {
            this.ContentPanel.Controls.Add(control);

            //Делаем, чтобы контрол заполнял всю область места для контента
            control.Dock = DockStyle.Fill;
        }


        #region Events
        //событие для закрытия
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //Переключение на контрол для списка персонажей
        private void PersonsButton_Click(object sender, EventArgs e)
        {
            //Вызываем метод контроле. 
            PeopleListControl.Show();
        }

        //Аналогично выше
        private void TeamsButton_Click(object sender, EventArgs e)
        {
            TeamListControl.Show();
        }
        //Аналогично выше

        private void FightsButton_Click(object sender, EventArgs e)
        {
            ChoosingFightControl.Show();
        }

        //Метод для получения  FightControl. Нужен для логики битвы
        static public FightControl GetFightControl()
        {
            return FightControl;
        }

        //аналогично выше
        static public ChoosingFightControl GetChoosingFight()
        {
           return ChoosingFightControl;

        }
        //Не реализован
        private void QuestionButton_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}

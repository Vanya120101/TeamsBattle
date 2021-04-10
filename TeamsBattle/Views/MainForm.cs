using BattleStrategy.Views.Controls;
using System;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    public partial class MainForm : Form
    {
        static TeamListControl TeamListControl;
        static PeopleListControl PeopleListControl;
        static ChoosingFightControl ChoosingFightControl;
        static FightControl FightControl;

        
        #region Constructs
        public MainForm()
        {
            InitializeComponent();
            TeamListControl = new TeamListControl();
            PeopleListControl = new PeopleListControl();
            ChoosingFightControl = new ChoosingFightControl();
            FightControl = new FightControl();

            AddControl(TeamListControl);
            AddControl(PeopleListControl);
            AddControl(ChoosingFightControl);
            AddControl(FightControl);


        }

        #endregion


        public void AddControl(UserControl control)
        {
            this.ContentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }


        #region Events
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void PersonsButton_Click(object sender, EventArgs e)
        {
            PeopleListControl.Show();
        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            TeamListControl.Show();
        }

        private void FightsButton_Click(object sender, EventArgs e)
        {
            ChoosingFightControl.Show();
        }
        static public FightControl GetFightControl()
        {
            return FightControl;
        }

        static public ChoosingFightControl GetChoosingFight()
        {
           return ChoosingFightControl;

        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}

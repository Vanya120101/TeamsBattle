using BattleStrategy.Domain_models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    public partial class TeamInformationForm : Form
    {

        #region Constructs
        public TeamInformationForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       


        private Point moveStart;

        private void TopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);

            }
        }
      

      
        #endregion

        public void Show(Team team)
        {
            this.TeamNameBox.Text = team.Name;


            this.PeopleList.DataSource = team.People;

            base.ShowDialog();
        }



    }
}

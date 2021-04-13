using BattleStrategy.Domain_models;
using BattleStrategy.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    public partial class AddTeamForm : Form
    {
        readonly People People;
        readonly Teams Teams;
        #region Constructs
        public AddTeamForm()
        {
            InitializeComponent();
            People = new People();
            Teams = new Teams();
            this.PeopleList.DataSource = People.GetPeople();

        }
        #endregion



        
        public BindingList<Person> SelectedPeople

        {
            get
            {
                BindingList<Person> people = new BindingList<Person>();

                foreach (DataGridViewRow person in this.PeopleList.SelectedRows)
                {
                    people.Add(person.DataBoundItem as Person);
                }

                return people;
                    
                
            }
        }

      

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



        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            Teams.AddTeam(NameBox.Text, SelectedPeople, out string errorMessage);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            this.Close();
        }



       
        #endregion




    }

}

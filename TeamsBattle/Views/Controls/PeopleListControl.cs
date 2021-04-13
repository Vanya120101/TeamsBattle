using BattleStrategy.Domain_models;
using BattleStrategy.Models;
using System;
using System.Windows.Forms;

namespace BattleStrategy.Views.Controls
{
    public partial class PeopleListControl : UserControl
    {
        readonly People People;
        #region Constructs
        public PeopleListControl()
        {
            InitializeComponent();
            People = new People();
            this.PeopleList.DataSource = People.GetPeople();
        }



        #endregion
       

        #region Events

        public new void Show()
        {
            this.BringToFront();
        }
        private void PersonInformationButton_Click(object sender, EventArgs e)
        {

            Person currentPerson = (Person)PeopleList.CurrentRow.DataBoundItem;
            if (currentPerson == null)
            {
                return;
            }
            PersonInformationForm personInformationForm = new PersonInformationForm();
            personInformationForm.Show(currentPerson);

         
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (!(PeopleList.CurrentRow.DataBoundItem is Person currentPerson))
            {
                return;
            }
            People.RemovePerson(currentPerson);
        }






        //Метод, который вызывается при изменении выделения команд
        private void PeopleList_SelectionChanged(object sender, EventArgs e)
        {
            if (PeopleList.CurrentRow == null)
            {
                return;
            }
            if (!(PeopleList.CurrentRow.DataBoundItem is Person currentPerson))
            {
                this.NameBox.Text = "";
                this.ClassBox.Text = "";
                this.LevelBox.Text = 0.ToString();
                this.MindBox.Text = 0.ToString();
                this.BodyBox.Text = 0.ToString();
                this.SpiritBox.Text = 0.ToString();
                return;
            }

            this.NameBox.Text = currentPerson.Name;
            this.ClassBox.Text = currentPerson.PersonClass;
            this.LevelBox.Text = currentPerson.Level.ToString();
            this.MindBox.Text = currentPerson.Mind.ToString();
            this.BodyBox.Text = currentPerson.Body.ToString();
            this.SpiritBox.Text = currentPerson.Spirit.ToString();
        }



        //Метод, когда происходит двойной щелчек по челвоеку
        private void PeopleList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Person currentPerson = (Person)PeopleList.CurrentRow.DataBoundItem;
            if (currentPerson == null)
            {
                return;
            }
            PersonInformationForm personInformationForm = new PersonInformationForm();
            personInformationForm.Show(currentPerson);
        }

        #endregion

    }
}

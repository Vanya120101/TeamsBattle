using BattleStrategy.Domain_models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    public partial class PersonInformationForm : Form
    {
        #region Constructs
        public PersonInformationForm()
        {
            InitializeComponent();
        }

        #endregion


        public void Show(Person person)
        {
            this.NameBox.Text = person.Name;
            this.ClassBox.Text = person.PersonClass;
            this.LevelBox.Text = person.Level.ToString();
            this.BodyBox.Text = person.Body.ToString();
            this.MindBox.Text = person.Mind.ToString();
            this.SpiritBox.Text = person.Spirit.ToString();
            base.ShowDialog();
        }

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


      
    }
}

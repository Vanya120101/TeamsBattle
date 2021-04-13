using BattleStrategy.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleStrategy.Views
{
    public partial class AddPersonForm : Form
    {
        readonly People People;

        #region Constructs
        public AddPersonForm()
        {
            InitializeComponent();
            People = new People();
         
        }
        #endregion











        //Методы ддля перемещения формы. 
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





        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Метод для рандомного создания персонажа
        private void CreateRandomPersonButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            ClassBox.Text = People.ListOfClass[random.Next(0, 3)];

            string name;
            switch (random.Next(1, 7))
            {
                case 1:
                    name = "Алиса";
                    break;
                case 2:
                    name = "Беатрисс";
                    break;
                case 3:
                    name = "Венди";
                    break;
                case 4:
                    name = "Розвель";
                    break;
                case 5:
                    name = "Питер";
                    break;
                case 6:
                    name = "Джерар";
                    break;
                default:
                    name = "Неизвестный";
                    break;
            }
            this.NameBox.Text = name;
            int result = 0;
            int body = 0;
            int spirit = 0;
            int mind = 0;
            while (result != 20)
            {
                body = random.Next(5, 11);
                spirit = random.Next(5, 11);
                mind = random.Next(5, 11);
                result = body + spirit + mind;

            }
            this.BodyBox.Text = body.ToString();
            this.SpiritBox.Text = spirit.ToString();
            this.MindBox.Text = mind.ToString();



        }

        //Создание персонажа
        private void CreatePersonButton_Click(object sender, EventArgs e)
        {
            string name = this.NameBox.Text;
            string personClass = this.ClassBox.Text;
          
            if (!int.TryParse(BodyBox.Text, out int body))
            {
                return;
            }
            if (!int.TryParse(MindBox.Text, out int mind))
            {
                return;
            }
            if (!int.TryParse(SpiritBox.Text, out int spirit))
            {
                return;
            }

            People.AddPerson(name, personClass, body, mind, spirit, out string errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            this.Close();
        }
    }
}

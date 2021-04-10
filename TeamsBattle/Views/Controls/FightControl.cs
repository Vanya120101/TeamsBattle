using BattleStrategy.Domain_models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleStrategy.Views.Controls
{
    public partial class FightControl : UserControl
    {
        readonly Fight Fight;
        public List<Panel> FirstTeamPanels { get; set; }
        public List<Panel> SecondTeamPanels { get; set; }
        public string FirstTeamName { set => this.FirstTeamNameBox.Text = value; }
        public string SecondTeamName { set => this.SecondTeamNameBox.Text = value; }
        public string SelectedPerson { get; set; }

        public FightControl()
        {
            InitializeComponent();

            FirstTeamPanels = new List<Panel>();
            SecondTeamPanels = new List<Panel>();
            Fight = new Fight();
            Initialize();



            



        }
        private void Initialize()
        {

            FirstTeamPanels.Add(PanelPerson1);
            FirstTeamPanels.Add(PanelPerson2);
            FirstTeamPanels.Add(PanelPerson3);
            FirstTeamPanels.Add(PanelPerson4);
            FirstTeamPanels.Add(PanelPerson5);
            FirstTeamPanels.Add(PanelPerson6);

            SecondTeamPanels.Add(EPanelPerson1);
            SecondTeamPanels.Add(EPanelPerson2);
            SecondTeamPanels.Add(EPanelPerson3);
            SecondTeamPanels.Add(EPanelPerson4);
            SecondTeamPanels.Add(EPanelPerson5);
            SecondTeamPanels.Add(EPanelPerson6);

            Clear();


        }
        public void Show(Team FirstTeam, Team SecondTeam)
        {
            this.BringToFront();
            
            Fight.SetTeams(FirstTeam, SecondTeam);
            this.PrepareForFight();
            Fight.StartFight();
         
        }

        private void PrepareForFight()
        {
            this.Clear();
            for (int i = 0; i < Fight.FirstTeam.Count; i++)
            {
                FighterCard fighterCard = new FighterCard(Fight.FirstTeam.People[i], this.FirstTeamPanels[i], Fight.FirstTeam);
                Fight.FighterCards.Add(fighterCard);
                Fight.FirstTeam.FighterCards.Add(fighterCard);
            }

            for (int i = 0; i < Fight.SecondTeam.Count; i++)
            {
                FighterCard fighterCard = new FighterCard(Fight.SecondTeam.People[i], this.SecondTeamPanels[i], Fight.SecondTeam);
                Fight.FighterCards.Add(fighterCard);
                Fight.SecondTeam.FighterCards.Add(fighterCard);
            }


        }

        private void EnemyFight_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            SelectedPerson = pictureBox.Tag.ToString();


            foreach (FighterCard fighterCard in Fight.FighterCards)
            {
                if (fighterCard.Tag == SelectedPerson)
                {
                    if (fighterCard.Team == Fight.CurrentStepCard.Team)
                    {
                        this.ShowErrorMessage("Для атаки выберите персонажа из другой команды!");
                        return;
                    }
                    Fight.CurrentEnemyCard = fighterCard;
                }
            }

            Fight.SecondStep();


        }

        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        public void Clear()
        {
            foreach (Panel panel in FirstTeamPanels)
            {
                panel.Visible = false;
            }

            foreach (Panel panel in SecondTeamPanels)
            {
                panel.Visible = false;
            }
        }

       


      



    }
}

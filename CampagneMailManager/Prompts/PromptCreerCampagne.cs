using BusinesssCampagneMail.DAO.implementations;
using BusinesssCampagneMail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CampagneMailManager.Prompts
{
    public partial class PromptCreerCampagne : Form
    {
        private CampagneDAO campagneDAO;
        private Home home;
        public PromptCreerCampagne(CampagneDAO campagneDAO, Home home)
        {
            InitializeComponent();
            this.campagneDAO = campagneDAO;
            this.home = home;
        }

        private void button_creer_campagne_Click(object sender, EventArgs e)
        {
            if (textbox_nom_campagne.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez siasir un nom de campagne", "Erreur_Creation_Campagne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Campagne campagne = new Campagne(textbox_nom_campagne.Text);
                if (this.campagneDAO.Add(campagne))
                {
                    this.home.chargerCampagne();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Impossible de créer la campagne !", "Erreur_Creation_Campagne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void prompt_cree_campagne_Load(object sender, EventArgs e)
        {

        }
    }
}

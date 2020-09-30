using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinesssCampagneMail.DAO.implementations;
using BusinesssCampagneMail.Models;
using CampagneMailManager.Prompts;

namespace CampagneMailManager
{
    public partial class Home : Form
    {
        private CampagneDAO campagneDAO;
        public Home()
        {
            InitializeComponent();
            this.campagneDAO = new CampagneDAO();
        }

        public void Home_Load(object sender, EventArgs e)
        {
            chargerCampagne();
        }

        private void button_cree_campagne_Click(object sender, EventArgs e)
        {
            PromptCreerCampagne prompt = new PromptCreerCampagne(this.campagneDAO, this);
            prompt.ShowDialog();
        }

        public void chargerCampagne()
        {
            _listview_campagnes.Items.Clear();
            foreach (Campagne campagne in campagneDAO.GetAll())
            {
                ListViewItem item = new ListViewItem(campagne.nom);
                item.Tag = campagne ;
                _listview_campagnes.Items.Add(item);
            }
        }

        private void _listview_campagnes_Click(object sender, EventArgs e)
        {
            if (_listview_campagnes.SelectedItems.Count >= 1)
            {
                ListViewItem item = _listview_campagnes.SelectedItems[0];

                ManageCampagne manageCampagne = new ManageCampagne(this, (Campagne)item.Tag);
                manageCampagne.Show();
                this.Hide();
            }
        }

        private void _listview_campagnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

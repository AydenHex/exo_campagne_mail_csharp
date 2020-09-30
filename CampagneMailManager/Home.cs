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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Home_Load(object sender, EventArgs e)
        {
            chargerCampagne();
        }

        private void button_cree_campagne_Click(object sender, EventArgs e)
        {
            PromptCreerCampagne prompt = new PromptCreerCampagne(this.campagneDAO, this);
        }

        public void chargerCampagne()
        {
            _listview_campagnes.Items.Clear();
            foreach (Campagne campagne in campagneDAO.GetAll())
            {
                ListViewItem item = new ListViewItem(campagne.nom);
                item.Tag = campagne.id;
                _listview_campagnes.Items.Add(item);
            }
        }
    }
}

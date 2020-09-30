using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinesssCampagneMail.DAO.implementations;
using BusinesssCampagneMail.Models;
using BusinesssCampagneMail.Service;

namespace CampagneMailManager
{
    public partial class ManageCampagne : Form
    {
        private Campagne campagne;
        private Home home;
        private CampagneDAO campagneDAO;
        private MailDAO mailDAO;
        private MailImporter mailImporter;
        
        public ManageCampagne(Home home, Campagne campagne)
        {
            InitializeComponent();
            this.campagneDAO = new CampagneDAO();
            this.mailDAO = new MailDAO();
            this.campagne = campagne;
            this.home = home;
            this.mailImporter = MailImporter.Instance;
            label_campagne_nom.Text = label_campagne_nom.Text + this.campagne.nom;
        }

        private void button_add_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                switch (fileDialog.FileName.Substring(fileDialog.FileName.Length - 3))
                {
                    case "csv":
                        campagne.mails.AddRange(this.mailImporter.GetMailsFromCSV(fileDialog.FileName, campagne.id));
                        this.loadMails();
                        break;
                    case "txt":
                        campagne.mails.AddRange(this.mailImporter.GetMailsFromText(fileDialog.FileName, campagne.id));
                        this.loadMails();
                        break;
                    default:
                        MessageBox.Show("Veuillez choisisr un fichier txt ou csv", "error_file_selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void loadMails() 
        {
            _listview_mails.Items.Clear();
            foreach(Mail mail in campagne.mails)
            {
                ListViewItem item = new ListViewItem(mail.nom);
                item.SubItems.Add(mail.prenom);
                item.SubItems.Add(mail.email);
                item.Tag = mail;

                _listview_mails.Items.Add(item);
            }
        }

        private void ManageCampagne_Load(object sender, EventArgs e)
        {
            this.loadMails();
        }

        private void button_sauvegarde_Click(object sender, EventArgs e)
        {
            foreach(Mail mail in this.campagne.mails)
            {
                if (!this.mailDAO.Add(mail))
                {
                    MessageBox.Show("Le mail : " + mail.email + " n'a pas pu être sauvager", "error_save_mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Sauvegarde terminée", "save_ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

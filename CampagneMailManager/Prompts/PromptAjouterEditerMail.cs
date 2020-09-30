using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinesssCampagneMail.Models;
using BusinesssCampagneMail.DAO.implementations;
using BusinesssCampagneMail.Service;

namespace CampagneMailManager.Prompts
{
    public partial class PromptAjouterEditerMail : Form
    {
        private MailDAO mailDAO;
        private Mail mail;
        private int campagneId;
        public PromptAjouterEditerMail(Mail mail)
        {
            InitializeComponent();
            this.mail = mail;
            this.mailDAO = new MailDAO();
        }

        public PromptAjouterEditerMail(int campagnaId)
        {
            InitializeComponent();
            this.mailDAO = new MailDAO();
            this.campagneId = campagnaId;
        }

        private void PromptAjouterEditerMail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_email.Text.Trim() == "" ||
                tb_nom.Text.Trim() == "" ||
                tb_prenom.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs", "error_create_update_mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MailImporter.Instance.CheckMail(tb_email.Text))
            {
                MessageBox.Show("Veuillez utiliser une adresse email valide", "error_create_update_mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.mail == null)
            {
                if (this.mailDAO.Add(new Mail(tb_nom.Text, tb_prenom.Text, tb_email.Text, this.campagneId)))
                {
                    MessageBox.Show("Adresse email créer", "add_email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

            }
            else
            {
                this.mail.nom = tb_nom.Text;
                this.mail.prenom = tb_prenom.Text;
                this.mail.email = tb_email.Text;

                if (this.mailDAO.Update(this.mail))
                {
                    MessageBox.Show("Adresse email modifée", "update_email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }
    }
}

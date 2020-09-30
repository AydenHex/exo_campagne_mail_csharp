namespace CampagneMailManager
{
    partial class ManageCampagne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._listview_mails = new System.Windows.Forms.ListView();
            this.nom_col = new System.Windows.Forms.ColumnHeader();
            this.prenom_col = new System.Windows.Forms.ColumnHeader();
            this.email_col = new System.Windows.Forms.ColumnHeader();
            this.button_add_file = new System.Windows.Forms.Button();
            this.button_add_manual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listview_mails
            // 
            this._listview_mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom_col,
            this.prenom_col,
            this.email_col});
            this._listview_mails.HideSelection = false;
            this._listview_mails.Location = new System.Drawing.Point(21, 25);
            this._listview_mails.Name = "_listview_mails";
            this._listview_mails.Size = new System.Drawing.Size(435, 392);
            this._listview_mails.TabIndex = 0;
            this._listview_mails.UseCompatibleStateImageBehavior = false;
            this._listview_mails.View = System.Windows.Forms.View.Details;
            this._listview_mails.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nom_col
            // 
            this.nom_col.Text = "Nom";
            this.nom_col.Width = 80;
            // 
            // prenom_col
            // 
            this.prenom_col.Text = "Prenom";
            this.prenom_col.Width = 100;
            // 
            // email_col
            // 
            this.email_col.Text = "Email";
            this.email_col.Width = 250;
            // 
            // button_add_file
            // 
            this.button_add_file.Location = new System.Drawing.Point(563, 86);
            this.button_add_file.Name = "button_add_file";
            this.button_add_file.Size = new System.Drawing.Size(127, 49);
            this.button_add_file.TabIndex = 1;
            this.button_add_file.Text = "Ajouter via Fichier";
            this.button_add_file.UseVisualStyleBackColor = true;
            // 
            // button_add_manual
            // 
            this.button_add_manual.Location = new System.Drawing.Point(563, 286);
            this.button_add_manual.Name = "button_add_manual";
            this.button_add_manual.Size = new System.Drawing.Size(127, 49);
            this.button_add_manual.TabIndex = 1;
            this.button_add_manual.Text = "Ajouter manuellement";
            this.button_add_manual.UseVisualStyleBackColor = true;
            // 
            // ManageCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add_manual);
            this.Controls.Add(this.button_add_file);
            this.Controls.Add(this._listview_mails);
            this.Name = "ManageCampagne";
            this.Text = "MailSender - Campagne";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _listview_mails;
        private System.Windows.Forms.ColumnHeader nom_col;
        private System.Windows.Forms.ColumnHeader prenom_col;
        private System.Windows.Forms.ColumnHeader email_col;
        private System.Windows.Forms.Button button_add_file;
        private System.Windows.Forms.Button button_add_manual;
    }
}


namespace CampagneMailManager
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._listview_campagnes = new System.Windows.Forms.ListView();
            this.col_nom_campagne = new System.Windows.Forms.ColumnHeader();
            this.button_cree_campagne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listview_campagnes
            // 
            this._listview_campagnes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nom_campagne});
            this._listview_campagnes.HideSelection = false;
            this._listview_campagnes.Location = new System.Drawing.Point(76, 32);
            this._listview_campagnes.Name = "_listview_campagnes";
            this._listview_campagnes.Size = new System.Drawing.Size(417, 332);
            this._listview_campagnes.TabIndex = 0;
            this._listview_campagnes.UseCompatibleStateImageBehavior = false;
            this._listview_campagnes.View = System.Windows.Forms.View.Details;
            // 
            // col_nom_campagne
            // 
            this.col_nom_campagne.Text = "Nom de la campagne";
            this.col_nom_campagne.Width = 410;
            // 
            // button_cree_campagne
            // 
            this.button_cree_campagne.Location = new System.Drawing.Point(191, 370);
            this.button_cree_campagne.Name = "button_cree_campagne";
            this.button_cree_campagne.Size = new System.Drawing.Size(178, 52);
            this.button_cree_campagne.TabIndex = 1;
            this.button_cree_campagne.Text = "Créer une campagne";
            this.button_cree_campagne.UseVisualStyleBackColor = true;
            this.button_cree_campagne.Click += new System.EventHandler(this.button_cree_campagne_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.button_cree_campagne);
            this.Controls.Add(this._listview_campagnes);
            this.Name = "Home";
            this.Text = "SenderMail - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _listview_campagnes;
        private System.Windows.Forms.ColumnHeader col_nom_campagne;
        private System.Windows.Forms.Button button_cree_campagne;
    }
}
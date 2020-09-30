namespace CampagneMailManager.Prompts
{
    partial class PromptCreerCampagne
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
            this.label_nouvelle_campagne = new System.Windows.Forms.Label();
            this.textbox_nom_campagne = new System.Windows.Forms.TextBox();
            this.button_creer_campagne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nouvelle_campagne
            // 
            this.label_nouvelle_campagne.AutoSize = true;
            this.label_nouvelle_campagne.Location = new System.Drawing.Point(12, 27);
            this.label_nouvelle_campagne.Name = "label_nouvelle_campagne";
            this.label_nouvelle_campagne.Size = new System.Drawing.Size(175, 15);
            this.label_nouvelle_campagne.TabIndex = 0;
            this.label_nouvelle_campagne.Text = "Nom de la nouvelle camapgne :";
            // 
            // textbox_nom_campagne
            // 
            this.textbox_nom_campagne.Location = new System.Drawing.Point(193, 24);
            this.textbox_nom_campagne.Name = "textbox_nom_campagne";
            this.textbox_nom_campagne.Size = new System.Drawing.Size(195, 23);
            this.textbox_nom_campagne.TabIndex = 1;
            // 
            // button_creer_campagne
            // 
            this.button_creer_campagne.Location = new System.Drawing.Point(165, 63);
            this.button_creer_campagne.Name = "button_creer_campagne";
            this.button_creer_campagne.Size = new System.Drawing.Size(75, 23);
            this.button_creer_campagne.TabIndex = 2;
            this.button_creer_campagne.Text = "Créer !";
            this.button_creer_campagne.UseVisualStyleBackColor = true;
            this.button_creer_campagne.Click += new System.EventHandler(this.button_creer_campagne_Click);
            // 
            // PromptCreerCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 98);
            this.Controls.Add(this.button_creer_campagne);
            this.Controls.Add(this.textbox_nom_campagne);
            this.Controls.Add(this.label_nouvelle_campagne);
            this.Name = "PromptCreerCampagne";
            this.Text = "MailSender - Créer une campagne";
            this.Load += new System.EventHandler(this.prompt_cree_campagne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nouvelle_campagne;
        private System.Windows.Forms.TextBox textbox_nom_campagne;
        private System.Windows.Forms.Button button_creer_campagne;
    }
}
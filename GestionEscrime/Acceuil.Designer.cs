namespace GestionEscrime
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClub = new System.Windows.Forms.Button();
            this.ButtonCompetition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClub
            // 
            this.buttonClub.Location = new System.Drawing.Point(446, 281);
            this.buttonClub.Name = "buttonClub";
            this.buttonClub.Size = new System.Drawing.Size(192, 59);
            this.buttonClub.TabIndex = 1;
            this.buttonClub.Text = "Acceder aux Clubs";
            this.buttonClub.UseVisualStyleBackColor = true;
            this.buttonClub.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonCompetition
            // 
            this.ButtonCompetition.Location = new System.Drawing.Point(127, 281);
            this.ButtonCompetition.Name = "ButtonCompetition";
            this.ButtonCompetition.Size = new System.Drawing.Size(192, 59);
            this.ButtonCompetition.TabIndex = 2;
            this.ButtonCompetition.Text = "Acceder aux compétitions";
            this.ButtonCompetition.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenu";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCompetition);
            this.Controls.Add(this.buttonClub);
            this.Name = "Acceuil";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClub;
        private System.Windows.Forms.Button ButtonCompetition;
        private System.Windows.Forms.Label label1;
    }
}


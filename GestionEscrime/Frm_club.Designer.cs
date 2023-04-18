namespace GestionEscrime
{
    partial class Frm_club
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clubs = new System.Windows.Forms.TabPage();
            this.AnnulerClub = new System.Windows.Forms.Button();
            this.ConfirmerClub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SupprimerClub = new System.Windows.Forms.Button();
            this.AjoutClub = new System.Windows.Forms.Button();
            this.ModifClub = new System.Windows.Forms.Button();
            this.club_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView_Clubs = new System.Windows.Forms.DataGridView();
            this.Adherent = new System.Windows.Forms.TabPage();
            this.SLclub_textBox = new System.Windows.Forms.TextBox();
            this.ConfirmerAdherent = new System.Windows.Forms.Button();
            this.AnnulerAdherent = new System.Windows.Forms.Button();
            this.SupprimerAdherent = new System.Windows.Forms.Button();
            this.AjoutAdherent = new System.Windows.Forms.Button();
            this.ModifierAdherent = new System.Windows.Forms.Button();
            this.adherent_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Adherent = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_Armes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ModifierArmes = new System.Windows.Forms.Button();
            this.SupprimerArmes = new System.Windows.Forms.Button();
            this.AjoutArmes = new System.Windows.Forms.Button();
            this.ConfirmerArmes = new System.Windows.Forms.Button();
            this.AnnulerArmes = new System.Windows.Forms.Button();
            this.adherent_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Clubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clubs)).BeginInit();
            this.Adherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clubs);
            this.tabControl1.Controls.Add(this.Adherent);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // Clubs
            // 
            this.Clubs.Controls.Add(this.AnnulerClub);
            this.Clubs.Controls.Add(this.ConfirmerClub);
            this.Clubs.Controls.Add(this.label1);
            this.Clubs.Controls.Add(this.SupprimerClub);
            this.Clubs.Controls.Add(this.AjoutClub);
            this.Clubs.Controls.Add(this.ModifClub);
            this.Clubs.Controls.Add(this.club_textBox);
            this.Clubs.Controls.Add(this.dataGridView_Clubs);
            this.Clubs.Location = new System.Drawing.Point(4, 25);
            this.Clubs.Name = "Clubs";
            this.Clubs.Padding = new System.Windows.Forms.Padding(3);
            this.Clubs.Size = new System.Drawing.Size(787, 397);
            this.Clubs.TabIndex = 0;
            this.Clubs.Text = "Clubs";
            this.Clubs.UseVisualStyleBackColor = true;
            // 
            // AnnulerClub
            // 
            this.AnnulerClub.BackColor = System.Drawing.Color.Red;
            this.AnnulerClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerClub.Location = new System.Drawing.Point(492, 295);
            this.AnnulerClub.Name = "AnnulerClub";
            this.AnnulerClub.Size = new System.Drawing.Size(168, 54);
            this.AnnulerClub.TabIndex = 7;
            this.AnnulerClub.Text = "Annuler";
            this.AnnulerClub.UseVisualStyleBackColor = false;
            // 
            // ConfirmerClub
            // 
            this.ConfirmerClub.Location = new System.Drawing.Point(296, 295);
            this.ConfirmerClub.Name = "ConfirmerClub";
            this.ConfirmerClub.Size = new System.Drawing.Size(168, 54);
            this.ConfirmerClub.TabIndex = 6;
            this.ConfirmerClub.Text = "Confirmer";
            this.ConfirmerClub.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clubs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SupprimerClub
            // 
            this.SupprimerClub.Location = new System.Drawing.Point(492, 105);
            this.SupprimerClub.Name = "SupprimerClub";
            this.SupprimerClub.Size = new System.Drawing.Size(105, 23);
            this.SupprimerClub.TabIndex = 4;
            this.SupprimerClub.Text = "Supprimer";
            this.SupprimerClub.UseVisualStyleBackColor = true;
            this.SupprimerClub.Click += new System.EventHandler(this.button3_Click);
            // 
            // AjoutClub
            // 
            this.AjoutClub.Location = new System.Drawing.Point(359, 105);
            this.AjoutClub.Name = "AjoutClub";
            this.AjoutClub.Size = new System.Drawing.Size(105, 23);
            this.AjoutClub.TabIndex = 3;
            this.AjoutClub.Text = "Ajouter";
            this.AjoutClub.UseVisualStyleBackColor = true;
            // 
            // ModifClub
            // 
            this.ModifClub.Location = new System.Drawing.Point(660, 52);
            this.ModifClub.Name = "ModifClub";
            this.ModifClub.Size = new System.Drawing.Size(105, 23);
            this.ModifClub.TabIndex = 2;
            this.ModifClub.Text = "Modifier";
            this.ModifClub.UseVisualStyleBackColor = true;
            this.ModifClub.Click += new System.EventHandler(this.button1_Click);
            // 
            // club_textBox
            // 
            this.club_textBox.Location = new System.Drawing.Point(359, 53);
            this.club_textBox.Name = "club_textBox";
            this.club_textBox.Size = new System.Drawing.Size(238, 22);
            this.club_textBox.TabIndex = 1;
            // 
            // dataGridView_Clubs
            // 
            this.dataGridView_Clubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clubs.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Clubs.Name = "dataGridView_Clubs";
            this.dataGridView_Clubs.RowHeadersWidth = 51;
            this.dataGridView_Clubs.RowTemplate.Height = 24;
            this.dataGridView_Clubs.Size = new System.Drawing.Size(240, 347);
            this.dataGridView_Clubs.TabIndex = 0;
            // 
            // Adherent
            // 
            this.Adherent.Controls.Add(this.SLclub_textBox);
            this.Adherent.Controls.Add(this.ConfirmerAdherent);
            this.Adherent.Controls.Add(this.AnnulerAdherent);
            this.Adherent.Controls.Add(this.SupprimerAdherent);
            this.Adherent.Controls.Add(this.AjoutAdherent);
            this.Adherent.Controls.Add(this.ModifierAdherent);
            this.Adherent.Controls.Add(this.adherent_textBox);
            this.Adherent.Controls.Add(this.label2);
            this.Adherent.Controls.Add(this.dataGridView_Adherent);
            this.Adherent.Location = new System.Drawing.Point(4, 25);
            this.Adherent.Name = "Adherent";
            this.Adherent.Padding = new System.Windows.Forms.Padding(3);
            this.Adherent.Size = new System.Drawing.Size(787, 397);
            this.Adherent.TabIndex = 1;
            this.Adherent.Text = "Adherent";
            this.Adherent.UseVisualStyleBackColor = true;
            // 
            // SLclub_textBox
            // 
            this.SLclub_textBox.Enabled = false;
            this.SLclub_textBox.Location = new System.Drawing.Point(226, 6);
            this.SLclub_textBox.Name = "SLclub_textBox";
            this.SLclub_textBox.Size = new System.Drawing.Size(238, 22);
            this.SLclub_textBox.TabIndex = 9;
            // 
            // ConfirmerAdherent
            // 
            this.ConfirmerAdherent.Location = new System.Drawing.Point(296, 295);
            this.ConfirmerAdherent.Name = "ConfirmerAdherent";
            this.ConfirmerAdherent.Size = new System.Drawing.Size(168, 54);
            this.ConfirmerAdherent.TabIndex = 8;
            this.ConfirmerAdherent.Text = "Confirmer";
            this.ConfirmerAdherent.UseVisualStyleBackColor = true;
            // 
            // AnnulerAdherent
            // 
            this.AnnulerAdherent.BackColor = System.Drawing.Color.Red;
            this.AnnulerAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerAdherent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerAdherent.Location = new System.Drawing.Point(492, 295);
            this.AnnulerAdherent.Name = "AnnulerAdherent";
            this.AnnulerAdherent.Size = new System.Drawing.Size(168, 54);
            this.AnnulerAdherent.TabIndex = 7;
            this.AnnulerAdherent.Text = "Annuler";
            this.AnnulerAdherent.UseVisualStyleBackColor = false;
            // 
            // SupprimerAdherent
            // 
            this.SupprimerAdherent.Location = new System.Drawing.Point(492, 105);
            this.SupprimerAdherent.Name = "SupprimerAdherent";
            this.SupprimerAdherent.Size = new System.Drawing.Size(105, 23);
            this.SupprimerAdherent.TabIndex = 5;
            this.SupprimerAdherent.Text = "Supprimer";
            this.SupprimerAdherent.UseVisualStyleBackColor = true;
            // 
            // AjoutAdherent
            // 
            this.AjoutAdherent.Location = new System.Drawing.Point(359, 105);
            this.AjoutAdherent.Name = "AjoutAdherent";
            this.AjoutAdherent.Size = new System.Drawing.Size(105, 23);
            this.AjoutAdherent.TabIndex = 4;
            this.AjoutAdherent.Text = "Ajouter";
            this.AjoutAdherent.UseVisualStyleBackColor = true;
            // 
            // ModifierAdherent
            // 
            this.ModifierAdherent.Location = new System.Drawing.Point(660, 52);
            this.ModifierAdherent.Name = "ModifierAdherent";
            this.ModifierAdherent.Size = new System.Drawing.Size(105, 23);
            this.ModifierAdherent.TabIndex = 3;
            this.ModifierAdherent.Text = "Modifier";
            this.ModifierAdherent.UseVisualStyleBackColor = true;
            // 
            // adherent_textBox
            // 
            this.adherent_textBox.Location = new System.Drawing.Point(359, 53);
            this.adherent_textBox.Name = "adherent_textBox";
            this.adherent_textBox.Size = new System.Drawing.Size(238, 22);
            this.adherent_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adherent";
            // 
            // dataGridView_Adherent
            // 
            this.dataGridView_Adherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adherent.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Adherent.Name = "dataGridView_Adherent";
            this.dataGridView_Adherent.RowHeadersWidth = 51;
            this.dataGridView_Adherent.RowTemplate.Height = 24;
            this.dataGridView_Adherent.Size = new System.Drawing.Size(240, 347);
            this.dataGridView_Adherent.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.adherent_comboBox);
            this.tabPage3.Controls.Add(this.AnnulerArmes);
            this.tabPage3.Controls.Add(this.ConfirmerArmes);
            this.tabPage3.Controls.Add(this.AjoutArmes);
            this.tabPage3.Controls.Add(this.SupprimerArmes);
            this.tabPage3.Controls.Add(this.ModifierArmes);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridView_Armes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Armes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Armes
            // 
            this.dataGridView_Armes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Armes.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Armes.Name = "dataGridView_Armes";
            this.dataGridView_Armes.RowHeadersWidth = 51;
            this.dataGridView_Armes.RowTemplate.Height = 24;
            this.dataGridView_Armes.Size = new System.Drawing.Size(240, 347);
            this.dataGridView_Armes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(67, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Armes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(359, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 22);
            this.textBox4.TabIndex = 2;
            // 
            // ModifierArmes
            // 
            this.ModifierArmes.Location = new System.Drawing.Point(660, 52);
            this.ModifierArmes.Name = "ModifierArmes";
            this.ModifierArmes.Size = new System.Drawing.Size(105, 23);
            this.ModifierArmes.TabIndex = 3;
            this.ModifierArmes.Text = "Modifier";
            this.ModifierArmes.UseVisualStyleBackColor = true;
            // 
            // SupprimerArmes
            // 
            this.SupprimerArmes.Location = new System.Drawing.Point(492, 105);
            this.SupprimerArmes.Name = "SupprimerArmes";
            this.SupprimerArmes.Size = new System.Drawing.Size(105, 23);
            this.SupprimerArmes.TabIndex = 4;
            this.SupprimerArmes.Text = "Supprimer";
            this.SupprimerArmes.UseVisualStyleBackColor = true;
            // 
            // AjoutArmes
            // 
            this.AjoutArmes.Location = new System.Drawing.Point(359, 105);
            this.AjoutArmes.Name = "AjoutArmes";
            this.AjoutArmes.Size = new System.Drawing.Size(105, 23);
            this.AjoutArmes.TabIndex = 5;
            this.AjoutArmes.Text = "Ajouter";
            this.AjoutArmes.UseVisualStyleBackColor = true;
            // 
            // ConfirmerArmes
            // 
            this.ConfirmerArmes.Location = new System.Drawing.Point(296, 295);
            this.ConfirmerArmes.Name = "ConfirmerArmes";
            this.ConfirmerArmes.Size = new System.Drawing.Size(168, 54);
            this.ConfirmerArmes.TabIndex = 6;
            this.ConfirmerArmes.Text = "Confirmer";
            this.ConfirmerArmes.UseVisualStyleBackColor = true;
            // 
            // AnnulerArmes
            // 
            this.AnnulerArmes.BackColor = System.Drawing.Color.Red;
            this.AnnulerArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerArmes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerArmes.Location = new System.Drawing.Point(492, 295);
            this.AnnulerArmes.Name = "AnnulerArmes";
            this.AnnulerArmes.Size = new System.Drawing.Size(168, 54);
            this.AnnulerArmes.TabIndex = 7;
            this.AnnulerArmes.Text = "Annuler";
            this.AnnulerArmes.UseVisualStyleBackColor = false;
            // 
            // adherent_comboBox
            // 
            this.adherent_comboBox.FormattingEnabled = true;
            this.adherent_comboBox.Location = new System.Drawing.Point(226, 6);
            this.adherent_comboBox.Name = "adherent_comboBox";
            this.adherent_comboBox.Size = new System.Drawing.Size(238, 24);
            this.adherent_comboBox.TabIndex = 8;
            // 
            // Frm_club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_club";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Clubs.ResumeLayout(false);
            this.Clubs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clubs)).EndInit();
            this.Adherent.ResumeLayout(false);
            this.Adherent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SupprimerClub;
        private System.Windows.Forms.Button AjoutClub;
        private System.Windows.Forms.Button ModifClub;
        private System.Windows.Forms.TextBox club_textBox;
        private System.Windows.Forms.DataGridView dataGridView_Clubs;
        private System.Windows.Forms.TabPage Adherent;
        private System.Windows.Forms.TextBox adherent_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Adherent;
        private System.Windows.Forms.Button SupprimerAdherent;
        private System.Windows.Forms.Button AjoutAdherent;
        private System.Windows.Forms.Button ModifierAdherent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button AnnulerClub;
        private System.Windows.Forms.Button ConfirmerClub;
        private System.Windows.Forms.Button ConfirmerAdherent;
        private System.Windows.Forms.Button AnnulerAdherent;
        private System.Windows.Forms.TextBox SLclub_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Armes;
        private System.Windows.Forms.ComboBox adherent_comboBox;
        private System.Windows.Forms.Button AnnulerArmes;
        private System.Windows.Forms.Button ConfirmerArmes;
        private System.Windows.Forms.Button AjoutArmes;
        private System.Windows.Forms.Button SupprimerArmes;
        private System.Windows.Forms.Button ModifierArmes;
        private System.Windows.Forms.TextBox textBox4;
    }
}
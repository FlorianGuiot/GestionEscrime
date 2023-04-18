namespace GestionEscrime
{
    partial class Frm_competition
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
            this.tabControlCompet = new System.Windows.Forms.TabControl();
            this.tabCompetitions = new System.Windows.Forms.TabPage();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabParticipants = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabDirectoire = new System.Windows.Forms.TabPage();
            this.tabClassement = new System.Windows.Forms.TabPage();
            this.btn_supprimer_participant = new System.Windows.Forms.Button();
            this.btn_ajouter_participant = new System.Windows.Forms.Button();
            this.btn_supprimer_maitre = new System.Windows.Forms.Button();
            this.btn_ajouter_maitre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_supprimer_classement = new System.Windows.Forms.Button();
            this.btn_ajouter_classement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControlCompet.SuspendLayout();
            this.tabCompetitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabDirectoire.SuspendLayout();
            this.tabClassement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCompet
            // 
            this.tabControlCompet.Controls.Add(this.tabCompetitions);
            this.tabControlCompet.Controls.Add(this.tabParticipants);
            this.tabControlCompet.Controls.Add(this.tabDirectoire);
            this.tabControlCompet.Controls.Add(this.tabClassement);
            this.tabControlCompet.Location = new System.Drawing.Point(3, 8);
            this.tabControlCompet.Name = "tabControlCompet";
            this.tabControlCompet.SelectedIndex = 0;
            this.tabControlCompet.Size = new System.Drawing.Size(795, 435);
            this.tabControlCompet.TabIndex = 2;
            // 
            // tabCompetitions
            // 
            this.tabCompetitions.Controls.Add(this.btn_supprimer);
            this.tabCompetitions.Controls.Add(this.btn_ajouter);
            this.tabCompetitions.Controls.Add(this.label1);
            this.tabCompetitions.Controls.Add(this.textBox1);
            this.tabCompetitions.Controls.Add(this.dataGridView1);
            this.tabCompetitions.Location = new System.Drawing.Point(4, 25);
            this.tabCompetitions.Name = "tabCompetitions";
            this.tabCompetitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompetitions.Size = new System.Drawing.Size(787, 406);
            this.tabCompetitions.TabIndex = 0;
            this.tabCompetitions.Text = "Compétitions";
            this.tabCompetitions.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_supprimer.Location = new System.Drawing.Point(492, 295);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(168, 54);
            this.btn_supprimer.TabIndex = 7;
            this.btn_supprimer.Text = "Supprimer la compétition";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(296, 295);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(168, 54);
            this.btn_ajouter.TabIndex = 6;
            this.btn_ajouter.Text = "Ajouter une compétition";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Compétition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabParticipants
            // 
            this.tabParticipants.Controls.Add(this.btn_supprimer_participant);
            this.tabParticipants.Controls.Add(this.btn_ajouter_participant);
            this.tabParticipants.Controls.Add(this.textBox2);
            this.tabParticipants.Controls.Add(this.label2);
            this.tabParticipants.Controls.Add(this.dataGridView2);
            this.tabParticipants.Location = new System.Drawing.Point(4, 25);
            this.tabParticipants.Name = "tabParticipants";
            this.tabParticipants.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipants.Size = new System.Drawing.Size(787, 406);
            this.tabParticipants.TabIndex = 1;
            this.tabParticipants.Text = "Participants";
            this.tabParticipants.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Participants";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 347);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabDirectoire
            // 
            this.tabDirectoire.Controls.Add(this.btn_supprimer_maitre);
            this.tabDirectoire.Controls.Add(this.btn_ajouter_maitre);
            this.tabDirectoire.Controls.Add(this.label3);
            this.tabDirectoire.Controls.Add(this.dataGridView3);
            this.tabDirectoire.Location = new System.Drawing.Point(4, 25);
            this.tabDirectoire.Name = "tabDirectoire";
            this.tabDirectoire.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectoire.Size = new System.Drawing.Size(787, 406);
            this.tabDirectoire.TabIndex = 2;
            this.tabDirectoire.Text = "Directoire";
            this.tabDirectoire.UseVisualStyleBackColor = true;
            // 
            // tabClassement
            // 
            this.tabClassement.Controls.Add(this.btn_supprimer_classement);
            this.tabClassement.Controls.Add(this.btn_ajouter_classement);
            this.tabClassement.Controls.Add(this.label4);
            this.tabClassement.Controls.Add(this.dataGridView4);
            this.tabClassement.Location = new System.Drawing.Point(4, 25);
            this.tabClassement.Name = "tabClassement";
            this.tabClassement.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassement.Size = new System.Drawing.Size(787, 406);
            this.tabClassement.TabIndex = 3;
            this.tabClassement.Text = "Classement";
            this.tabClassement.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer_participant
            // 
            this.btn_supprimer_participant.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer_participant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_participant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_supprimer_participant.Location = new System.Drawing.Point(492, 334);
            this.btn_supprimer_participant.Name = "btn_supprimer_participant";
            this.btn_supprimer_participant.Size = new System.Drawing.Size(168, 54);
            this.btn_supprimer_participant.TabIndex = 11;
            this.btn_supprimer_participant.Text = "Supprimer le participant";
            this.btn_supprimer_participant.UseVisualStyleBackColor = false;
            // 
            // btn_ajouter_participant
            // 
            this.btn_ajouter_participant.Location = new System.Drawing.Point(296, 334);
            this.btn_ajouter_participant.Name = "btn_ajouter_participant";
            this.btn_ajouter_participant.Size = new System.Drawing.Size(168, 54);
            this.btn_ajouter_participant.TabIndex = 10;
            this.btn_ajouter_participant.Text = "Ajouter un participant";
            this.btn_ajouter_participant.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer_maitre
            // 
            this.btn_supprimer_maitre.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer_maitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_maitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_supprimer_maitre.Location = new System.Drawing.Point(505, 337);
            this.btn_supprimer_maitre.Name = "btn_supprimer_maitre";
            this.btn_supprimer_maitre.Size = new System.Drawing.Size(168, 54);
            this.btn_supprimer_maitre.TabIndex = 15;
            this.btn_supprimer_maitre.Text = "Supprimer le maitre d\'arme";
            this.btn_supprimer_maitre.UseVisualStyleBackColor = false;
            this.btn_supprimer_maitre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ajouter_maitre
            // 
            this.btn_ajouter_maitre.Location = new System.Drawing.Point(309, 337);
            this.btn_ajouter_maitre.Name = "btn_ajouter_maitre";
            this.btn_ajouter_maitre.Size = new System.Drawing.Size(168, 54);
            this.btn_ajouter_maitre.TabIndex = 14;
            this.btn_ajouter_maitre.Text = "Ajouter un maitre d\'arme";
            this.btn_ajouter_maitre.UseVisualStyleBackColor = true;
            this.btn_ajouter_maitre.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Membres du directoire";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 44);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(240, 347);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btn_supprimer_classement
            // 
            this.btn_supprimer_classement.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer_classement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_classement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_supprimer_classement.Location = new System.Drawing.Point(505, 334);
            this.btn_supprimer_classement.Name = "btn_supprimer_classement";
            this.btn_supprimer_classement.Size = new System.Drawing.Size(168, 54);
            this.btn_supprimer_classement.TabIndex = 19;
            this.btn_supprimer_classement.Text = "Supprimer le participant";
            this.btn_supprimer_classement.UseVisualStyleBackColor = false;
            // 
            // btn_ajouter_classement
            // 
            this.btn_ajouter_classement.Location = new System.Drawing.Point(309, 334);
            this.btn_ajouter_classement.Name = "btn_ajouter_classement";
            this.btn_ajouter_classement.Size = new System.Drawing.Size(168, 54);
            this.btn_ajouter_classement.TabIndex = 18;
            this.btn_ajouter_classement.Text = "Ajouter un participant";
            this.btn_ajouter_classement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Classement";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 41);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(240, 347);
            this.dataGridView4.TabIndex = 16;
            // 
            // Frm_competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCompet);
            this.Name = "Frm_competition";
            this.Text = "GestionEscrime - Compétitions";
            this.Load += new System.EventHandler(this.Frm_competition_Load);
            this.tabControlCompet.ResumeLayout(false);
            this.tabCompetitions.ResumeLayout(false);
            this.tabCompetitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabParticipants.ResumeLayout(false);
            this.tabParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabDirectoire.ResumeLayout(false);
            this.tabDirectoire.PerformLayout();
            this.tabClassement.ResumeLayout(false);
            this.tabClassement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCompet;
        private System.Windows.Forms.TabPage tabCompetitions;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabParticipants;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabDirectoire;
        private System.Windows.Forms.TabPage tabClassement;
        private System.Windows.Forms.Button btn_supprimer_participant;
        private System.Windows.Forms.Button btn_ajouter_participant;
        private System.Windows.Forms.Button btn_supprimer_maitre;
        private System.Windows.Forms.Button btn_ajouter_maitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_supprimer_classement;
        private System.Windows.Forms.Button btn_ajouter_classement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}
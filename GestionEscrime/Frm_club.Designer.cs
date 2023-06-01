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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clubs = new System.Windows.Forms.TabPage();
            this.ville_textBox = new System.Windows.Forms.TextBox();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escrimeDataSet = new GestionEscrime.escrimeDataSet();
            this.SupprimerClub = new System.Windows.Forms.Button();
            this.ModifClub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnnulerClub = new System.Windows.Forms.Button();
            this.ConfirmerClub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AjoutClub = new System.Windows.Forms.Button();
            this.club_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView_Clubs = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adherent = new System.Windows.Forms.TabPage();
            this.comboClub = new System.Windows.Forms.ComboBox();
            this.dateTimeAdherent = new System.Windows.Forms.DateTimePicker();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAdherentLicence = new System.Windows.Forms.Label();
            this.lblAdherentDate = new System.Windows.Forms.Label();
            this.lblAdherentPrenom = new System.Windows.Forms.Label();
            this.lblAdherentNom = new System.Windows.Forms.Label();
            this.txtBoxAdherentLicence = new System.Windows.Forms.TextBox();
            this.txtBoxAdherentPrenom = new System.Windows.Forms.TextBox();
            this.SLclub_textBox = new System.Windows.Forms.TextBox();
            this.ConfirmerAdherent = new System.Windows.Forms.Button();
            this.AnnulerAdherent = new System.Windows.Forms.Button();
            this.SupprimerAdherent = new System.Windows.Forms.Button();
            this.AjoutAdherent = new System.Windows.Forms.Button();
            this.ModifierAdherent = new System.Windows.Forms.Button();
            this.txtBoxAdherentNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Adherent = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox_Lesarmes = new System.Windows.Forms.ComboBox();
            this.adherent_comboBox = new System.Windows.Forms.ComboBox();
            this.AnnulerArmes = new System.Windows.Forms.Button();
            this.ConfirmerArmes = new System.Windows.Forms.Button();
            this.AjoutArmes = new System.Windows.Forms.Button();
            this.SupprimerArmes = new System.Windows.Forms.Button();
            this.ModifierArmes = new System.Windows.Forms.Button();
            this.arme_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Armes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.ClubTableAdapter();
            this.tableAdapterManager = new GestionEscrime.escrimeDataSetTableAdapters.TableAdapterManager();
            this.adherentTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.AdherentTableAdapter();
            this.armeTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.armeTableAdapter();
            this.armerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armerTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.armerTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Clubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escrimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clubs)).BeginInit();
            this.Adherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.Clubs);
            this.tabControl1.Controls.Add(this.Adherent);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 396);
            this.tabControl1.TabIndex = 1;
            // 
            // Clubs
            // 
            this.Clubs.Controls.Add(this.ville_textBox);
            this.Clubs.Controls.Add(this.SupprimerClub);
            this.Clubs.Controls.Add(this.ModifClub);
            this.Clubs.Controls.Add(this.label5);
            this.Clubs.Controls.Add(this.label4);
            this.Clubs.Controls.Add(this.AnnulerClub);
            this.Clubs.Controls.Add(this.ConfirmerClub);
            this.Clubs.Controls.Add(this.label1);
            this.Clubs.Controls.Add(this.AjoutClub);
            this.Clubs.Controls.Add(this.club_textBox);
            this.Clubs.Controls.Add(this.dataGridView_Clubs);
            this.Clubs.Location = new System.Drawing.Point(4, 22);
            this.Clubs.Margin = new System.Windows.Forms.Padding(2);
            this.Clubs.Name = "Clubs";
            this.Clubs.Padding = new System.Windows.Forms.Padding(2);
            this.Clubs.Size = new System.Drawing.Size(790, 370);
            this.Clubs.TabIndex = 0;
            this.Clubs.Text = "Clubs";
            this.Clubs.UseVisualStyleBackColor = true;
            // 
            // ville_textBox
            // 
            this.ville_textBox.CausesValidation = false;
            this.ville_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubBindingSource, "ville", true));
            this.ville_textBox.Location = new System.Drawing.Point(385, 93);
            this.ville_textBox.Name = "ville_textBox";
            this.ville_textBox.Size = new System.Drawing.Size(238, 20);
            this.ville_textBox.TabIndex = 13;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.escrimeDataSet;
            // 
            // escrimeDataSet
            // 
            this.escrimeDataSet.DataSetName = "escrimeDataSet";
            this.escrimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SupprimerClub
            // 
            this.SupprimerClub.Location = new System.Drawing.Point(484, 132);
            this.SupprimerClub.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerClub.Name = "SupprimerClub";
            this.SupprimerClub.Size = new System.Drawing.Size(79, 19);
            this.SupprimerClub.TabIndex = 12;
            this.SupprimerClub.Text = "Supprimer";
            this.SupprimerClub.UseVisualStyleBackColor = true;
            this.SupprimerClub.Click += new System.EventHandler(this.SupprimerClub_Click);
            // 
            // ModifClub
            // 
            this.ModifClub.Location = new System.Drawing.Point(640, 70);
            this.ModifClub.Margin = new System.Windows.Forms.Padding(2);
            this.ModifClub.Name = "ModifClub";
            this.ModifClub.Size = new System.Drawing.Size(79, 19);
            this.ModifClub.TabIndex = 11;
            this.ModifClub.Text = "Modifier";
            this.ModifClub.UseVisualStyleBackColor = true;
            this.ModifClub.Click += new System.EventHandler(this.ModifClub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom :";
            // 
            // AnnulerClub
            // 
            this.AnnulerClub.BackColor = System.Drawing.Color.Red;
            this.AnnulerClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerClub.Location = new System.Drawing.Point(660, 322);
            this.AnnulerClub.Margin = new System.Windows.Forms.Padding(2);
            this.AnnulerClub.Name = "AnnulerClub";
            this.AnnulerClub.Size = new System.Drawing.Size(126, 44);
            this.AnnulerClub.TabIndex = 7;
            this.AnnulerClub.Text = "Annuler";
            this.AnnulerClub.UseVisualStyleBackColor = false;
            this.AnnulerClub.Click += new System.EventHandler(this.AnnulerClub_Click);
            // 
            // ConfirmerClub
            // 
            this.ConfirmerClub.Location = new System.Drawing.Point(422, 322);
            this.ConfirmerClub.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerClub.Name = "ConfirmerClub";
            this.ConfirmerClub.Size = new System.Drawing.Size(126, 44);
            this.ConfirmerClub.TabIndex = 6;
            this.ConfirmerClub.Text = "Confirmer";
            this.ConfirmerClub.UseVisualStyleBackColor = true;
            this.ConfirmerClub.Click += new System.EventHandler(this.ConfirmerClub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clubs";
            // 
            // AjoutClub
            // 
            this.AjoutClub.Location = new System.Drawing.Point(385, 132);
            this.AjoutClub.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutClub.Name = "AjoutClub";
            this.AjoutClub.Size = new System.Drawing.Size(79, 19);
            this.AjoutClub.TabIndex = 3;
            this.AjoutClub.Text = "Ajouter";
            this.AjoutClub.UseVisualStyleBackColor = true;
            this.AjoutClub.Click += new System.EventHandler(this.AjoutClub_Click);
            // 
            // club_textBox
            // 
            this.club_textBox.CausesValidation = false;
            this.club_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubBindingSource, "nom", true));
            this.club_textBox.Location = new System.Drawing.Point(385, 46);
            this.club_textBox.Name = "club_textBox";
            this.club_textBox.Size = new System.Drawing.Size(238, 20);
            this.club_textBox.TabIndex = 1;
            // 
            // dataGridView_Clubs
            // 
            this.dataGridView_Clubs.AutoGenerateColumns = false;
            this.dataGridView_Clubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dataGridView_Clubs.DataSource = this.clubBindingSource;
            this.dataGridView_Clubs.Location = new System.Drawing.Point(4, 32);
            this.dataGridView_Clubs.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Clubs.Name = "dataGridView_Clubs";
            this.dataGridView_Clubs.RowHeadersWidth = 51;
            this.dataGridView_Clubs.RowTemplate.Height = 24;
            this.dataGridView_Clubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Clubs.Size = new System.Drawing.Size(323, 332);
            this.dataGridView_Clubs.TabIndex = 0;
            this.dataGridView_Clubs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Clubs_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 175;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.Width = 70;
            // 
            // Adherent
            // 
            this.Adherent.Controls.Add(this.comboClub);
            this.Adherent.Controls.Add(this.dateTimeAdherent);
            this.Adherent.Controls.Add(this.lblAdherentLicence);
            this.Adherent.Controls.Add(this.lblAdherentDate);
            this.Adherent.Controls.Add(this.lblAdherentPrenom);
            this.Adherent.Controls.Add(this.lblAdherentNom);
            this.Adherent.Controls.Add(this.txtBoxAdherentLicence);
            this.Adherent.Controls.Add(this.txtBoxAdherentPrenom);
            this.Adherent.Controls.Add(this.SLclub_textBox);
            this.Adherent.Controls.Add(this.ConfirmerAdherent);
            this.Adherent.Controls.Add(this.AnnulerAdherent);
            this.Adherent.Controls.Add(this.SupprimerAdherent);
            this.Adherent.Controls.Add(this.AjoutAdherent);
            this.Adherent.Controls.Add(this.ModifierAdherent);
            this.Adherent.Controls.Add(this.txtBoxAdherentNom);
            this.Adherent.Controls.Add(this.label2);
            this.Adherent.Controls.Add(this.dataGridView_Adherent);
            this.Adherent.Location = new System.Drawing.Point(4, 22);
            this.Adherent.Margin = new System.Windows.Forms.Padding(2);
            this.Adherent.Name = "Adherent";
            this.Adherent.Padding = new System.Windows.Forms.Padding(2);
            this.Adherent.Size = new System.Drawing.Size(790, 370);
            this.Adherent.TabIndex = 1;
            this.Adherent.Text = "Adherent";
            this.Adherent.UseVisualStyleBackColor = true;
            // 
            // comboClub
            // 
            this.comboClub.DataSource = this.clubBindingSource;
            this.comboClub.FormattingEnabled = true;
            this.comboClub.Location = new System.Drawing.Point(556, 186);
            this.comboClub.Name = "comboClub";
            this.comboClub.Size = new System.Drawing.Size(180, 21);
            this.comboClub.TabIndex = 18;
            // 
            // dateTimeAdherent
            // 
            this.dateTimeAdherent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "dateNaissance", true));
            this.dateTimeAdherent.Location = new System.Drawing.Point(556, 116);
            this.dateTimeAdherent.Name = "dateTimeAdherent";
            this.dateTimeAdherent.Size = new System.Drawing.Size(180, 20);
            this.dateTimeAdherent.TabIndex = 17;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "Adherent";
            this.adherentBindingSource.DataSource = this.escrimeDataSet;
            // 
            // lblAdherentLicence
            // 
            this.lblAdherentLicence.AutoSize = true;
            this.lblAdherentLicence.Location = new System.Drawing.Point(505, 151);
            this.lblAdherentLicence.Name = "lblAdherentLicence";
            this.lblAdherentLicence.Size = new System.Drawing.Size(45, 13);
            this.lblAdherentLicence.TabIndex = 16;
            this.lblAdherentLicence.Text = "Licence";
            // 
            // lblAdherentDate
            // 
            this.lblAdherentDate.AutoSize = true;
            this.lblAdherentDate.Location = new System.Drawing.Point(468, 116);
            this.lblAdherentDate.Name = "lblAdherentDate";
            this.lblAdherentDate.Size = new System.Drawing.Size(83, 13);
            this.lblAdherentDate.TabIndex = 15;
            this.lblAdherentDate.Text = "Date Naissance";
            // 
            // lblAdherentPrenom
            // 
            this.lblAdherentPrenom.AutoSize = true;
            this.lblAdherentPrenom.Location = new System.Drawing.Point(507, 84);
            this.lblAdherentPrenom.Name = "lblAdherentPrenom";
            this.lblAdherentPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblAdherentPrenom.TabIndex = 14;
            this.lblAdherentPrenom.Text = "Prénom";
            // 
            // lblAdherentNom
            // 
            this.lblAdherentNom.AutoSize = true;
            this.lblAdherentNom.Location = new System.Drawing.Point(520, 45);
            this.lblAdherentNom.Name = "lblAdherentNom";
            this.lblAdherentNom.Size = new System.Drawing.Size(29, 13);
            this.lblAdherentNom.TabIndex = 13;
            this.lblAdherentNom.Text = "Nom";
            // 
            // txtBoxAdherentLicence
            // 
            this.txtBoxAdherentLicence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "licence", true));
            this.txtBoxAdherentLicence.Location = new System.Drawing.Point(556, 149);
            this.txtBoxAdherentLicence.Name = "txtBoxAdherentLicence";
            this.txtBoxAdherentLicence.Size = new System.Drawing.Size(180, 20);
            this.txtBoxAdherentLicence.TabIndex = 12;
            // 
            // txtBoxAdherentPrenom
            // 
            this.txtBoxAdherentPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "prenom", true));
            this.txtBoxAdherentPrenom.Location = new System.Drawing.Point(556, 80);
            this.txtBoxAdherentPrenom.Name = "txtBoxAdherentPrenom";
            this.txtBoxAdherentPrenom.Size = new System.Drawing.Size(180, 20);
            this.txtBoxAdherentPrenom.TabIndex = 10;
            // 
            // SLclub_textBox
            // 
            this.SLclub_textBox.Enabled = false;
            this.SLclub_textBox.Location = new System.Drawing.Point(282, 10);
            this.SLclub_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.SLclub_textBox.Name = "SLclub_textBox";
            this.SLclub_textBox.Size = new System.Drawing.Size(180, 20);
            this.SLclub_textBox.TabIndex = 9;
            this.SLclub_textBox.TextChanged += new System.EventHandler(this.SLclub_textBox_TextChanged);
            // 
            // ConfirmerAdherent
            // 
            this.ConfirmerAdherent.Location = new System.Drawing.Point(480, 322);
            this.ConfirmerAdherent.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerAdherent.Name = "ConfirmerAdherent";
            this.ConfirmerAdherent.Size = new System.Drawing.Size(126, 44);
            this.ConfirmerAdherent.TabIndex = 8;
            this.ConfirmerAdherent.Text = "Confirmer";
            this.ConfirmerAdherent.UseVisualStyleBackColor = true;
            this.ConfirmerAdherent.Visible = false;
            this.ConfirmerAdherent.Click += new System.EventHandler(this.ConfirmerAdherent_Click);
            // 
            // AnnulerAdherent
            // 
            this.AnnulerAdherent.BackColor = System.Drawing.Color.Red;
            this.AnnulerAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerAdherent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerAdherent.Location = new System.Drawing.Point(660, 322);
            this.AnnulerAdherent.Margin = new System.Windows.Forms.Padding(2);
            this.AnnulerAdherent.Name = "AnnulerAdherent";
            this.AnnulerAdherent.Size = new System.Drawing.Size(126, 44);
            this.AnnulerAdherent.TabIndex = 7;
            this.AnnulerAdherent.Text = "Annuler";
            this.AnnulerAdherent.UseVisualStyleBackColor = false;
            this.AnnulerAdherent.Visible = false;
            this.AnnulerAdherent.Click += new System.EventHandler(this.AnnulerAdherent_Click);
            // 
            // SupprimerAdherent
            // 
            this.SupprimerAdherent.Location = new System.Drawing.Point(598, 283);
            this.SupprimerAdherent.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerAdherent.Name = "SupprimerAdherent";
            this.SupprimerAdherent.Size = new System.Drawing.Size(79, 19);
            this.SupprimerAdherent.TabIndex = 5;
            this.SupprimerAdherent.Text = "Supprimer";
            this.SupprimerAdherent.UseVisualStyleBackColor = true;
            this.SupprimerAdherent.Click += new System.EventHandler(this.SupprimerAdherent_Click);
            // 
            // AjoutAdherent
            // 
            this.AjoutAdherent.Location = new System.Drawing.Point(523, 242);
            this.AjoutAdherent.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutAdherent.Name = "AjoutAdherent";
            this.AjoutAdherent.Size = new System.Drawing.Size(79, 19);
            this.AjoutAdherent.TabIndex = 4;
            this.AjoutAdherent.Text = "Ajouter";
            this.AjoutAdherent.UseVisualStyleBackColor = true;
            this.AjoutAdherent.Click += new System.EventHandler(this.AjoutAdherent_Click);
            // 
            // ModifierAdherent
            // 
            this.ModifierAdherent.Location = new System.Drawing.Point(674, 242);
            this.ModifierAdherent.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierAdherent.Name = "ModifierAdherent";
            this.ModifierAdherent.Size = new System.Drawing.Size(79, 19);
            this.ModifierAdherent.TabIndex = 3;
            this.ModifierAdherent.Text = "Modifier";
            this.ModifierAdherent.UseVisualStyleBackColor = true;
            this.ModifierAdherent.Click += new System.EventHandler(this.ModifierAdherent_Click);
            // 
            // txtBoxAdherentNom
            // 
            this.txtBoxAdherentNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "nom", true));
            this.txtBoxAdherentNom.Location = new System.Drawing.Point(556, 41);
            this.txtBoxAdherentNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdherentNom.Multiline = true;
            this.txtBoxAdherentNom.Name = "txtBoxAdherentNom";
            this.txtBoxAdherentNom.Size = new System.Drawing.Size(180, 20);
            this.txtBoxAdherentNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adherent";
            // 
            // dataGridView_Adherent
            // 
            this.dataGridView_Adherent.AllowUserToAddRows = false;
            this.dataGridView_Adherent.AllowUserToDeleteRows = false;
            this.dataGridView_Adherent.AutoGenerateColumns = false;
            this.dataGridView_Adherent.CausesValidation = false;
            this.dataGridView_Adherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adherent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.licenceDataGridViewTextBoxColumn});
            this.dataGridView_Adherent.DataSource = this.adherentBindingSource;
            this.dataGridView_Adherent.Location = new System.Drawing.Point(4, 32);
            this.dataGridView_Adherent.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Adherent.Name = "dataGridView_Adherent";
            this.dataGridView_Adherent.ReadOnly = true;
            this.dataGridView_Adherent.RowHeadersWidth = 51;
            this.dataGridView_Adherent.RowTemplate.Height = 24;
            this.dataGridView_Adherent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Adherent.Size = new System.Drawing.Size(446, 332);
            this.dataGridView_Adherent.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 25;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenceDataGridViewTextBoxColumn
            // 
            this.licenceDataGridViewTextBoxColumn.DataPropertyName = "licence";
            this.licenceDataGridViewTextBoxColumn.HeaderText = "licence";
            this.licenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenceDataGridViewTextBoxColumn.Name = "licenceDataGridViewTextBoxColumn";
            this.licenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenceDataGridViewTextBoxColumn.Width = 70;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.comboBox_Lesarmes);
            this.tabPage3.Controls.Add(this.adherent_comboBox);
            this.tabPage3.Controls.Add(this.AnnulerArmes);
            this.tabPage3.Controls.Add(this.ConfirmerArmes);
            this.tabPage3.Controls.Add(this.AjoutArmes);
            this.tabPage3.Controls.Add(this.SupprimerArmes);
            this.tabPage3.Controls.Add(this.ModifierArmes);
            this.tabPage3.Controls.Add(this.arme_textBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridView_Armes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(790, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Armes";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // comboBox_Lesarmes
            // 
            this.comboBox_Lesarmes.CausesValidation = false;
            this.comboBox_Lesarmes.FormattingEnabled = true;
            this.comboBox_Lesarmes.Location = new System.Drawing.Point(485, 41);
            this.comboBox_Lesarmes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Lesarmes.Name = "comboBox_Lesarmes";
            this.comboBox_Lesarmes.Size = new System.Drawing.Size(194, 21);
            this.comboBox_Lesarmes.TabIndex = 9;
            // 
            // adherent_comboBox
            // 
            this.adherent_comboBox.CausesValidation = false;
            this.adherent_comboBox.FormattingEnabled = true;
            this.adherent_comboBox.Location = new System.Drawing.Point(282, 10);
            this.adherent_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.adherent_comboBox.Name = "adherent_comboBox";
            this.adherent_comboBox.Size = new System.Drawing.Size(180, 21);
            this.adherent_comboBox.TabIndex = 8;
            this.adherent_comboBox.SelectedIndexChanged += new System.EventHandler(this.adherent_comboBox_SelectedIndexChanged);
            // 
            // AnnulerArmes
            // 
            this.AnnulerArmes.BackColor = System.Drawing.Color.Red;
            this.AnnulerArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerArmes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerArmes.Location = new System.Drawing.Point(660, 322);
            this.AnnulerArmes.Margin = new System.Windows.Forms.Padding(2);
            this.AnnulerArmes.Name = "AnnulerArmes";
            this.AnnulerArmes.Size = new System.Drawing.Size(126, 44);
            this.AnnulerArmes.TabIndex = 7;
            this.AnnulerArmes.Text = "Annuler";
            this.AnnulerArmes.UseVisualStyleBackColor = false;
            this.AnnulerArmes.Click += new System.EventHandler(this.AnnulerArmes_Click);
            // 
            // ConfirmerArmes
            // 
            this.ConfirmerArmes.Location = new System.Drawing.Point(422, 322);
            this.ConfirmerArmes.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerArmes.Name = "ConfirmerArmes";
            this.ConfirmerArmes.Size = new System.Drawing.Size(126, 44);
            this.ConfirmerArmes.TabIndex = 6;
            this.ConfirmerArmes.Text = "Confirmer";
            this.ConfirmerArmes.UseVisualStyleBackColor = true;
            this.ConfirmerArmes.Click += new System.EventHandler(this.ConfirmerArmes_Click);
            // 
            // AjoutArmes
            // 
            this.AjoutArmes.Location = new System.Drawing.Point(485, 115);
            this.AjoutArmes.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutArmes.Name = "AjoutArmes";
            this.AjoutArmes.Size = new System.Drawing.Size(79, 19);
            this.AjoutArmes.TabIndex = 5;
            this.AjoutArmes.Text = "Ajouter";
            this.AjoutArmes.UseVisualStyleBackColor = true;
            this.AjoutArmes.Click += new System.EventHandler(this.AjoutArmes_Click);
            // 
            // SupprimerArmes
            // 
            this.SupprimerArmes.Location = new System.Drawing.Point(599, 115);
            this.SupprimerArmes.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerArmes.Name = "SupprimerArmes";
            this.SupprimerArmes.Size = new System.Drawing.Size(79, 19);
            this.SupprimerArmes.TabIndex = 4;
            this.SupprimerArmes.Text = "Supprimer";
            this.SupprimerArmes.UseVisualStyleBackColor = true;
            this.SupprimerArmes.Click += new System.EventHandler(this.SupprimerArmes_Click);
            // 
            // ModifierArmes
            // 
            this.ModifierArmes.Location = new System.Drawing.Point(707, 66);
            this.ModifierArmes.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierArmes.Name = "ModifierArmes";
            this.ModifierArmes.Size = new System.Drawing.Size(79, 19);
            this.ModifierArmes.TabIndex = 3;
            this.ModifierArmes.Text = "Modifier";
            this.ModifierArmes.UseVisualStyleBackColor = true;
            this.ModifierArmes.Click += new System.EventHandler(this.ModifierArmes_Click);
            // 
            // arme_textBox
            // 
            this.arme_textBox.CausesValidation = false;
            this.arme_textBox.Location = new System.Drawing.Point(485, 67);
            this.arme_textBox.Name = "arme_textBox";
            this.arme_textBox.Size = new System.Drawing.Size(194, 20);
            this.arme_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(50, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Armes";
            // 
            // dataGridView_Armes
            // 
            this.dataGridView_Armes.AutoGenerateColumns = false;
            this.dataGridView_Armes.CausesValidation = false;
            this.dataGridView_Armes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Armes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView_Armes.DataSource = this.armeBindingSource;
            this.dataGridView_Armes.Location = new System.Drawing.Point(0, 32);
            this.dataGridView_Armes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Armes.Name = "dataGridView_Armes";
            this.dataGridView_Armes.RowHeadersWidth = 51;
            this.dataGridView_Armes.RowTemplate.Height = 24;
            this.dataGridView_Armes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Armes.Size = new System.Drawing.Size(226, 332);
            this.dataGridView_Armes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.Width = 125;
            // 
            // armeBindingSource
            // 
            this.armeBindingSource.DataMember = "arme";
            this.armeBindingSource.DataSource = this.escrimeDataSet;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdherentTableAdapter = this.adherentTableAdapter;
            this.tableAdapterManager.ArbitrerTableAdapter = null;
            this.tableAdapterManager.armerTableAdapter = null;
            this.tableAdapterManager.armeTableAdapter = this.armeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CompetitionTableAdapter = null;
            this.tableAdapterManager.MaitreArmeTableAdapter = null;
            this.tableAdapterManager.ParticiperTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionEscrime.escrimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // armeTableAdapter
            // 
            this.armeTableAdapter.ClearBeforeFill = true;
            // 
            // armerBindingSource
            // 
            this.armerBindingSource.DataMember = "armer";
            this.armerBindingSource.DataSource = this.escrimeDataSet;
            // 
            // armerTableAdapter
            // 
            this.armerTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_club";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_club_Load);
            this.tabControl1.ResumeLayout(false);
            this.Clubs.ResumeLayout(false);
            this.Clubs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escrimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clubs)).EndInit();
            this.Adherent.ResumeLayout(false);
            this.Adherent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AjoutClub;
        private System.Windows.Forms.DataGridView dataGridView_Clubs;
        private System.Windows.Forms.TabPage Adherent;
        private System.Windows.Forms.TextBox txtBoxAdherentNom;
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
        private escrimeDataSet escrimeDataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private escrimeDataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private escrimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private escrimeDataSetTableAdapters.AdherentTableAdapter adherentTableAdapter;
        private escrimeDataSetTableAdapters.armeTableAdapter armeTableAdapter;
        private System.Windows.Forms.BindingSource armeBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ModifClub;
        private System.Windows.Forms.Button SupprimerClub;

        private System.Windows.Forms.BindingSource armerBindingSource;
        private escrimeDataSetTableAdapters.armerTableAdapter armerTableAdapter;
        private System.Windows.Forms.TextBox ville_textBox;
        private System.Windows.Forms.TextBox club_textBox;

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.Label lblAdherentNom;
        private System.Windows.Forms.TextBox txtBoxAdherentLicence;
        private System.Windows.Forms.TextBox txtBoxAdherentPrenom;
        private System.Windows.Forms.Label lblAdherentLicence;
        private System.Windows.Forms.Label lblAdherentDate;
        private System.Windows.Forms.Label lblAdherentPrenom;
        private System.Windows.Forms.DateTimePicker dateTimeAdherent;
        private System.Windows.Forms.ComboBox comboClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox arme_textBox;
        private System.Windows.Forms.ComboBox comboBox_Lesarmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
    }
}
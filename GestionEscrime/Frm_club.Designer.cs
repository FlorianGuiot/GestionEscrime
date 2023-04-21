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
            this.dataGridView_Clubs = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.adherent_comboBox = new System.Windows.Forms.ComboBox();
            this.AnnulerArmes = new System.Windows.Forms.Button();
            this.ConfirmerArmes = new System.Windows.Forms.Button();
            this.AjoutArmes = new System.Windows.Forms.Button();
            this.SupprimerArmes = new System.Windows.Forms.Button();
            this.ModifierArmes = new System.Windows.Forms.Button();
            this.armeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Armes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.ClubTableAdapter();
            this.tableAdapterManager = new GestionEscrime.escrimeDataSetTableAdapters.TableAdapterManager();
            this.adherentTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.AdherentTableAdapter();
            this.armeTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.armeTableAdapter();
            this.armerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armerTableAdapter = new GestionEscrime.escrimeDataSetTableAdapters.armerTableAdapter();
            this.club_textBox = new System.Windows.Forms.TextBox();
            this.arme_textBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Clubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escrimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clubs)).BeginInit();
            this.Adherent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armerBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1064, 487);
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
            this.Clubs.Location = new System.Drawing.Point(4, 25);
            this.Clubs.Name = "Clubs";
            this.Clubs.Padding = new System.Windows.Forms.Padding(3);
            this.Clubs.Size = new System.Drawing.Size(1056, 458);
            this.Clubs.TabIndex = 0;
            this.Clubs.Text = "Clubs";
            this.Clubs.UseVisualStyleBackColor = true;
            // 
            // ville_textBox
            // 
            this.ville_textBox.CausesValidation = false;
            this.ville_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubBindingSource, "ville", true));
            this.ville_textBox.Location = new System.Drawing.Point(664, 114);
            this.ville_textBox.Name = "ville_textBox";
            this.ville_textBox.Size = new System.Drawing.Size(238, 22);
            this.ville_textBox.TabIndex = 13;
            this.ville_textBox.TextChanged += new System.EventHandler(this.ville_textBox_TextChanged);
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
            this.SupprimerClub.Location = new System.Drawing.Point(797, 162);
            this.SupprimerClub.Name = "SupprimerClub";
            this.SupprimerClub.Size = new System.Drawing.Size(105, 23);
            this.SupprimerClub.TabIndex = 12;
            this.SupprimerClub.Text = "Supprimer";
            this.SupprimerClub.UseVisualStyleBackColor = true;
            this.SupprimerClub.Click += new System.EventHandler(this.SupprimerClub_Click);
            // 
            // ModifClub
            // 
            this.ModifClub.Location = new System.Drawing.Point(945, 81);
            this.ModifClub.Name = "ModifClub";
            this.ModifClub.Size = new System.Drawing.Size(105, 23);
            this.ModifClub.TabIndex = 11;
            this.ModifClub.Text = "Modifier";
            this.ModifClub.UseVisualStyleBackColor = true;
            this.ModifClub.Click += new System.EventHandler(this.ModifClub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom :";
            // 
            // AnnulerClub
            // 
            this.AnnulerClub.BackColor = System.Drawing.Color.Red;
            this.AnnulerClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerClub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerClub.Location = new System.Drawing.Point(880, 396);
            this.AnnulerClub.Name = "AnnulerClub";
            this.AnnulerClub.Size = new System.Drawing.Size(168, 54);
            this.AnnulerClub.TabIndex = 7;
            this.AnnulerClub.Text = "Annuler";
            this.AnnulerClub.UseVisualStyleBackColor = false;
            this.AnnulerClub.Click += new System.EventHandler(this.AnnulerClub_Click);
            // 
            // ConfirmerClub
            // 
            this.ConfirmerClub.Location = new System.Drawing.Point(563, 396);
            this.ConfirmerClub.Name = "ConfirmerClub";
            this.ConfirmerClub.Size = new System.Drawing.Size(168, 54);
            this.ConfirmerClub.TabIndex = 6;
            this.ConfirmerClub.Text = "Confirmer";
            this.ConfirmerClub.UseVisualStyleBackColor = true;
            this.ConfirmerClub.Click += new System.EventHandler(this.ConfirmerClub_Click);
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
            // AjoutClub
            // 
            this.AjoutClub.Location = new System.Drawing.Point(664, 162);
            this.AjoutClub.Name = "AjoutClub";
            this.AjoutClub.Size = new System.Drawing.Size(105, 23);
            this.AjoutClub.TabIndex = 3;
            this.AjoutClub.Text = "Ajouter";
            this.AjoutClub.UseVisualStyleBackColor = true;
            this.AjoutClub.Click += new System.EventHandler(this.AjoutClub_Click);
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
            this.dataGridView_Clubs.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Clubs.Name = "dataGridView_Clubs";
            this.dataGridView_Clubs.RowHeadersWidth = 51;
            this.dataGridView_Clubs.RowTemplate.Height = 24;
            this.dataGridView_Clubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Clubs.Size = new System.Drawing.Size(551, 409);
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
            this.nomDataGridViewTextBoxColumn.Width = 125;
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
            this.Adherent.AutoScroll = true;
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
            this.Adherent.Size = new System.Drawing.Size(1056, 458);
            this.Adherent.TabIndex = 1;
            this.Adherent.Text = "Adherent";
            this.Adherent.UseVisualStyleBackColor = true;
            // 
            // SLclub_textBox
            // 
            this.SLclub_textBox.Enabled = false;
            this.SLclub_textBox.Location = new System.Drawing.Point(376, 12);
            this.SLclub_textBox.Name = "SLclub_textBox";
            this.SLclub_textBox.Size = new System.Drawing.Size(238, 22);
            this.SLclub_textBox.TabIndex = 9;
            // 
            // ConfirmerAdherent
            // 
            this.ConfirmerAdherent.Location = new System.Drawing.Point(563, 396);
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
            this.AnnulerAdherent.Location = new System.Drawing.Point(880, 396);
            this.AnnulerAdherent.Name = "AnnulerAdherent";
            this.AnnulerAdherent.Size = new System.Drawing.Size(168, 54);
            this.AnnulerAdherent.TabIndex = 7;
            this.AnnulerAdherent.Text = "Annuler";
            this.AnnulerAdherent.UseVisualStyleBackColor = false;
            // 
            // SupprimerAdherent
            // 
            this.SupprimerAdherent.Location = new System.Drawing.Point(797, 105);
            this.SupprimerAdherent.Name = "SupprimerAdherent";
            this.SupprimerAdherent.Size = new System.Drawing.Size(105, 23);
            this.SupprimerAdherent.TabIndex = 5;
            this.SupprimerAdherent.Text = "Supprimer";
            this.SupprimerAdherent.UseVisualStyleBackColor = true;
            // 
            // AjoutAdherent
            // 
            this.AjoutAdherent.Location = new System.Drawing.Point(664, 105);
            this.AjoutAdherent.Name = "AjoutAdherent";
            this.AjoutAdherent.Size = new System.Drawing.Size(105, 23);
            this.AjoutAdherent.TabIndex = 4;
            this.AjoutAdherent.Text = "Ajouter";
            this.AjoutAdherent.UseVisualStyleBackColor = true;
            this.AjoutAdherent.Click += new System.EventHandler(this.AjoutAdherent_Click);
            // 
            // ModifierAdherent
            // 
            this.ModifierAdherent.Location = new System.Drawing.Point(943, 53);
            this.ModifierAdherent.Name = "ModifierAdherent";
            this.ModifierAdherent.Size = new System.Drawing.Size(105, 23);
            this.ModifierAdherent.TabIndex = 3;
            this.ModifierAdherent.Text = "Modifier";
            this.ModifierAdherent.UseVisualStyleBackColor = true;
            this.ModifierAdherent.Click += new System.EventHandler(this.ModifierAdherent_Click);
            // 
            // adherent_textBox
            // 
            this.adherent_textBox.Location = new System.Drawing.Point(664, 54);
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
            this.dataGridView_Adherent.AutoGenerateColumns = false;
            this.dataGridView_Adherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adherent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.licenceDataGridViewTextBoxColumn,
            this.idClubDataGridViewTextBoxColumn});
            this.dataGridView_Adherent.DataSource = this.adherentBindingSource;
            this.dataGridView_Adherent.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Adherent.Name = "dataGridView_Adherent";
            this.dataGridView_Adherent.RowHeadersWidth = 51;
            this.dataGridView_Adherent.RowTemplate.Height = 24;
            this.dataGridView_Adherent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Adherent.Size = new System.Drawing.Size(551, 409);
            this.dataGridView_Adherent.TabIndex = 0;
            this.dataGridView_Adherent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Adherent_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 25;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.Width = 70;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "Naissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 80;
            // 
            // licenceDataGridViewTextBoxColumn
            // 
            this.licenceDataGridViewTextBoxColumn.DataPropertyName = "licence";
            this.licenceDataGridViewTextBoxColumn.HeaderText = "Licence";
            this.licenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenceDataGridViewTextBoxColumn.Name = "licenceDataGridViewTextBoxColumn";
            this.licenceDataGridViewTextBoxColumn.Width = 80;
            // 
            // idClubDataGridViewTextBoxColumn
            // 
            this.idClubDataGridViewTextBoxColumn.DataPropertyName = "idClub";
            this.idClubDataGridViewTextBoxColumn.HeaderText = "IdClub";
            this.idClubDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClubDataGridViewTextBoxColumn.Name = "idClubDataGridViewTextBoxColumn";
            this.idClubDataGridViewTextBoxColumn.Width = 50;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "Adherent";
            this.adherentBindingSource.DataSource = this.escrimeDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.adherent_comboBox);
            this.tabPage3.Controls.Add(this.AnnulerArmes);
            this.tabPage3.Controls.Add(this.ConfirmerArmes);
            this.tabPage3.Controls.Add(this.AjoutArmes);
            this.tabPage3.Controls.Add(this.SupprimerArmes);
            this.tabPage3.Controls.Add(this.ModifierArmes);
            this.tabPage3.Controls.Add(this.arme_textBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridView_Armes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1056, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Armes";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // adherent_comboBox
            // 
            this.adherent_comboBox.DataSource = this.adherentBindingSource;
            this.adherent_comboBox.DisplayMember = "nom";
            this.adherent_comboBox.FormattingEnabled = true;
            this.adherent_comboBox.Location = new System.Drawing.Point(376, 12);
            this.adherent_comboBox.Name = "adherent_comboBox";
            this.adherent_comboBox.Size = new System.Drawing.Size(238, 24);
            this.adherent_comboBox.TabIndex = 8;
            this.adherent_comboBox.SelectedIndexChanged += new System.EventHandler(this.adherent_comboBox_SelectedIndexChanged);
            // 
            // AnnulerArmes
            // 
            this.AnnulerArmes.BackColor = System.Drawing.Color.Red;
            this.AnnulerArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerArmes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnulerArmes.Location = new System.Drawing.Point(880, 396);
            this.AnnulerArmes.Name = "AnnulerArmes";
            this.AnnulerArmes.Size = new System.Drawing.Size(168, 54);
            this.AnnulerArmes.TabIndex = 7;
            this.AnnulerArmes.Text = "Annuler";
            this.AnnulerArmes.UseVisualStyleBackColor = false;
            this.AnnulerArmes.Click += new System.EventHandler(this.AnnulerArmes_Click);
            // 
            // ConfirmerArmes
            // 
            this.ConfirmerArmes.Location = new System.Drawing.Point(563, 396);
            this.ConfirmerArmes.Name = "ConfirmerArmes";
            this.ConfirmerArmes.Size = new System.Drawing.Size(168, 54);
            this.ConfirmerArmes.TabIndex = 6;
            this.ConfirmerArmes.Text = "Confirmer";
            this.ConfirmerArmes.UseVisualStyleBackColor = true;
            this.ConfirmerArmes.Click += new System.EventHandler(this.ConfirmerArmes_Click);
            // 
            // AjoutArmes
            // 
            this.AjoutArmes.Location = new System.Drawing.Point(664, 105);
            this.AjoutArmes.Name = "AjoutArmes";
            this.AjoutArmes.Size = new System.Drawing.Size(105, 23);
            this.AjoutArmes.TabIndex = 5;
            this.AjoutArmes.Text = "Ajouter";
            this.AjoutArmes.UseVisualStyleBackColor = true;
            this.AjoutArmes.Click += new System.EventHandler(this.AjoutArmes_Click);
            // 
            // SupprimerArmes
            // 
            this.SupprimerArmes.Location = new System.Drawing.Point(797, 105);
            this.SupprimerArmes.Name = "SupprimerArmes";
            this.SupprimerArmes.Size = new System.Drawing.Size(105, 23);
            this.SupprimerArmes.TabIndex = 4;
            this.SupprimerArmes.Text = "Supprimer";
            this.SupprimerArmes.UseVisualStyleBackColor = true;
            this.SupprimerArmes.Click += new System.EventHandler(this.SupprimerArmes_Click);
            // 
            // ModifierArmes
            // 
            this.ModifierArmes.Location = new System.Drawing.Point(943, 53);
            this.ModifierArmes.Name = "ModifierArmes";
            this.ModifierArmes.Size = new System.Drawing.Size(105, 23);
            this.ModifierArmes.TabIndex = 3;
            this.ModifierArmes.Text = "Modifier";
            this.ModifierArmes.UseVisualStyleBackColor = true;
            this.ModifierArmes.Click += new System.EventHandler(this.ModifierArmes_Click);
            // 
            // armeBindingSource
            // 
            this.armeBindingSource.DataMember = "arme";
            this.armeBindingSource.DataSource = this.escrimeDataSet;
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
            // dataGridView_Armes
            // 
            this.dataGridView_Armes.AutoGenerateColumns = false;
            this.dataGridView_Armes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Armes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView_Armes.DataSource = this.armeBindingSource;
            this.dataGridView_Armes.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_Armes.Name = "dataGridView_Armes";
            this.dataGridView_Armes.RowHeadersWidth = 51;
            this.dataGridView_Armes.RowTemplate.Height = 24;
            this.dataGridView_Armes.Size = new System.Drawing.Size(551, 409);
            this.dataGridView_Armes.TabIndex = 0;
            this.dataGridView_Armes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Armes_CellContentClick);
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
            // club_textBox
            // 
            this.club_textBox.CausesValidation = false;
            this.club_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubBindingSource, "nom", true));
            this.club_textBox.Location = new System.Drawing.Point(664, 54);
            this.club_textBox.Name = "club_textBox";
            this.club_textBox.Size = new System.Drawing.Size(238, 22);
            this.club_textBox.TabIndex = 1;
            this.club_textBox.TextChanged += new System.EventHandler(this.club_textBox_TextChanged);
            // 
            // arme_textBox
            // 
            this.arme_textBox.CausesValidation = false;
            this.arme_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.armeBindingSource, "libelle", true));
            this.arme_textBox.Location = new System.Drawing.Point(664, 54);
            this.arme_textBox.Name = "arme_textBox";
            this.arme_textBox.Size = new System.Drawing.Size(238, 22);
            this.arme_textBox.TabIndex = 2;
            this.arme_textBox.TextChanged += new System.EventHandler(this.arme_textBox_TextChanged);
            // 
            // Frm_club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 499);
            this.Controls.Add(this.tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adherent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Armes)).EndInit();
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
        private escrimeDataSet escrimeDataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private escrimeDataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private escrimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private escrimeDataSetTableAdapters.AdherentTableAdapter adherentTableAdapter;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private escrimeDataSetTableAdapters.armeTableAdapter armeTableAdapter;
        private System.Windows.Forms.BindingSource armeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ModifClub;
        private System.Windows.Forms.Button SupprimerClub;
        private System.Windows.Forms.BindingSource armerBindingSource;
        private escrimeDataSetTableAdapters.armerTableAdapter armerTableAdapter;
        private System.Windows.Forms.TextBox ville_textBox;
        private System.Windows.Forms.TextBox club_textBox;
        private System.Windows.Forms.TextBox arme_textBox;
    }
}
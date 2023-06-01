    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEscrime
    {
        public partial class Frm_club : Form
        {
            escrimeEntities context;
            List<Adherent> allAdherents;
            List<arme> lesarmes;
            List<Club> lesClubs;
            List<Armer> armerList;

            public Frm_club()
            {
                InitializeComponent();
            }

            private void Frm_club_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'escrimeDataSet.armer' table. You can move, or remove it, as needed.
                this.armerTableAdapter.Fill(this.escrimeDataSet.armer);
                // TODO: This line of code loads data into the 'escrimeDataSet.arme' table. You can move, or remove it, as needed.
                this.armeTableAdapter.Fill(this.escrimeDataSet.arme);
                // TODO: This line of code loads data into the 'escrimeDataSet.Adherent' table. You can move, or remove it, as needed.
                this.adherentTableAdapter.Fill(this.escrimeDataSet.Adherent);
                // TODO: This line of code loads data into the 'escrimeDataSet.Club' table. You can move, or remove it, as needed.
                this.clubTableAdapter.Fill(this.escrimeDataSet.Club);

                context = new escrimeEntities();

                armerList = new List<Armer>();

                this.armerBindingSource.DataSource = this.escrimeDataSet.armer;

                // ...
                //this.dataGridView_Armes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Armes_CellContentClick);
                // ...

                context.Clubs.Load();
                context.armes.Load();

                context.Adherents.Load();
            
                lesClubs = context.Clubs.Local.ToList();
                lesarmes = context.armes.Local.ToList();

                //Selectionne uniquement les simple adherents, qui sont participant
                allAdherents = (from adherent in context.Adherents.Local.ToList()
                                where adherent.MaitreArme == null
                                select adherent).ToList();
                foreach (DataRowView armerRowView in armerBindingSource)
                {
                    DataRow armerRow = armerRowView.Row;
                    int idAdherent = (int)armerRow["IdAdherent"];
                    int idArme = (int)armerRow["IdArme"];

                    Armer armer = new Armer(idAdherent, idArme);
                    armerList.Add(armer);
                }

                clubBindingSource.DataSource = lesClubs;
                armerBindingSource.DataSource = lesClubs;

                this.SetAdherentByClub((Club)clubBindingSource.Current);

                adherent_comboBox.Items.Add("Toutes Armes");

                foreach (Adherent adherent in allAdherents)
                {
                    adherent_comboBox.Items.Add(adherent);
                }


                adherent_comboBox.DisplayMember = "nom";

                comboBox_Lesarmes.DisplayMember = "libelle";

                comboBox_Lesarmes.DataSource = context.armes.Local.ToList();

                adherent_comboBox.SelectedItem = "Toutes Armes";



                this.SetAdherentByClub((Club)clubBindingSource.Current);
            }

            private void ModifClub_Click(object sender, EventArgs e)
            {
                try
                {
                    // Récupérer le club sélectionné à partir de la source de données
                    Club clubSelectionne = (Club)clubBindingSource.Current;

                    // Modifier les propriétés du club sélectionné
                    clubSelectionne.nom = club_textBox.Text;
                    clubSelectionne.ville = ville_textBox.Text;
                    // Ajoutez d'autres modifications selon vos besoins

                    // Enregistrer les modifications dans la base de données en utilisant l'instance de contexte existante
                    dataGridView_Clubs.Refresh();

                    MessageBox.Show("Club mis à jour avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void AjoutClub_Click(object sender, EventArgs e)
            {
                try
                {
                    // Créer une nouvelle instance de Club
                    Club nouveauClub = new Club();

                    // Remplir les propriétés du nouveau club avec les valeurs des TextBox
                    nouveauClub.nom = club_textBox.Text;
                    nouveauClub.ville = ville_textBox.Text;

                    // Ajouter le nouveau club à la liste des clubs dans le BindingSource
                    clubBindingSource.Add(nouveauClub);

                    // Ajouter le nouveau club à la liste des clubs dans le contexte
                    context.Clubs.Add(nouveauClub);

                    // Enregistrer les modifications dans la base de données en utilisant l'instance de contexte existante
                    //context.SaveChanges();

                    MessageBox.Show("Nouveau Club créé.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ConfirmerClub_Click(object sender, EventArgs e)
            {
                try
                {
                    clubBindingSource.EndEdit();

                    // Enregistrer les modifications dans la base de données
                    context.SaveChanges();

                    dataGridView_Clubs.Refresh();

                    MessageBox.Show("Modifications enregistrées avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void AnnulerClub_Click(object sender, EventArgs e)
            {
                try
                {
                    clubBindingSource.CancelEdit();
                    clubBindingSource.ResetBindings(true);

                    dataGridView_Clubs.Refresh();

                    MessageBox.Show("Modifications annulées avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void SupprimerClub_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Voulez-vous réellement supprimer ce Club ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Récupérer le club sélectionné à partir de la source de données
                    Club clubSelectionne = (Club)clubBindingSource.Current;

                    // Supprimer le club de la liste des clubs dans le BindingSource
                    clubBindingSource.Remove(clubSelectionne);

                    // Supprimer le club de la base de données
                    context.Clubs.Remove(clubSelectionne);

                    // Enregistrer les modifications dans la base de données


                    MessageBox.Show("Club supprimé avec succès.");
                }
            }

            private void ModifierArmes_Click(object sender, EventArgs e)
            {
                try
                {
                    string newArmeName = arme_textBox.Text;

                    // Récupérer l'adhérent sélectionné
                    string adherentSelectionne = adherent_comboBox.Text;

                    if (adherentSelectionne == "Toutes Armes")
                    {
                        if (string.IsNullOrEmpty(newArmeName))
                        {
                            MessageBox.Show("Veuillez saisir un nouveau nom pour l'arme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Récupérer l'arme sélectionnée à partir de la source de données
                        arme armeSelectionnee = dataGridView_Armes.CurrentRow.DataBoundItem as arme;

                        if (armeSelectionnee == null)
                        {
                            MessageBox.Show("Veuillez sélectionner une arme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Modifier le libellé de l'arme sélectionnée
                        armeSelectionnee.libelle = newArmeName;

                        // Enregistrer les modifications dans la base de données
                        context.SaveChanges();

                        MessageBox.Show("Nom de l'arme mis à jour avec succès.");
                        dataGridView_Armes.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner 'Toutes Armes' dans le combobox Adhérent.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void AjoutArmes_Click(object sender, EventArgs e)
            {
                try
                {
                    if (adherent_comboBox.SelectedItem is string selectedItem && selectedItem == "Toutes Armes")
                    {
                        // Handle the case when "Toutes Armes" is selected
                        // Create a new arme instance, fill its properties, and add it to the database
                        arme nouvelleArme = new arme();
                        nouvelleArme.libelle = arme_textBox.Text;
                        context.armes.Add(nouvelleArme);
                    

                        dataGridView_Armes.Refresh();
                        comboBox_Lesarmes.Refresh();
                        MessageBox.Show("L'arme a été ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (adherent_comboBox.SelectedItem is Adherent selectedAdherent && comboBox_Lesarmes.SelectedItem is arme selectedArme)
                    {
                        // Handle the case when an Adherent is selected
                        Adherent adherent = allAdherents.FirstOrDefault(a => a == selectedAdherent);
                        arme armeSelectionnee = context.armes.FirstOrDefault(a => a.libelle == selectedArme.libelle);
                    

                        if (selectedAdherent == null)
                        {
                            MessageBox.Show("Veuillez sélectionner un adhérent valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (adherent == null)
                        {
                            MessageBox.Show("L'adhérent sélectionné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (selectedArme == null)
                        {
                            MessageBox.Show("Veuillez sélectionner une arme valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (armeSelectionnee == null)
                        {
                            MessageBox.Show("L'arme sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (adherent.armes.Any(a => a.libelle == selectedArme.libelle))
                        {
                            MessageBox.Show("L'adhérent sélectionné possède déjà cette arme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        selectedAdherent.armes.Add(armeSelectionnee);
                        adherentBindingSource.Add(selectedAdherent);



                        context.SaveChanges();



                        MessageBox.Show("L'arme a été ajoutée à l'adhérent avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }




                    dataGridView_Armes.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void SupprimerArmes_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Voulez-vous réellement supprimer cette arme ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dataGridView_Armes.CurrentRow != null)
                    {
                        arme armeSelectionnee = (arme)dataGridView_Armes.CurrentRow.DataBoundItem;

                        // Si un adhérent est sélectionné dans adherent_comboBox
                        if (adherent_comboBox.SelectedItem is Adherent selectedAdherent)
                        {
                            if (selectedAdherent.nom != "Toutes Armes")
                            {
                                // Supprimer toutes les affectations de l'arme à l'adhérent

                                selectedAdherent.armes.Remove(armeSelectionnee);

                            

                            }
                        }
                        else
                        {
                            // Supprimer l'arme de la liste des armes dans le BindingSource
                            armerBindingSource.Remove(armeSelectionnee);

                            // Supprimer l'arme de la base de données
                            context.armes.Remove(armeSelectionnee);

                        




                        }




                        // Enregistrer les modifications dans la base de données
                        context.SaveChanges();

                        dataGridView_Armes.Refresh();

                        MessageBox.Show("Arme supprimée avec succès.");
                    }
                }
                else
                {

                }
            }

            private void AnnulerArmes_Click(object sender, EventArgs e)
            {
                try
                {
                    // Annuler les modifications sur l'arme en cours d'édition dans le BindingSource
                    armeBindingSource.CancelEdit();

                    // Réinitialiser le BindingSource pour refléter les valeurs d'origine
                    armeBindingSource.ResetBindings(true);


                    dataGridView_Armes.Refresh();
                    MessageBox.Show("Modifications annulées avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ConfirmerArmes_Click(object sender, EventArgs e)
            {
                try
                {
                    // Enregistrer les modifications sur l'arme en cours d'édition dans le BindingSource
                    armeBindingSource.EndEdit();

                    // Enregistrer les modifications dans la base de données
                    context.SaveChanges();

                    // Rafraîchir la table des armes pour afficher les modifications
                    dataGridView_Armes.Refresh();

                    MessageBox.Show("Modifications enregistrées avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void adherent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                Adherent selectedAdherent = adherent_comboBox.SelectedItem as Adherent;

                if (adherent_comboBox.SelectedItem.ToString() == "Toutes Armes")
                {
                    comboBox_Lesarmes.Visible = false;
                    arme_textBox.Visible = true;
                    ModifierArmes.Visible = true;

                }
                else
                {

                    comboBox_Lesarmes.Visible = true;
                    arme_textBox.Visible = false;
                    ModifierArmes.Visible = false;
                }

                SetArmesByAdherent(selectedAdherent);
            }


            private void SetArmesByAdherent(Adherent adherent)
            {
                if (adherent != null && adherent.nom != "Toutes Armes")
                {
                    List<int> armeIds = armerList
                        .Where(armer => armer.IdAdherent == adherent.id)
                        .Select(armer => armer.IdArme)
                        .ToList();

                    List<arme> filteredArmes = lesarmes
                        .Where(arme => armeIds.Contains(arme.id))
                        .ToList();

                    if (filteredArmes.Count == 0)
                    {
                        armerBindingSource.DataSource = new List<arme> { new arme { libelle = "Aucune arme disponible" } };
                    }
                    else
                    {
                        armerBindingSource.DataSource = filteredArmes;
                    }
                }
                else
                {
                    armerBindingSource.DataSource = lesarmes;
                }

                // Ajoutez le code suivant pour mettre à jour la source de données des armes dans le dataGridView_Armes
                dataGridView_Armes.DataSource = armerBindingSource;
                dataGridView_Armes.Refresh();
            }

            private void tabPage3_Enter(object sender, EventArgs e)
            {
                    //try
                    //{
                    //    // Récupérer l'objet Adherent à partir de la source de données
                    //    Adherent adherentSelectionne = (Adherent)adherentBindingSource.Current;

                    //    // Charger les armes de l'adhérent à partir de la base de données
                    //    context.Entry(adherentSelectionne).Collection(a => a.armes).Load();

                    //    // Obtenir la liste des armes de l'adhérent
                    //    List<arme> lesArmes = adherentSelectionne.armes.ToList();

                    //    // Afficher les armes dans le dataGridView_Adherent
                    //    armeBindingSource.DataSource = lesArmes;
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
            }

            private void ConfirmerAdherent_Click(object sender, EventArgs e)
            {
                try
                {
                    adherentBindingSource.EndEdit();

                    if (((Adherent)adherentBindingSource.Current).nom == null || ((Adherent)adherentBindingSource.Current).prenom == null || ((Adherent)adherentBindingSource.Current).licence == null)
                    {
                        adherentBindingSource.RemoveCurrent();
                        throw new Exception("Champs incomplet.");
                    }

                    ((Adherent)adherentBindingSource.Current).idClub = ((Club)clubBindingSource.Current).id;
                    context.Adherents.Add((Adherent)adherentBindingSource.Current);
                    context.SaveChanges();
                    this.SetAdherentByClub((Club)clubBindingSource.Current);
                    MessageBox.Show("Adhérent ajouté", "Information", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ConfirmerAdherent.Visible = false;
                AnnulerAdherent.Visible = false;
                ModifierAdherent.Visible = true;
                AjoutAdherent.Visible = true;
                comboClub.Visible = true;
        }

            private void ModifierAdherent_Click(object sender, EventArgs e)
            {
                try
                {
                    adherentBindingSource.EndEdit();
                    ((Adherent)adherentBindingSource.Current).idClub = ((Club)clubBindingSource.Current).id;
                    context.SaveChanges();
                    this.SetAdherentByClub((Club)clubBindingSource.Current);
                    MessageBox.Show("Adhérent mofifié", "Information", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void AjoutAdherent_Click(object sender, EventArgs e)
            {
                adherentBindingSource.AddNew();

                ConfirmerAdherent.Visible = true;
                AnnulerAdherent.Visible = true;
                ModifierAdherent.Visible = false;
                AjoutAdherent.Visible = false;
                comboClub.Visible = false;
            }

            private void AnnulerAdherent_Click(object sender, EventArgs e)
            {
                adherentBindingSource.CancelEdit();

                ConfirmerAdherent.Visible = false;
                AnnulerAdherent.Visible = false;
                ModifierAdherent.Visible = true;
                AjoutAdherent.Visible = true;
                comboClub.Visible = false;
                comboClub.Visible = true;
            }

            private void SetAdherentByClub(Club club)
            {
                List<Adherent> adherents = club.Adherents.ToList();
                adherentBindingSource.DataSource = adherents;
            }

            private void SupprimerAdherent_Click(object sender, EventArgs e)
            {
                try
                {
                    adherentBindingSource.EndEdit();

                    MessageBox.Show("Etes-vous sûr de vouloir supprimer cet adhérent ?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    context.Adherents.Remove((Adherent)adherentBindingSource.Current);
                    context.SaveChanges();
                    this.SetAdherentByClub((Club)clubBindingSource.Current);

                    MessageBox.Show("Supprimé", "Information", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void SLclub_textBox_TextChanged(object sender, EventArgs e)
            {
                SLclub_textBox.Text = clubBindingSource.Current?.ToString();

            }

            private void dataGridView_Clubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                this.SetAdherentByClub((Club)clubBindingSource.Current);
            }
        }
    }
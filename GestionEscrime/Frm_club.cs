using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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


        public Frm_club()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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




            context.Clubs.Load();
            context.armes.Load();
            context.Adherents.Load();

            List<Club> lesClubs = context.Clubs.Local.ToList();
            List<arme> lesarmes = context.armes.Local.ToList();

            clubBindingSource.DataSource = lesClubs;


            this.SetAdherentByClub((Club)clubBindingSource.Current);

        }




        private void club_textBox_TextChanged(object sender, EventArgs e)
        {


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






        private void dataGridView_Armes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Adherent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifierArmes_Click(object sender, EventArgs e)
        {
            try
            {
                armeBindingSource.EndEdit();

                // Instanciation de la classe DbContext
                escrimeEntities bd = new escrimeEntities();

                bd.SaveChanges();

                string message = "Arme mis à jour";
                string title = "Information";
                MessageBox.Show(message, title);
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


                // Créer une nouvelle instance d'arme
                arme nouvelleArme = new arme();

                // Remplir les propriétés de la nouvelle arme avec les valeurs des TextBox
                nouvelleArme.libelle = arme_textBox.Text;

                // Ajouter la nouvelle arme à la liste des armes dans le contexte
                armeBindingSource.Add(nouvelleArme);

                // Enregistrer les modifications dans la base de données
                context.armes.Add(nouvelleArme);

                // Actualiser la table associée à l'arme
                dataGridView_Armes.Refresh();

                MessageBox.Show("Nouvelle arme ajoutée.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


















        }




        private void SupprimerArmes_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous réellement supprimer cette arme ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Récupérer l'arme sélectionnée à partir de la source de données
                    arme armeSelectionnee = (arme)armeBindingSource.Current;

                    // Supprimer l'arme de la liste des armes dans le BindingSource
                    armeBindingSource.Remove(armeSelectionnee);

                    // Supprimer l'arme de la base de données
                    context.armes.Remove(armeSelectionnee);



                    MessageBox.Show("Arme supprimée avec succès.");

                    // Rafraîchir la table des armes
                    dataGridView_Armes.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        



        private void ville_textBox_TextChanged(object sender, EventArgs e)
        {

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

        private void arme_textBox_TextChanged(object sender, EventArgs e)
        { }

        private void adherent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                if(((Adherent)adherentBindingSource.Current).nom == null || ((Adherent)adherentBindingSource.Current).prenom == null || ((Adherent)adherentBindingSource.Current).licence == null)
                {
                    adherentBindingSource.RemoveCurrent();
                    throw new Exception("Champs incomplet.");
                }

                ((Adherent)adherentBindingSource.Current).idClub = ((Club)clubBindingSource.Current).id;
                context.Adherents.Add((Adherent)adherentBindingSource.Current);
                context.SaveChanges();
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
        }

        private void dataGridView_Clubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetAdherentByClub((Club)this.clubBindingSource.Current);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ModifierAdherent_Click(object sender, EventArgs e)
        {
            try
            {
                adherentBindingSource.EndEdit();
                ((Adherent)adherentBindingSource.Current).idClub = ((Club)clubBindingSource.Current).id;
                context.SaveChanges();
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
        }

        private void AnnulerAdherent_Click(object sender, EventArgs e)
        {
           adherentBindingSource.CancelEdit();

            ConfirmerAdherent.Visible = false;
            AnnulerAdherent.Visible = false;
            ModifierAdherent.Visible = true;
            AjoutAdherent.Visible = true;
        }

        private void SetAdherentByClub(Club club)
        {
            List<Adherent> lesAdherents = context.Adherents.ToList();
            List<Adherent> lesAdherentsDuClub = new List<Adherent>();

            foreach (Adherent a in lesAdherents)
            {
                if (a.idClub == club.id)
                {
                    lesAdherentsDuClub.Add(a);
                }
            }

            this.adherentBindingSource.DataSource = lesAdherentsDuClub;
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

    }
}

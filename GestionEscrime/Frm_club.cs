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
            armeBindingSource.DataSource = lesarmes;

            this.SetAdherentByClub((Club)clubBindingSource.Current);
        }

        private void club_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifClub_Click(object sender, EventArgs e)
        {
            try
            {
                clubBindingSource.EndEdit();

                // Instanciation de la classe DbContext
                escrimeEntities bd = new escrimeEntities();

                bd.SaveChanges();

                string message = "Club mis à jour";
                string title = "Information";
                MessageBox.Show(message, title);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AjoutClub_Click(object sender, EventArgs e)
        {
            clubBindingSource.EndEdit();
            context.Clubs.Add((Club)clubBindingSource.Current);
            context.SaveChanges();
            MessageBox.Show("Nouveau Club créé.");
            
        }

        private void ConfirmerClub_Click(object sender, EventArgs e)
        {
            clubBindingSource.EndEdit();
            
            context.SaveChanges();
            
        }

        private void AnnulerClub_Click(object sender, EventArgs e)
        {
            clubBindingSource.CancelEdit();
            clubBindingSource.ResetBindings(true);
        }

        private void SupprimerClub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce Club ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //((TypesLivre)typesLivreBindingSource.Current).libelle = libelleTextBox.Text;
                clubBindingSource.Remove(clubBindingSource.Current);
                context.SaveChanges();
            }

        }

        private void adherent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAdherentId = (int)adherent_comboBox.SelectedValue;
            ((BindingSource)dataGridView_Armes.DataSource).Filter = $"id_adherent = {selectedAdherentId}";
        }

        private void dataGridView_Armes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

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
            List<Adherent> lesAdherents = context.Adherents.ToList();

            clubBindingSource.DataSource = lesClubs;
            armeBindingSource.DataSource = lesarmes;
            adherentBindingSource.DataSource = lesAdherents;
            

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

        }
    }
}

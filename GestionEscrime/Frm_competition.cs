using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEscrime;
using System.Reflection.Emit;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GestionEscrime
{
    public partial class Frm_competition : Form
    {
        escrimeEntities context;
        bool nouveau = false;
        
        public Frm_competition()
        {
            InitializeComponent();
        }

        private void Frm_competition_Load(object sender, EventArgs e)
        {

            try
            {
                context = new escrimeEntities();
                //Chargement des données dans le contexte local
                context.Clubs.Load();
                context.armes.Load();
                context.Adherents.Load();
                context.MaitreArmes.Load();
                context.Participers.Load();
                context.Competitions.Load();
                

                competitionBindingSource.DataSource = context.Competitions.Local.ToList();

                //Récupère la liste des clubs dans la base de donnée et ajoute la liste a la combobox
                clubComboBox1.DataSource = context.Clubs.Local.ToList();
                clubComboBox1.DisplayMember = "nom";
                clubComboBox1.SelectedIndex = 0;

                //Récupère la liste des armes dans la base de donnée et ajoute la liste a la combobox
                armeComboBox.DataSource = context.armes.Local.ToList();
                armeComboBox.DisplayMember = "libelle";
                armeComboBox.SelectedIndex = 0;


                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {

                    updateCompetitionRowCells(row);
                    
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Met a jour le datagridview pour chaque compétition
        /// Ajoute la ville, le nom de l'arme, le nombre de participants etc...
        /// </summary>
        /// <param name="row"></param>
        private void updateCompetitionRowCells(DataGridViewRow row)
        {

            if (this.nouveau)
            {
                ((Competition)competitionBindingSource.Current).arme = ((arme)armeComboBox.SelectedItem);
                ((Competition)competitionBindingSource.Current).Club = ((Club)clubComboBox1.SelectedItem);

            }

            Competition competition = row.DataBoundItem as Competition;
            if (competition != null)
            {

                row.Cells["Ville"].Value = competition.Club.ville;
                row.Cells["arme"].Value = competition.arme.libelle;
                row.Cells["Participants"].Value = competition.Participers.Count;


            }

        }


        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            //Valide la création
            if (this.nouveau)
            {
                

                try
                {

                    competitionBindingSource.EndEdit();
                    context.Competitions.Add((Competition)competitionBindingSource.Current);
                    context.SaveChanges();
                    MessageBox.Show("Compétition ajoutée !");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.nouveau = false;
                dataGridView1.Enabled = true;
                groupBoxAjouterCompetition.Visible = false;

                //Change le text des boutons
                resetCompetitionBtnText();

            }
            else
            {
                //Affiche le formulaire d'ajout
                try
                {
                    this.nouveau = true;

                    //Change le text des boutons
                    resetCompetitionBtnText();

                    competitionBindingSource.AddNew();
                    ((Competition)competitionBindingSource.Current).Participers = new List<Participer>();


                    dataGridView1.Enabled = false;



                    //Affiche le formulaire d'ajout
                    groupBoxAjouterCompetition.Visible = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            
        }



        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //Bouton annuler ajout
            if (this.nouveau)
            {
                this.nouveau = false;
                competitionBindingSource.CancelEdit();
                dataGridView1.Enabled = true;
                groupBoxAjouterCompetition.Visible = false;

                //Change le text des boutons
                resetCompetitionBtnText();

            }
            else //Bouton supprimer
            {

                try
                {
                    //Confirmation
                    if(MessageBox.Show("êtes vous sur de vouloir supprimer cette compétition ?", "Supprimer la compétition",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Suppression en bdd
                        context.Competitions.Remove((Competition)competitionBindingSource.Current);
                        context.SaveChanges();

                        //Suppression dans le binding source
                        competitionBindingSource.RemoveCurrent();


                        MessageBox.Show("Compétition Supprimée !");

                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            
            
        }

        private void clubComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.nouveau)
            {
                ((Competition)competitionBindingSource.Current).Club = ((Club)clubComboBox1.SelectedItem);

                //Changement de l'affichage de la compétition en cours d'édition
                DataGridViewRow laCompetitionRow = dataGridView1.SelectedRows[0];
                updateCompetitionRowCells(laCompetitionRow);
                

            }
        }

        private void armeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nouveau)
            {
                ((Competition)competitionBindingSource.Current).arme = ((arme)armeComboBox.SelectedItem);

                //Changement de l'affichage de la compétition en cours d'édition
                DataGridViewRow laCompetitionRow = dataGridView1.SelectedRows[0];
                updateCompetitionRowCells(laCompetitionRow);

            }

        }

        /// <summary>
        /// Permet de changer le text des boutons compétitions en fonction si un formulaire d'ajout est actif ou non.
        /// </summary>
        private void resetCompetitionBtnText()
        {
            if (this.nouveau)
            {
                btn_supprimer.Text = "Annuler";
                btn_ajouter.Text = "Valider";
            }
            else
            {
                btn_supprimer.Text = "Supprimer la compétition";
                btn_ajouter.Text = "Ajouter une compétition";
            }
        }

        private void tabControlCompet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControlCompet_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void tabParticipants_Enter(object sender, EventArgs e)
        {

            //Récupération de la liste des participants
            Competition laCompetition = (Competition)competitionBindingSource.Current;
            ICollection<Participer> participerList = laCompetition.Participers;

            List<Adherent> lesParticipants = new List<Adherent>();

            foreach(Participer uneParticipation in participerList)
            {
                lesParticipants.Add(uneParticipation.Adherent);
            }


            //Ajout de la liste des participants au bindingsource
            adherentBindingSource.DataSource = lesParticipants;


            //Récupère la liste des adherent dans la base de donnée et ajoute la liste a la combobox
            List<Adherent> tousLesAdherents = context.Adherents.Local.ToList(); //Adherent et maitre d'arme

            //Selectionne uniquement les simple adherents
            List<Adherent> lesAdherents = (from adherent in tousLesAdherents.Except(lesParticipants)
                                              where adherent.MaitreArme == null 
                                           select adherent).ToList();

            participantComboBox.DataSource = lesAdherents;

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

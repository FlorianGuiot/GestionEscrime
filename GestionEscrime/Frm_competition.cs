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
            if (this.nouveau)
            {
                this.nouveau = false;
                competitionBindingSource.CancelEdit();
                dataGridView1.Enabled = true;
                groupBoxAjouterCompetition.Visible = false;

                //Change le text des boutons
                resetCompetitionBtnText();

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

    }
}

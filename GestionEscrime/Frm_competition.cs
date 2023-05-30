using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEscrime;
using System.Reflection.Emit;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.Entity.Migrations;

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


        /// <summary>
        /// Initilisation du formulaire dans son ensemble
        /// Initialisation de la page Competition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                //Met à jour l'affichage de la ville, arme et nombre participants
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {

                    updateCompetitionRowCells(row);
                    
                }

                //Si il n'y a aucune competition à supprimer, le bouton est disable
                if (competitionBindingSource.Count == 0)
                {
                    btn_supprimer.Enabled = false;
                }
                else
                {
                    btn_supprimer.Enabled = true;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabCompetitions_Enter(object sender, EventArgs e)
        {
            //Met à jour l'affichage de la ville, arme et nombre participants
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {

                updateCompetitionRowCells(row);

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

   






        /// <summary>
        /// Initialisation de la page participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            List<Adherent> tousLesAdherents = (from adherent in context.Adherents.Local.ToList()
                                               where adherent.armes.Contains(laCompetition.arme)
                                               select adherent).ToList();

            //Selectionne uniquement les simple adherents, qui sont participant
            List < Adherent > lesAdherents = (from adherent in tousLesAdherents.Except(lesParticipants)
                                              where adherent.MaitreArme == null
                                              select adherent).ToList();

            participantComboBox.DataSource = lesAdherents;

            //Si il n'y a aucun participant a ajouter, le bouton est disable.
            if(participantComboBox.Items.Count == 0)
            {
                btn_ajouter_participant.Enabled = false;
            }
            else
            {
                btn_ajouter_participant.Enabled = true;
            }


            //Si il n'y aucun participant à supprimer, le bouton est disable
            if (adherentBindingSource.Count == 0)
            {
                btn_supprimer_participant.Enabled = false;
            }
            else
            {
                btn_supprimer_participant.Enabled = true;
            }



        }


        private void btn_ajouter_participant_Click(object sender, EventArgs e)
        {

            try
            {
                //Ajout de l'adherent de la combobox dans le datasource.
                adherentBindingSource.Add(participantComboBox.SelectedItem);
                adherentBindingSource.Position = adherentBindingSource.IndexOf((Adherent)participantComboBox.SelectedItem);
                adherentBindingSource.EndEdit();


                //Création de la participation
                Participer participation = new Participer();
                participation.Competition = (Competition)competitionBindingSource.Current; //L'Adherent participe a une competition
                participation.Adherent = (Adherent)adherentBindingSource.Current; //Adherent qui participe

                //Ajout en bdd
                context.Participers.Add(participation);
                context.SaveChanges();
                MessageBox.Show("Participant ajouté !");

                //Suppression de l'adherent ajouté de la liste des participants disponibles (Regenere la page)
                tabParticipants_Enter(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void btn_supprimer_participant_Click(object sender, EventArgs e)
        {
            try
            {
                //Confirmation
                if (MessageBox.Show("êtes vous sur de vouloir supprimer ce participant ?", "Supprimer la participation",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Récupération de la participation
                    Participer participation = (from participant in context.Participers.Local.ToList()
                                                where participant.Adherent == ((Adherent)adherentBindingSource.Current) && participant.Competition == ((Competition)competitionBindingSource.Current)
                                                select participant).FirstOrDefault();

                    //Suppresion de la participation en bdd
                    context.Participers.Remove(participation);
                    context.SaveChanges();
                    MessageBox.Show("Participation Supprimée !");

                    //Ajout de l'adherent supprimé deans la liste des participants disponibles (Regenere la page)
                    tabParticipants_Enter(sender, e);

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        /// <summary>
        /// Initialisation de la page directoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabDirectoire_Enter(object sender, EventArgs e)
        {
            //Récupération de la competition
            Competition laCompetition = (Competition)competitionBindingSource.Current;

            //Récupération du gérant du directoire
            MaitreArme leGerant = laCompetition.MaitreArme;

            //Récupération de la liste des maitres d'armes du directoire 
            ICollection<MaitreArme> directoireList = laCompetition.MaitreArmes;
            List<MaitreArme> lesMembreDuDirectoire = new List<MaitreArme>();
            foreach (MaitreArme unMaitreArme in directoireList)
            {
                lesMembreDuDirectoire.Add(unMaitreArme);
            }


            //Ajout de la liste des maitres d'arme au bindingsource
            maitreArmeBindingSource.DataSource = lesMembreDuDirectoire;

            //Pour chaque membre du directoire, affiche si il est responsable ou non
            foreach(DataGridViewRow row in this.dataGridView3.Rows)
            {

                updateDirectoireRowCells(row, laCompetition);
              
            }
            this.dataGridView3.Refresh();

            //Récupére la liste de tous les maitre d'arme disponible et les ajoute a la combobox
            List<MaitreArme> lesMaitreArmeDispo = (from MaitreArme in context.MaitreArmes.Local.ToList().Except(lesMembreDuDirectoire)
                                                   select MaitreArme).ToList();

            maitreArmeComboBox.DataSource = lesMaitreArmeDispo;

            //Si il n'y a aucun maitre d'arme à ajouter, le bouton est disable.
            if (maitreArmeComboBox.Items.Count == 0)
            {
                btn_ajouter_maitre.Enabled = false;
                labelBrevet.Text = "";
            }
            else
            {
                btn_ajouter_maitre.Enabled = true;
                labelBrevet.Text = ((MaitreArme)maitreArmeComboBox.SelectedItem).brevet;
            }

            //Si il n'y aucun maitre d'arme à supprimer, le bouton est disable
            if(maitreArmeBindingSource.Count == 0)
            {
                btn_supprimer_maitre.Enabled = false;
            }
            else
            {
                btn_supprimer_maitre.Enabled = true;
            }




        }


        /// <summary>
        /// Met a jour le datagridview pour chaque directoire
        /// Affiche si le maitre d'arme est responsable ou non
        /// </summary>
        /// <param name="row">Ligne concernée par l'update</param>
        /// <param name="competition">Competition à laquelle appartient le directoire</param>
        private void updateDirectoireRowCells(DataGridViewRow row, Competition competition)
        {
           

            MaitreArme maitrArme = row.DataBoundItem as MaitreArme;
            if (maitrArme != null)
            {

                string value = "Non";

                if(competition.MaitreArme == maitrArme)
                {
                    value = "Oui";
                }

                row.Cells["Responsable"].Value = value;
              
            }
            

        }

        private void maitreArmeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelBrevet.Text = ((MaitreArme)maitreArmeComboBox.SelectedItem).brevet;
        }

        private void btn_ajouter_maitre_Click(object sender, EventArgs e)
        {
            try
            {
                MaitreArme membreAAjouter = (MaitreArme)maitreArmeComboBox.SelectedItem;
                Competition laCompetition = (Competition)competitionBindingSource.Current;

                bool ajout = true;

                //En cas d'ajout d'un responsable
                if(this.responsableRadioButtonOui.Checked == true)
                {
                    // Si il existe déja un responsable -> erreur
                    if(laCompetition.MaitreArme != null)
                    {
                        ajout = false;
                    }
                    else
                    {
                        //Ajout du responsable en bdd
                        laCompetition.MaitreArme = membreAAjouter;

                    }

                }

                //Si il n'y a pas de conflit avec le responsable
                if (ajout)
                {
                    //Ajout de l'adherent de la combobox dans le datasource.
                    maitreArmeBindingSource.Add(membreAAjouter);
                    maitreArmeBindingSource.Position = maitreArmeBindingSource.IndexOf(membreAAjouter);
                    maitreArmeBindingSource.EndEdit();


                    //Ajout de la compétition 
                    laCompetition.MaitreArmes.Add(membreAAjouter); //Ajout du maitre d'arme au directoire

                    //Ajout en bdd du membre du directoire
                    context.MaitreArmes.AddOrUpdate(membreAAjouter);
                    context.Competitions.AddOrUpdate(laCompetition);

                    context.SaveChanges();
                    MessageBox.Show("Membre ajouté !");

                    //Suppression du maitre d'arme ajouté de la liste des membres disponibles (Regenere la page)
                    tabDirectoire_Enter(sender, e);

                }
                else
                {
                    //Si il existe déja un responsable 
                    MessageBox.Show("Il existe déja un responsable pour cette compétition", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_supprimer_maitre_Click(object sender, EventArgs e)
        {
            try
            {
                //Confirmation
                if (MessageBox.Show("êtes vous sur de vouloir supprimer ce membre du directoire ?", "Supprimer le membre",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Récupération de la competition
                    Competition laCompetition = (Competition)competitionBindingSource.Current;

                    //Récupération du maitre d'arme
                    MaitreArme leMaitreArme = (MaitreArme)maitreArmeBindingSource.Current;

                    //Suppresion du membre
                    laCompetition.MaitreArmes.Remove(leMaitreArme);

                    //Si le membre est reponsable
                    if(laCompetition.MaitreArme == leMaitreArme)
                    {
                        //Suppression du responsable
                        laCompetition.MaitreArme = null;
                    }


                    //Suppresion du membre en bdd
                    context.Competitions.AddOrUpdate(laCompetition);
                    context.SaveChanges();

                    MessageBox.Show("Membre du directoire Supprimé !");

                    //Ajout du maitre d'arme supprimé deans la liste des maitres d'arme disponibles (Regenere la page)
                    tabDirectoire_Enter(sender, e);

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabClassement_Enter(object sender, EventArgs e)
        {
            //Récupération de la competition
            Competition laCompetition = (Competition)competitionBindingSource.Current;

            //Récupération des participants
            List<Participer> lesParticipants = (from participant in context.Participers.ToList()
                                                where participant.Competition == laCompetition
                                                orderby participant.classement
                                                select participant).ToList();

            //Ajout des participants au bidingsource
            participerBindingSource.DataSource = lesParticipants;

           
        }

        private void btn_ajouter_classement_Click(object sender, EventArgs e)
        {
            try
            {
                

                //La competition
                Competition laCompetition = (Competition)competitionBindingSource.Current;

                //Le participant modifié
                Participer laParticipation = (Participer)participerBindingSource.Current;


                bool ajout = true;
                int? backupPosition = laParticipation.classement;

                //Si le classement est vide
                if (string.IsNullOrWhiteSpace(classementTextBox.Text))
                {
                    //Suppression
                    //Confirmation
                    if (MessageBox.Show("êtes vous sur de vouloir supprimer la position de ce participant ?", "Supprimer la position",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        laParticipation.classement = null;

                    }

                }
                else
                {
                    //Récupération de la position saisie par l'utilisateur
                    int position = int.Parse(classementTextBox.Text);
                    laParticipation.classement = position;

                    //les autres participants
                    List<Participer> lesAutresParticipants = new List<Participer>();
                    foreach (Participer uneParticipation in (List<Participer>)participerBindingSource.List)
                    {
                        lesAutresParticipants.Add(uneParticipation);
                    }
                    lesAutresParticipants.Remove(laParticipation);

                    int i = 0;

                    //Si la position est supérieur au nombre de participant : Ajout impossible
                    if (laParticipation.classement > lesAutresParticipants.Count + 1 || laParticipation.classement <= 0) { ajout = false; }

                    //Test si la position n'est pas déja occupée
                    while (i < lesAutresParticipants.Count && ajout)
                    {
                        //Si un participant à déja le meme classement
                        if (lesAutresParticipants[i].classement == laParticipation.classement)
                        {
                            ajout = false; //Ajout impossible
                        }
                        i++;
                    }

                }
                

                

                //Position impossible
                if (!ajout)
                {
                    //Annulation de la modification
                    laParticipation.classement = backupPosition;
                    MessageBox.Show("La position est déja utilisée ou n'est tout simplement pas possible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else //Position possible
                {
                    participerBindingSource.EndEdit();

                    //Ajout en bdd du classement
                    context.Participers.AddOrUpdate(laParticipation);
                    context.Competitions.AddOrUpdate(laCompetition);

                    context.SaveChanges();
                    MessageBox.Show("Position modifiée !");

                    //Actualisation du classement
                    tabClassement_Enter(sender, e);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

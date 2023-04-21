using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEscrime
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_club form2 = new Frm_club();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonCompetition_Click(object sender, EventArgs e)
        {
            Frm_competition form2 = new Frm_competition();
            form2.Show();

        }
    }
}

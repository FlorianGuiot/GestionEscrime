using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEscrime
{
    public partial class Adherent
    {

        public override string ToString()
        {
            return id + " - " + prenom + " " + nom + " - " + dateNaissance;
        }


        // Foreign key property
        public int? ArmeId { get; set; }

        // Navigation property to the arme entity
        public virtual arme arme { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEscrime
{
    public partial class MaitreArme
    {

        public override string ToString()
        {
            return id + " - " + Adherent.prenom + " " + Adherent.nom + " - " + Adherent.dateNaissance;
        }

    }
}

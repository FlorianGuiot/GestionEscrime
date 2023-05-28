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

    }
}

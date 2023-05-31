using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEscrime
{
    public class Armer
    {
        public int IdAdherent { get; set; }
        public int IdArme { get; set; }
        public arme Arme { get; set; }

        public Armer(int idAdherent, int idArme)
        {
            IdAdherent = idAdherent;
            IdArme = idArme;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEscrime
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participer
    {
        public int idAdherent { get; set; }
        public int idCompetition { get; set; }
        public Nullable<int> classement { get; set; }
    
        public virtual Adherent Adherent { get; set; }
        public virtual Competition Competition { get; set; }
    }
}

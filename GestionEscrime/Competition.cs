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
    
    public partial class Competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competition()
        {
            this.Participers = new HashSet<Participer>();
            this.MaitreArmes = new HashSet<MaitreArme>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> idClub { get; set; }
        public Nullable<int> idArme { get; set; }
        public Nullable<int> idGerant { get; set; }
    
        public virtual arme arme { get; set; }
        public virtual Club Club { get; set; }
        public virtual MaitreArme MaitreArme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participer> Participers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaitreArme> MaitreArmes { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pruebaformularios
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipologiaDocumental
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipologiaDocumental()
        {
            this.Folios = new HashSet<Folio>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> EntidadID { get; set; }
    
        public virtual EntidadFinanciera EntidadFinanciera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folio> Folios { get; set; }
    }
}
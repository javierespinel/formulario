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
    
    public partial class Folio
    {
        public int ID { get; set; }
        public string RutaImagen { get; set; }
        public Nullable<int> TipologiaID { get; set; }
        public Nullable<int> CarpetaID { get; set; }
    
        public virtual Carpeta Carpeta { get; set; }
        public virtual TipologiaDocumental TipologiaDocumental { get; set; }
    }
}
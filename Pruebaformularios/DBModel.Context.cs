﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pruebaEntities : DbContext
    {
        public pruebaEntities()
            : base("name=pruebaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Carpeta> Carpetas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<EntidadFinanciera> EntidadFinancieras { get; set; }
        public virtual DbSet<Folio> Folios { get; set; }
        public virtual DbSet<TipologiaDocumental> TipologiaDocumentals { get; set; }
    }
}
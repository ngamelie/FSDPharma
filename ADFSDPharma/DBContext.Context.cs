//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADFSDPharma
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pharmaEntities : DbContext
    {
        public pharmaEntities()
            : base("name=pharmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<medication> medications { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<photo> photos { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<suplier> supliers { get; set; }
        public virtual DbSet<usr> usrs { get; set; }
    }
}

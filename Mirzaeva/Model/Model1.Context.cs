//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mirzaeva.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class barberMIrzaevaEntities : DbContext
    {
        public barberMIrzaevaEntities()
            : base("name=barberMIrzaevaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Barber> Barber { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}

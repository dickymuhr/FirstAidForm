namespace FirstAidForm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProfilNotesModel : DbContext
    {
        public ProfilNotesModel()
            : base("name=ProfilNotesModel")
        {
        }

        public virtual DbSet<ProfilNote> ProfilNotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

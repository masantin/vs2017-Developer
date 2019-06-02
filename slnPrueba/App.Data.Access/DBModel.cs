namespace App.Data.Access
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using App.Entities.Base;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=cnxDBModel")
        {
        }

        public virtual DbSet<AlumnoADO> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Grado> Grado { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Seccion> Seccion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnoADO>()
                .Property(e => e.Sexo)
                .IsFixedLength();

            modelBuilder.Entity<AlumnoADO>()
                .HasMany(e => e.Matricula)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlumnoADO>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Matricula)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Seccion)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);
        }
    }
}

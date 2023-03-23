using System;
using Restaurante.Dominio.Entidades;
using Restaurante.Infra.Data.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace Restaurante.Infra.Data.Contextos
{
    public class Contexto : DbContext
    {
        public DbSet<Prato> Pratos { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options) {
            if (Database.GetPendingMigrations().Count() > 0)
                Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

        }

        public IDbContextTransaction InitTransacao() {
            if (Transaction == null) Transaction = this.Database.BeginTransaction();
            return Transaction;
        }


        private void RollBack() {
            if (Transaction != null) {
                Transaction.Rollback();
            }
        }

        private void Salvar() {
            try {
                ChangeTracker.DetectChanges();
                SaveChanges();
            } catch (Exception ex) {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit() {
            if (Transaction != null) {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges() {
            Salvar();
            Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PratoMap());
        }
    }
}

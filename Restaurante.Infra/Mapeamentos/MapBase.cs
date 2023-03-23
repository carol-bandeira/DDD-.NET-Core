using Restaurante.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Restaurante.Infra.Data.Mapeamentos
{
    public class MapBase<T> : IEntityTypeConfiguration<T> 
        where T : EntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        }
    }
}

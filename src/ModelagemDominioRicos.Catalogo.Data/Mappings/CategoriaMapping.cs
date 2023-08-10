using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelagemDominioRiscocurso.Catalogo.Domain;

namespace ModelagemDominioRicos.Catalogo.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // 1: N => Categorias : Produtos
            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);


            builder.ToTable("Categorias");
        }

    }
}

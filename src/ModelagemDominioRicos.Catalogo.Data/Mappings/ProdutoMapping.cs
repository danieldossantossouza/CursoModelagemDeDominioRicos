using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelagemDominioRiscocurso.Catalogo.Domain;

namespace ModelagemDominioRicos.Catalogo.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
           builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(p => p.Imagem)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.OwnsOne(c => c.Dimensoes, cm =>
            {
                cm.Property(c => c.Altura)
                .HasColumnName("Altura")
                .HasColumnType("int");

                cm.Property(c => c.Largura)
                .HasColumnName("Largura")
                .HasColumnType("int");

                cm.Property(c => c.Profundidade)
                .HasColumnName("Profundidade")
                .HasColumnType("int");
            });

            builder.ToTable("Produtos");
        }
    }
}
